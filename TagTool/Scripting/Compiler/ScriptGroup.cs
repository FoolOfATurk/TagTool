using System;

namespace TagTool.Scripting.Compiler
{
    public class ScriptGroup : IScriptSyntax
    {
        public IScriptSyntax Head;
        public IScriptSyntax Tail;

        public int Line { get; set; }

		public override string ToString() {
			// old implementation
			// return $"ScriptGroup {{ Line: {Line}, Head: {Head}, Tail: {Tail} }}";
			// JSON version
			return $"{{ \"({Line}) HEAD\": {Head},{Environment.NewLine}\"({Tail?.Line.ToString() ?? string.Empty}) TAIL\": {Tail} }}";
		}
	}
}