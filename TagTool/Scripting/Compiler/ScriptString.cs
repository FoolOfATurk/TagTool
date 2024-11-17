namespace TagTool.Scripting.Compiler
{
    public class ScriptString : IScriptSyntax
    {
        public string Value;

        public int Line { get; set; }

		public override string ToString() {
			// old version
			//return $"ScriptString {{ Line: {Line}, Value: \"{Value}\" }}";
			// JSON version
			return $"{{ \"({Line}) STRING\": \"{Value}\" }}";
		}
	}
}