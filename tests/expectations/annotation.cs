using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public enum C : uint {
  X = 2,
  Y,
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct A {
  public int m0;

  A(public int const& m0)
    : m0(m0)
  {}

  bool operator<(const A& other) const {
    return m0 < other.m0;
  }
  bool operator<=(const A& other) const {
    return m0 <= other.m0;
  }
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct B {
  public int x;
  public float y;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct F {
  public enum Tag : byte {
    Foo,
    Bar,
    Baz,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Foo_Body {
    public Tag tag;
    public short _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Bar_Body {
    public Tag tag;
    public byte x;
    public short y;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public Foo_Body foo;
  [FieldOffset(0)]
  public Bar_Body bar;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct H {
  public enum Tag : byte {
    Hello,
    There,
    Everyone,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Hello_Body {
    public short _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct There_Body {
    public byte x;
    public short y;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public Hello_Body hello;
    [FieldOffset(0)]
    public There_Body there;
  }

  public Variants variants;
}
