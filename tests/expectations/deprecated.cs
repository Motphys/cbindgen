#define DEPRECATED_FUNC __attribute__((deprecated))
#define DEPRECATED_STRUCT __attribute__((deprecated))
#define DEPRECATED_ENUM __attribute__((deprecated))
#define DEPRECATED_ENUM_VARIANT __attribute__((deprecated))
#define DEPRECATED_FUNC_WITH_NOTE(...) __attribute__((deprecated(__VA_ARGS__)))
#define DEPRECATED_STRUCT_WITH_NOTE(...) __attribute__((deprecated(__VA_ARGS__)))
#define DEPRECATED_ENUM_WITH_NOTE(...) __attribute__((deprecated(__VA_ARGS__)))
#define DEPRECATED_ENUM_VARIANT_WITH_NOTE(...) __attribute__((deprecated(__VA_ARGS__)))


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public enum DEPRECATED_ENUM DeprecatedEnum : int {
  A = 0,
}

public enum DEPRECATED_ENUM_WITH_NOTE("This is a note") DeprecatedEnumWithNote : int {
  B = 0,
}

public enum EnumWithDeprecatedVariants : int {
  C = 0,
  D DEPRECATED_ENUM_VARIANT = 1,
  E DEPRECATED_ENUM_VARIANT_WITH_NOTE("This is a note") = 2,
  F DEPRECATED_ENUM_VARIANT_WITH_NOTE("This is a note") = 3,
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct DEPRECATED_STRUCT DeprecatedStruct {
  public int a;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct DEPRECATED_STRUCT_WITH_NOTE("This is a note") DeprecatedStructWithNote {
  public int a;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct EnumWithDeprecatedStructVariants {
  public enum Tag : byte {
    Foo,
    Bar DEPRECATED_ENUM_VARIANT,
    Baz DEPRECATED_ENUM_VARIANT_WITH_NOTE("This is a note"),
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Foo_Body {
    public Tag tag;
    public short _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct DEPRECATED_STRUCT Bar_Body {
    public Tag tag;
    public byte x;
    public short y;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct DEPRECATED_STRUCT_WITH_NOTE("This is a note") Baz_Body {
    public Tag tag;
    public byte x;
    public byte y;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public Foo_Body foo;
  [FieldOffset(0)]
  public Bar_Body bar;
  [FieldOffset(0)]
  public Baz_Body baz;
}
