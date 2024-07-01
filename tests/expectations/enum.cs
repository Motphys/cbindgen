#if 0
''' '
#endif

#ifdef __cplusplus
template <typename T>
using Box = T*;
#endif

#if 0
' '''
#endif


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public enum A : ulong {
  a1 = 0,
  a2 = 2,
  a3,
  a4 = 5,
}

public enum B : uint {
  b1 = 0,
  b2 = 2,
  b3,
  b4 = 5,
}

public enum C : ushort {
  c1 = 0,
  c2 = 2,
  c3,
  c4 = 5,
}

public enum D : byte {
  d1 = 0,
  d2 = 2,
  d3,
  d4 = 5,
}

// WARNING: Type byte, sbyte, short, ushort, int, uint, long, or ulong expected,
// but found nuint instead.
// This is a limitation of C# enums, which only support those types.
// Please consider using a different type for this enum.
// See https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs1008 for more information.
// The size of the enum will be set to int to avoid compilation errors.
// It could be different from it's size in rust, use with caution.
public enum E {
  e1 = 0,
  e2 = 2,
  e3,
  e4 = 5,
}

// WARNING: Type byte, sbyte, short, ushort, int, uint, long, or ulong expected,
// but found nint instead.
// This is a limitation of C# enums, which only support those types.
// Please consider using a different type for this enum.
// See https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs1008 for more information.
// The size of the enum will be set to int to avoid compilation errors.
// It could be different from it's size in rust, use with caution.
public enum F {
  f1 = 0,
  f2 = 2,
  f3,
  f4 = 5,
}

public enum L {
  l1,
  l2,
  l3,
  l4,
}

public enum M : sbyte {
  m1 = -1,
  m2 = 0,
  m3 = 1,
}

public enum N {
  n1,
  n2,
  n3,
  n4,
}

public enum O : sbyte {
  o1,
  o2,
  o3,
  o4,
}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct J {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct K {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct Opaque {

}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct G {
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
  public enum Tag {
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
internal unsafe partial struct ExI {
  public enum Tag : byte {
    ExI_Foo,
    ExI_Bar,
    ExI_Baz,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct ExI_Foo_Body {
    public short _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct ExI_Bar_Body {
    public byte x;
    public short y;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public ExI_Foo_Body foo;
    [FieldOffset(0)]
    public ExI_Bar_Body bar;
  }

  public Variants variants;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct P {
  public enum Tag : byte {
    P0,
    P1,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct P0_Body {
    public byte _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct P1_Body {
    public byte _0;
    public byte _1;
    public byte _2;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public P0_Body p0;
    [FieldOffset(0)]
    public P1_Body p1;
  }

  public Variants variants;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Q {
  public enum Tag {
    Ok,
    Err,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Ok_Body {
    public uint* _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Err_Body {
    public uint _0;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public Ok_Body ok;
    [FieldOffset(0)]
    public Err_Body err;
  }

  public Variants variants;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct R {
  public enum Tag {
    IRFoo,
    IRBar,
    IRBaz,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct IRFoo_Body {
    public short _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct IRBar_Body {
    public byte x;
    public short y;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public IRFoo_Body IRFoo;
    [FieldOffset(0)]
    public IRBar_Body IRBar;
  }

  public Variants variants;
}

#if 0
''' '
#endif

#include <stddef.h>
#include "testing-helpers.h"
static_assert(offsetof(CBINDGEN_STRUCT(P), tag) == 0, "unexpected offset for tag");
static_assert(offsetof(CBINDGEN_STRUCT(P), p0) == 1, "unexpected offset for p0");
static_assert(offsetof(CBINDGEN_STRUCT(P), p0) == 1, "unexpected offset for p1");
static_assert(sizeof(CBINDGEN_STRUCT(P)) == 4, "unexpected size for P");

#if 0
' '''
#endif
