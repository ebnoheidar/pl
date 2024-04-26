using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.Tokens
{
    internal class BaseToken
    {
        public string Type { get; set; }
        public string Lexem { get; set; }
        public string Token { get; set; }
    }
}
