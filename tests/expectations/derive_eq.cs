using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo {
  [MarshalAs(UnmanagedType.U1)]
  public bool a;
  public int b;

  bool operator==(const Foo& aOther) const {
    return a == aOther.a &&
           b == aOther.b;
  }
  bool operator!=(const Foo& aOther) const {
    return a != aOther.a ||
           b != aOther.b;
  }
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Bar {
  public enum Tag : byte {
    Baz,
    Bazz,
    FooNamed,
    FooParen,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Bazz_Body {
    public Tag tag;
    public Foo named;

    bool operator==(const Bazz_Body& aOther) const {
      return named == aOther.named;
    }
    bool operator!=(const Bazz_Body& aOther) const {
      return named != aOther.named;
    }
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct FooNamed_Body {
    public Tag tag;
    public int different;
    public uint fields;

    bool operator==(const FooNamed_Body& aOther) const {
      return different == aOther.different &&
             fields == aOther.fields;
    }
    bool operator!=(const FooNamed_Body& aOther) const {
      return different != aOther.different ||
             fields != aOther.fields;
    }
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct FooParen_Body {
    public Tag tag;
    public int _0;
    public Foo _1;

    bool operator==(const FooParen_Body& aOther) const {
      return _0 == aOther._0 &&
             _1 == aOther._1;
    }
    bool operator!=(const FooParen_Body& aOther) const {
      return _0 != aOther._0 ||
             _1 != aOther._1;
    }
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public Bazz_Body bazz;
  [FieldOffset(0)]
  public FooNamed_Body foo_named;
  [FieldOffset(0)]
  public FooParen_Body foo_paren;
}
