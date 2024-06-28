using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo_Bar {
  public int* something;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Bar {
  public enum Tag : byte {
    Min,
    Max,
    Other,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Min_Body {
    public Tag tag;
    public Foo_Bar _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Max_Body {
    public Tag tag;
    public Foo_Bar _0;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public Min_Body min;
  [FieldOffset(0)]
  public Max_Body max;
}
