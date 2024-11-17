using System;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Tags;

namespace TagTool.Scripting
{
	[TagStructure(Size = 0x18)]
	public class HsSyntaxNode : TagStructure
	{
		public ushort Identifier;
		public ushort Opcode;
		public HsType ValueType;
		public HsSyntaxNodeFlags Flags;
		public DatumHandle NextExpressionHandle;
		public uint StringAddress;

		[TagField(Length = 4)]
		public byte[] Data;

		public short LineNumber;
		public short Unknown;

		/// <summary>
		/// Returns a HaloOnline-specific representation of the syntax node.
		/// </summary>
		public override string ToString() {
			return $"[{HsType.GetString(ValueType)} '{ScriptInfo.ED_GetOpCodeName(Opcode)}']";
		}

		public string FlagName {
			get {
				switch ((ushort)Flags) {
					case 0: return "Invalid";
					case 1: return "Primitive";
					case 2: return "ScriptIndex";
					case 4: return "GlobalIndex";
					case 8: return "DoNotGC";
					case 9: return "Expression";
					case 10: return "ScriptReference";
					case 13: return "GlobalsReference";
					case 16: return "ParameterIndex";
					case 29: return "ParameterReference";
					case 32: return "Extern";
					case 40: return "ExternReference";
					case 41: return "ExternExpression";
					default: return "Invalid";
				}
			}
		}

		public static string GetFlagName(ushort flag) {
			switch (flag) {
				case 1: return "Primitive";
				case 2: return "ScriptIndex";
				case 4: return "GlobalIndex";
				case 8: return "DoNotGC";
				case 9: return "Expression";
				case 10: return "ScriptReference";
				case 13: return "GlobalsReference";
				case 16: return "ParameterIndex";
				case 29: return "ParameterReference";
				case 32: return "Extern";
				case 40: return "ExternReference";
				case 41: return "ExternExpression";
				default: return "Unknown";
			}
		}

	}

	/// <summary>
	/// 0xBABA (47,802) Invalid. All flags past 32 include the DoNotGC flag.<br/>
	/// 1 Primitive. 02 ScriptIndex. 04 GlobalIndex. 8 DoNotGC. 16 ParameterIndex. 32 Extern.<br/>
	/// </summary>
	[Flags]
	public enum HsSyntaxNodeFlags : ushort
	{
		Invalid = 0xBABA,

		Primitive = 1 << 0,         // 1
		ScriptIndex = 1 << 1,       // 2
		GlobalIndex = 1 << 2,       // 4
		DoNotGC = 1 << 3,           // 8
		ParameterIndex = 1 << 4,    // 16
		Extern = 1 << 5,            // 32 ED-Specific

		Group = DoNotGC,                                                            // 8
		Expression = Primitive | DoNotGC,                                           // 9
		ScriptReference = ScriptIndex | DoNotGC,                                    // 10
		GlobalsReference = Primitive | GlobalIndex | DoNotGC,                       // 13
		ParameterReference = Primitive | GlobalIndex | ParameterIndex | DoNotGC,    // 29
		ExternReference = DoNotGC | Extern,                                         // 40
		ExternExpression = Primitive | DoNotGC | Extern                             // 41
	}

}

