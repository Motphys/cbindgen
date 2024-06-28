#define MY_ASSERT(...) do { } while (0)
#define MY_ATTRS __attribute((noinline))


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct I {

}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct H {
  public enum Tag : byte {
    H_Foo,
    H_Bar,
    H_Baz,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct H_Foo_Body {
    public short _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct H_Bar_Body {
    public byte x;
    public short y;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public H_Foo_Body foo;
    [FieldOffset(0)]
    public H_Bar_Body bar;
  }

  public Variants variants;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct J {
  public enum Tag : byte {
    J_Foo,
    J_Bar,
    J_Baz,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct J_Foo_Body {
    public short _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct J_Bar_Body {
    public byte x;
    public short y;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public J_Foo_Body foo;
    [FieldOffset(0)]
    public J_Bar_Body bar;
  }

  public Variants variants;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct K {
  public enum Tag : byte {
    K_Foo,
    K_Bar,
    K_Baz,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct K_Foo_Body {
    public Tag tag;
    public short _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct K_Bar_Body {
    public Tag tag;
    public byte x;
    public short y;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public K_Foo_Body foo;
  [FieldOffset(0)]
  public K_Bar_Body bar;
}
