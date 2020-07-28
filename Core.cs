//NVD Core Excel functions and commands
//Copyright © 2019, Nikolay Dudkin

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program.If not, see<https://www.gnu.org/licenses/>.

using ExcelDna.Integration;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Concurrent;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;

namespace Core
{
	public static class Core
	{
		private static ConcurrentDictionary<string, ConcurrentDictionary<DateTime, decimal>> cbrFXRateCache = new ConcurrentDictionary<string, ConcurrentDictionary<DateTime, decimal>>();

		[ExcelFunction(Description = "RegExIsMatch", IsThreadSafe = true)]
		public static bool RegExIsMatch(string input, string pattern)
		{
			Regex regex = new Regex(pattern);
			return (regex.IsMatch(input));
		}

		[ExcelFunction(Description = "RegExMatch(string input, string pattern, int group = 0, int capture = 0)", IsThreadSafe = true)]
		public static string RegExMatch(string input, string pattern, int group = 0, int capture = 0)
		{
			Regex regex = new Regex(pattern);
			Match match = regex.Match(input);
			if (!match.Success)
				return "";
			return match.Groups[group]?.Captures[capture]?.Value ?? "";
		}

		[ExcelFunction(Description = "RegExMatches(string input, string pattern, int match = 0, int group = 0, int capture = 0)", IsThreadSafe = true)]
		public static string RegExMatches(string input, string pattern, int match = 0, int group = 0, int capture = 0)
		{
			Regex regex = new Regex(pattern);
			if (!regex.IsMatch(input))
				return "";

			MatchCollection matches = regex.Matches(input);

			return matches[match]?.Groups[group]?.Captures[capture]?.Value ?? "";
		}

		[ExcelFunction(Description = "RegExReplace(string input, string pattern, string replacement)", IsThreadSafe = true)]
		public static string RegExReplace(string input, string pattern, string replacement)
		{
			Regex regex = new Regex(pattern);
			return regex.Replace(input, replacement);
		}

		[ExcelFunction(Description = "GetCBRFXRate(DateTime date, string currency, bool bypassCache)", IsThreadSafe = true)]
		public static decimal GetCBRFXRate(DateTime date, string currency, bool bypassCache = false)
		{
			decimal rate = 0;
			DateTime d = date.Date;

			try
			{
				if (!bypassCache && cbrFXRateCache.ContainsKey(currency) && cbrFXRateCache[currency].ContainsKey(d))
					return cbrFXRateCache[currency][d];

				CBRWebService.DailyInfoSoapClient cbr = new CBRWebService.DailyInfoSoapClient(new BasicHttpBinding(), new EndpointAddress("http://www.cbr.ru/DailyInfoWebServ/DailyInfo.asmx"));

				DataRow row = cbr.GetCursOnDate(d).Tables[0].Select().Where(r => r["VchCode"].Equals(currency)).FirstOrDefault();
				if (row != null)
				{
					rate = (decimal)row["Vcurs"] / (decimal)row["Vnom"];
				}

				((ICommunicationObject)cbr).Close();

				if (!cbrFXRateCache.ContainsKey(currency))
					cbrFXRateCache.TryAdd(currency, new ConcurrentDictionary<DateTime, decimal>());
				cbrFXRateCache[currency].AddOrUpdate(d, rate, (olddate, oldrate) => rate);
			}
			catch { }

			return rate;
		}

		[ExcelFunction(Description = "MD5Hash(string input)", IsThreadSafe = true)]
		public static string MD5Hash(string input)
		{
			return string.Concat(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input)).Select(x => x.ToString("x2")));
		}

		[ExcelFunction(Description = "TranslitRU(string input)", IsThreadSafe = true)]
		public static string TranslitRU(string input)
		{
			return new TranslitRU().Transliterate(input);
		}

		[ExcelFunction(Description = "TranslitUA(string input)", IsThreadSafe = true)]
		public static string TranslitUA(string input)
		{
			return new TranslitUA().Transliterate(input);
		}

		[ExcelFunction(Description = "CoreAbout()", IsThreadSafe = true)]
		public static string CoreAbout()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			return ((AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(executingAssembly, typeof(AssemblyDescriptionAttribute))).Description + " " + executingAssembly.GetName().Version.ToString() + ", " + ((AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(executingAssembly, typeof(AssemblyCopyrightAttribute))).Copyright;
		}

		[ExcelCommand(Description = "Switch reference style between R1C1 and A1.")]
		public static void SwitchReferenceStyle()
		{
			Application excel = (Application)ExcelDnaUtil.Application;
			if (excel.Application.ReferenceStyle == XlReferenceStyle.xlA1)
				excel.Application.ReferenceStyle = XlReferenceStyle.xlR1C1;
			else
				excel.Application.ReferenceStyle = XlReferenceStyle.xlA1;
		}

		[ExcelCommand(Description = "Switch precision as displayed.")]
		public static void SwitchPrecisionAsDisplayed()
		{
			Application excel = (Application)ExcelDnaUtil.Application;
			if (excel.Application.ActiveWorkbook != null)
				excel.Application.ActiveWorkbook.PrecisionAsDisplayed = !excel.Application.ActiveWorkbook.PrecisionAsDisplayed;
		}

		[ExcelCommand(Description = "Switch allow editing directly in cells.")]
		public static void SwitchAllowEditingDirectlyInCells()
		{
			Application excel = (Application)ExcelDnaUtil.Application;
			excel.Application.EditDirectlyInCell = !excel.Application.EditDirectlyInCell;
		}

		[ExcelCommand(Description = "Clean CBR FX rate cache.")]
		public static void ClearCBRFXRateCache()
		{
			cbrFXRateCache.Clear();
		}
	}
}
