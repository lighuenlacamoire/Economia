using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIDIFCommon.Tools
{
    public static class Constancts
    {
        public static string DateShortFormat = "yyyy-MM-dd";

        public static string PrefijoValorDecimal = "ValorDecimal";

        public const string SPECIFIED_SUFFIX = "Specified";

        public static CultureInfo culture = CultureInfo.InvariantCulture;

        public static NumberFormatInfo numberFormat = new NumberFormatInfo { NumberGroupSeparator = "", NumberDecimalSeparator = ".", NumberDecimalDigits = 2 };

        public enum FechaTipo
        {
            SIMPLE, MEDIA, COMPUESTA
        }
    }
}
