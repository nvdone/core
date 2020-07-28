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

using System.Collections.Generic;

namespace Core
{
	class TranslitUA
	{
		private Dictionary<string, string> alpha;
		private Dictionary<string, string> nonvowels;
		private Dictionary<string, string> zhishi;

		public TranslitUA()
		{
			alpha = new Dictionary<string, string>
			{
				{"а", "a"},
				{"б", "b"},
				{"в", "v"},
				{"г", "g"},
				{"ґ", "g"},
				{"д", "d"},
				{"е", "e"},
				{"є", "e"},
				{"ж", "zh"},
				{"з", "z"},
				{"и", "i"},
				{"і", "i"},
				{"ї", "i"},
				{"й", "y"},
				{"к", "k"},
				{"л", "l"},
				{"м", "m"},
				{"н", "n"},
				{"о", "o"},
				{"п", "p"},
				{"р", "r"},
				{"с", "s"},
				{"т", "t"},
				{"у", "u"},
				{"ф", "f"},
				{"х", "kh"},
				{"ц", "ts"},
				{"ч", "ch"},
				{"ш", "sh"},
				{"щ", "shch"},
				{"ь", "'"},
				{"ю", "yu"},
				{"я", "ya"},
				{"А", "A"},
				{"Б", "B"},
				{"В", "V"},
				{"Г", "G"},
				{"Ґ", "G"},
				{"Д", "D"},
				{"Е", "E"},
				{"Є", "E"},
				{"Ж", "Zh"},
				{"З", "Z"},
				{"И", "I"},
				{"І", "I"},
				{"Ї", "I"},
				{"Й", "Y"},
				{"К", "K"},
				{"Л", "L"},
				{"М", "M"},
				{"Н", "N"},
				{"О", "O"},
				{"П", "P"},
				{"Р", "R"},
				{"С", "S"},
				{"Т", "T"},
				{"У", "U"},
				{"Ф", "F"},
				{"Х", "Kh"},
				{"Ц", "Td"},
				{"Ч", "Ch"},
				{"Ш", "Sh"},
				{"Щ", "Shch"},
				{"Ь", "'"},
				{"Ю", "Yu"},
				{"Я", "Ya"},
			};

			nonvowels = new Dictionary<string, string>
			{
				{"б", "b"},
				{"в", "v"},
				{"г", "g"},
				{"ґ", "g"},
				{"д", "d"},
				{"ж", "zh"},
				{"з", "z"},
				{"й", "y"},
				{"к", "k"},
				{"л", "l"},
				{"м", "m"},
				{"н", "n"},
				{"п", "p"},
				{"р", "r"},
				{"с", "s"},
				{"т", "t"},
				{"ф", "f"},
				{"х", "kh"},
				{"ц", "ts"},
				{"ч", "ch"},
				{"ш", "sh"},
				{"щ", "shch"},
				{"Б", "B"},
				{"В", "V"},
				{"Г", "G"},
				{"Ґ", "G"},
				{"Д", "D"},
				{"Ж", "Zh"},
				{"З", "Z"},
				{"Й", "Y"},
				{"К", "K"},
				{"Л", "L"},
				{"М", "M"},
				{"Н", "N"},
				{"П", "P"},
				{"Р", "R"},
				{"С", "S"},
				{"Т", "T"},
				{"Ф", "F"},
				{"Х", "Kh"},
				{"Ц", "Ts"},
				{"Ч", "Ch"},
				{"Ш", "Sh"},
				{"Щ", "Shch"}
			};

			zhishi = new Dictionary<string, string>
			{
				{"ж", "zh"},
				{"ч", "ch"},
				{"ш", "sh"},
				{"щ", "shch"},
				{"Ж", "Zh"},
				{"Ч", "Ch"},
				{"Ш", "Sh"},
				{"Щ", "Shch"}
			};

		}
		public string Transliterate(string src)
		{
			string chr = "";
			string pchr = "";
			string dest = "";

			for (int i = 0; i < src.Length; i++)
			{
				chr = src.Substring(i, 1);

				if (chr == "е")
				{
					if (i == 0)
					{
						dest += "ye";
						continue;
					}

					pchr = src.Substring(i - 1, 1);

					if ((pchr == " ") || (pchr == "."))
					{
						dest += "ye";
						continue;
					}

					if (nonvowels.ContainsKey(pchr))
					{
						dest += "e";
						continue;
					}

					dest += "ye";
					continue;
				}

				if (chr == "и" || chr == "і" || chr == "ї")
				{
					if (i == 0)
					{
						dest += "i";
						continue;
					}

					pchr = src.Substring(i - 1, 1);

					if ((pchr == "ь") || (pchr == "Ь"))
					{
						dest += "yi";
						continue;
					}

					dest += "i";
					continue;
				}

				if (chr == "Е")
				{
					if (i == 0)
					{
						dest += "Ye";
						continue;
					}

					pchr = src.Substring(i - 1, 1);

					if ((pchr == " ") || (pchr == "."))
					{
						dest += "Ye";
						continue;
					}

					if (nonvowels.ContainsKey(pchr))
					{
						dest += "E";
						continue;
					}

					dest += "Ye";
					continue;
				}

				if (chr == "И" || chr == "І" || chr == "Ї")
				{
					if (i == 0)
					{
						dest += "I";
						continue;
					}

					pchr = src.Substring(i - 1, 1);

					if ((pchr == "ь") || (pchr == "Ь"))
					{
						dest += "Yi";
						continue;
					}

					dest += "I";
					continue;
				}

				if (alpha.ContainsKey(chr))
				{
					dest += alpha[chr];
				}
				else
					dest += chr;
			}
			return dest;
		}
	}
}
