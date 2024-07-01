using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public enum C : uint {
  X = 2,
  Y,
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct A {
  public int _0;

  friend std::ostream& operator<<(std::ostream& stream, const A& instance) {
    return stream << "{ " << "_0=" << instance._0 << " }";
  }
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct B {
  public int x;
  public float y;

  friend std::ostream& operator<<(std::ostream& stream, const B& instance) {
    return stream << "{ " << "x=" << instance.x << ", "
                          << "y=" << instance.y << " }";
  }
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct D {
  public byte List;
  public nuint Of;
  public B Things;

  friend std::ostream& operator<<(std::ostream& stream, const D& instance) {
    return stream << "{ " << "List=" << instance.List << ", "
                          << "Of=" << instance.Of << ", "
                          << "Things=" << instance.Things << " }";
  }
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

    friend std::ostream& operator<<(std::ostream& stream, const Foo_Body& instance) {
      return stream << "{ " << "tag=" << instance.tag << ", "
                            << "_0=" << instance._0 << " }";
    }
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Bar_Body {
    public Tag tag;
    public byte x;
    public short y;

    friend std::ostream& operator<<(std::ostream& stream, const Bar_Body& instance) {
      return stream << "{ " << "tag=" << instance.tag << ", "
                            << "x=" << instance.x << ", "
                            << "y=" << instance.y << " }";
    }
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

    friend std::ostream& operator<<(std::ostream& stream, const Hello_Body& instance) {
      return stream << "{ " << "_0=" << instance._0 << " }";
    }
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct There_Body {
    public byte x;
    public short y;

    friend std::ostream& operator<<(std::ostream& stream, const There_Body& instance) {
      return stream << "{ " << "x=" << instance.x << ", "
                            << "y=" << instance.y << " }";
    }
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

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct I {
  public enum Tag : byte {
    ThereAgain,
    SomethingElse,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct ThereAgain_Body {
    public byte x;
    public short y;

    friend std::ostream& operator<<(std::ostream& stream, const ThereAgain_Body& instance) {
      return stream << "{ " << "x=" << instance.x << ", "
                            << "y=" << instance.y << " }";
    }
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public ThereAgain_Body there_again;
  }

  public Variants variants;
}
