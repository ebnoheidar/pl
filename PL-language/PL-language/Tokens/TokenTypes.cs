using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens
{
    internal static class TokenTypes
    {
        internal static string Keyword = "keyword";
        internal static string Id = "id";
        internal static string Sign = "sign";
        internal static string Comment = "comment";
        internal static string Number = "number";
        internal static string ConstantString = "constant string";
        internal static string Operators = "operators";
        internal static string Whitespace = "white space";
    }
}
