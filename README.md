# core

Useful functions and commands for Microsoft Excel.
\
\
<b><u>Functions:</u></b>\
\
<b>bool RegExIsMatch(string input, string pattern)</b>\
Check if input matches pattern.\
\
<b>string RegExMatch(string input, string pattern, int group = 0, int capture = 0)</b>\
Retrieve a string matched by a pattern. Expected usage: obtain sub-strings with a help of groups.\
\
<b>string RegExMatches(string input, string pattern, int match = 0, int group = 0, int capture = 0)</b>\
Similar to RegExMatch, but you can choose which match to take, in case several matches are present.\
\
<b>string RegExReplace(string input, string pattern, string replacement)</b>\
Replace a string or a sub-string in case there is a match.\
\
<b>decimal GetCBRFXRate(DateTime date, string currency, bool bypassCache = false)</b>\
Get foreign exchange rate from http://www.cbr.ru. \
Date - date to obtain quotation for.\
Currency - 3-character currency code.\
BypassCache=true - a request to cbr.ru should be made at each function call, otherwise (by default) - cached values can be used.\
\
<b>string MD5Hash(string input)</b>\
Returns MD5 hash of the input string.\
\
<b>string TranslitRU(string input)</b>\
Transliterates Russian-language string.\
\
<b>string TranslitUA(string input)</b>\
Transliterates Ukrainian-language string with a simplified version of TransliterateRU's algorithm.\
\
\
<b><u>Commands:</u></b>\
\
<b>SwitchReferenceStyle()</b>\
Switches "reference style" between "R1C1" and "A1".\
\
<b>SwitchPrecisionAsDisplayed()</b>\
Turns "precision as displayed" on and off.\
\
<b>SwitchAllowEditingDirectlyInCells()</b>\
Turns "allow editing directly in cells" on and off.\
\
<b>ClearCBRFXRateCache()</b>\
Clears cache of CBR FX rates.
