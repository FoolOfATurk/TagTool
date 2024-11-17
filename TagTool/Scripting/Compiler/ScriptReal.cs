namespace TagTool.Scripting.Compiler
{
    public class ScriptReal : IScriptSyntax
    {
        public double Value;

        public int Line { get; set; }

		public override string ToString() {
			// old version
			// return $"ScriptReal {{ Line: {Line}, Value: {Value} }}";
			// JSON version
			return $"{{ \"({Line}) REAL\": {Value} }}";
		}
	}
}