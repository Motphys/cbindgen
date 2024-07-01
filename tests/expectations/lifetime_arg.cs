using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct A {
  public int* data;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct E {
  public enum Tag {
    V,
    U,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct U_Body {
    public byte* _0;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public U_Body u;
  }

  public Variants variants;
}
