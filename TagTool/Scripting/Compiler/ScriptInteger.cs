namespace TagTool.Scripting.Compiler
{
    public class ScriptInteger : IScriptSyntax
    {
        public long Value;

        public int Line { get; set; }

		public override string ToString() {
			// old version
			//return $"ScriptInteger {{ Line: {Line}, Value: {Value} }}";
			// JSON version
			return $"{{ \"({Line}) INT\": {Value} }}";
		}
	}
}