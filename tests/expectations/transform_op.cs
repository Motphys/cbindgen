using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct StylePoint_i32 {
  public int x;
  public int y;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct StylePoint_f32 {
  public float x;
  public float y;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct StyleFoo_i32 {
  public enum Tag : byte {
    Foo_i32,
    Bar_i32,
    Baz_i32,
    Bazz_i32,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct StyleFoo_Body_i32 {
    public Tag tag;
    public int x;
    public StylePoint_i32 y;
    public StylePoint_f32 z;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct StyleBar_Body_i32 {
    public Tag tag;
    public int _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct StyleBaz_Body_i32 {
    public Tag tag;
    public StylePoint_i32 _0;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public StyleFoo_Body_i32 foo;
  [FieldOffset(0)]
  public StyleBar_Body_i32 bar;
  [FieldOffset(0)]
  public StyleBaz_Body_i32 baz;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct StyleBar_i32 {
  public enum Tag {
    Bar1_i32,
    Bar2_i32,
    Bar3_i32,
    Bar4_i32,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct StyleBar1_Body_i32 {
    public int x;
    public StylePoint_i32 y;
    public StylePoint_f32 z;
    public Callback u;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct StyleBar2_Body_i32 {
    public int _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct StyleBar3_Body_i32 {
    public StylePoint_i32 _0;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public StyleBar1_Body_i32 bar1;
    [FieldOffset(0)]
    public StyleBar2_Body_i32 bar2;
    [FieldOffset(0)]
    public StyleBar3_Body_i32 bar3;
  }

  public Variants variants;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct StylePoint_u32 {
  public uint x;
  public uint y;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct StyleBar_u32 {
  public enum Tag {
    Bar1_u32,
    Bar2_u32,
    Bar3_u32,
    Bar4_u32,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct StyleBar1_Body_u32 {
    public int x;
    public StylePoint_u32 y;
    public StylePoint_f32 z;
    public Callback u;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct StyleBar2_Body_u32 {
    public uint _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct StyleBar3_Body_u32 {
    public StylePoint_u32 _0;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public StyleBar1_Body_u32 bar1;
    [FieldOffset(0)]
    public StyleBar2_Body_u32 bar2;
    [FieldOffset(0)]
    public StyleBar3_Body_u32 bar3;
  }

  public Variants variants;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct StyleBaz {
  public enum Tag : byte {
    Baz1,
    Baz2,
    Baz3,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct StyleBaz1_Body {
    public Tag tag;
    public StyleBar_u32 _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct StyleBaz2_Body {
    public Tag tag;
    public StylePoint_i32 _0;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public StyleBaz1_Body baz1;
  [FieldOffset(0)]
  public StyleBaz2_Body baz2;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct StyleTaz {
  public enum Tag : byte {
    Taz1,
    Taz2,
    Taz3,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct StyleTaz1_Body {
    public StyleBar_u32 _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct StyleTaz2_Body {
    public StyleBaz _0;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public StyleTaz1_Body taz1;
    [FieldOffset(0)]
    public StyleTaz2_Body taz2;
  }

  public Variants variants;
}
