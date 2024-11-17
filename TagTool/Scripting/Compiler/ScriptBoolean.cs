namespace TagTool.Scripting.Compiler
{
    public class ScriptBoolean : IScriptSyntax
    {
        public bool Value;

        public int Line { get; set; }

		public override string ToString() {
			// old version
			// return $"ScriptBoolean {{ Line: {Line}, Value: {Value} }}";
			// JSON version
			return $"{{\"({Line}) VAL\": {Value} }}";
		}
	}
}