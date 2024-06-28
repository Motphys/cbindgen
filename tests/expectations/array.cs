using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo {
  public enum Tag {
    A,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct A_Body {
    public float[] _0;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public A_Body a;
  }

  public Variants variants;
}
