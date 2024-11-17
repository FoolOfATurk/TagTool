namespace TagTool.Scripting.Compiler
{
    public class EndOfFile : IScriptSyntax
    {
        public int Line { get; set; }

		public override string ToString() {
			// old version
			// return $"EndOfFile {{ Line: {Line} }}";
			// JSON version
			return $"{{ \"EOF_Line\": {Line} }}";
		}
	}
}