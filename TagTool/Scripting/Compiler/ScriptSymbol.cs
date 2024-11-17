namespace TagTool.Scripting.Compiler
{
    public class ScriptSymbol : IScriptSyntax
    {
        public string Value;

        public int Line { get; set; }

		public override string ToString() {
			// old version
			// return $"ScriptSymbol {{ Line: {Line}, Value: \"{Value}\" }}";
			// JSON version
			return $"{{ \"({Line}) SYMBOL\": \"{Value}\" }}";
		}
	}
}