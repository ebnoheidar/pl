using PL_language.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_language.States
{
    internal abstract class StateBase
    {
        public StateBase BeforeState { get; set; }
        public string StateName { get; set; }
        public abstract StateBase ReadCharacter(char input, DFA dfa);

    }
}
