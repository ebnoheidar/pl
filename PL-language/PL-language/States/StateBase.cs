namespace PL_language.States
{
    internal abstract class StateBase
    {
        public StateBase BeforeState { get; set; }
        public string StateName { get; set; }
        public abstract StateBase ReadCharacter();

    }
}
