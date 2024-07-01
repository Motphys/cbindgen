#define NOINLINE __attribute__((noinline))
#define NODISCARD [[nodiscard]]


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public enum FillRule : byte {
  A,
  B,
}

/// This will have a destructor manually implemented via variant_body, and
/// similarly a Drop impl in Rust.
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct OwnedSlice_u32 {
  public nuint len;
  public uint* ptr;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Polygon_u32 {
  public FillRule fill;
  public OwnedSlice_u32 coordinates;
}

/// This will have a destructor manually implemented via variant_body, and
/// similarly a Drop impl in Rust.
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct OwnedSlice_i32 {
  public nuint len;
  public int* ptr;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo_u32 {
  public enum Tag : byte {
    Bar_u32,
    Polygon1_u32,
    Slice1_u32,
    Slice2_u32,
    Slice3_u32,
    Slice4_u32,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Polygon1_Body_u32 {
    public Polygon_u32 _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Slice1_Body_u32 {
    public OwnedSlice_u32 _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Slice2_Body_u32 {
    public OwnedSlice_i32 _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Slice3_Body_u32 {
    public FillRule fill;
    public OwnedSlice_u32 coords;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Slice4_Body_u32 {
    public FillRule fill;
    public OwnedSlice_i32 coords;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public Polygon1_Body_u32 polygon1;
    [FieldOffset(0)]
    public Slice1_Body_u32 slice1;
    [FieldOffset(0)]
    public Slice2_Body_u32 slice2;
    [FieldOffset(0)]
    public Slice3_Body_u32 slice3;
    [FieldOffset(0)]
    public Slice4_Body_u32 slice4;
  }

  public Variants variants;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Polygon_i32 {
  public FillRule fill;
  public OwnedSlice_i32 coordinates;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Baz_i32 {
  public enum Tag : byte {
    Bar2_i32,
    Polygon21_i32,
    Slice21_i32,
    Slice22_i32,
    Slice23_i32,
    Slice24_i32,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Polygon21_Body_i32 {
    public Tag tag;
    public Polygon_i32 _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Slice21_Body_i32 {
    public Tag tag;
    public OwnedSlice_i32 _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Slice22_Body_i32 {
    public Tag tag;
    public OwnedSlice_i32 _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Slice23_Body_i32 {
    public Tag tag;
    public FillRule fill;
    public OwnedSlice_i32 coords;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Slice24_Body_i32 {
    public Tag tag;
    public FillRule fill;
    public OwnedSlice_i32 coords;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public Polygon21_Body_i32 polygon21;
  [FieldOffset(0)]
  public Slice21_Body_i32 slice21;
  [FieldOffset(0)]
  public Slice22_Body_i32 slice22;
  [FieldOffset(0)]
  public Slice23_Body_i32 slice23;
  [FieldOffset(0)]
  public Slice24_Body_i32 slice24;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Taz {
  public enum Tag : byte {
    Bar3,
    Taz1,
    Taz3,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Taz1_Body {
    public Tag tag;
    public int _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Taz3_Body {
    public Tag tag;
    public OwnedSlice_i32 _0;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public Taz1_Body taz1;
  [FieldOffset(0)]
  public Taz3_Body taz3;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Tazz {
  public enum Tag : byte {
    Bar4,
    Taz2,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Taz2_Body {
    public Tag tag;
    public int _0;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public Taz2_Body taz2;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Tazzz {
  public enum Tag : byte {
    Bar5,
    Taz5,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Taz5_Body {
    public Tag tag;
    public int _0;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public Taz5_Body taz5;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Tazzzz {
  public enum Tag : byte {
    Taz6,
    Taz7,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Taz6_Body {
    public Tag tag;
    public int _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Taz7_Body {
    public Tag tag;
    public uint _0;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public Taz6_Body taz6;
  [FieldOffset(0)]
  public Taz7_Body taz7;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Qux {
  public enum Tag : byte {
    Qux1,
    Qux2,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Qux1_Body {
    public Tag tag;
    public int _0;

    bool operator==(const Qux1_Body& other) const {
      return _0 == other._0;
    }
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Qux2_Body {
    public Tag tag;
    public uint _0;

    bool operator==(const Qux2_Body& other) const {
      return _0 == other._0;
    }
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public Qux1_Body qux1;
  [FieldOffset(0)]
  public Qux2_Body qux2;
}
