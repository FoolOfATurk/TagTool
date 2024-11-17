namespace TagTool.Scripting.Compiler
{
    public class ScriptInvalid : IScriptSyntax
    {
        public int Line { get; set; }

		public override string ToString() {
			// old version
			//return $"ScriptBoolean {{ Line: {Line} }}";
			// JSON version
			return $"{{ \"INVALID_Line\": {Line} }}";
		}
	}
}