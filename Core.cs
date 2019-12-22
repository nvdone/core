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
using System.Reflection;
using System.Text.RegularExpressions;

namespace Core
{
    public static class Core
    {
        [ExcelFunction(Description = "RegExIsMatch")]
        public static bool RegExIsMatch(string input, string pattern)
        {
            Regex regex = new Regex(pattern);
            return (regex.IsMatch(input));
        }

        [ExcelFunction(Description = "RegExMatch (string input, string pattern, int group = 0, int capture = 0)")]
        public static string RegExMatch(string input, string pattern, int group = 0, int capture = 0)
        {
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            if (!match.Success)
                return "";
            return match.Groups[group]?.Captures[capture]?.Value ?? "";
        }

        [ExcelFunction(Description = "RegExMatches (string input, string pattern, int match = 0, int group = 0, int capture = 0)")]
        public static string RegExMatches(string input, string pattern, int match = 0, int group = 0, int capture = 0)
        {
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(input))
                return "";

            MatchCollection matches = regex.Matches(input);

            return matches[match]?.Groups[group]?.Captures[capture]?.Value ?? "";
        }

        [ExcelFunction(Description = "RegExReplace( string input, string pattern, string replacement)")]
        public static string RegExReplace(string input, string pattern, string replacement)
        {
            Regex regex = new Regex(pattern);
            return regex.Replace(input, replacement);
        }

        [ExcelFunction(Description = "CoreAbout()")]
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
            if(excel.Application.ActiveWorkbook != null)
                excel.Application.ActiveWorkbook.PrecisionAsDisplayed = !excel.Application.ActiveWorkbook.PrecisionAsDisplayed;
        }

        [ExcelCommand(Description = "Switch allow editing directly in cells.")]
        public static void SwitchAllowEditingDirectlyInCells()
        {
            Application excel = (Application)ExcelDnaUtil.Application;
            excel.Application.EditDirectlyInCell = !excel.Application.EditDirectlyInCell;
        }
    }
}
