using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;














[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct PREFIX_AbsoluteFontWeight {
  public enum Tag : byte {
    Weight,
    Normal,
    Bold,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct PREFIX_Weight_Body {
    public Tag tag;
    public float _0;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public PREFIX_Weight_Body weight;
}
