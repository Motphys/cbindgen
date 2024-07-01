using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public enum MyCLikeEnum {
  Foo1,
  Bar1,
  Baz1,
}

public enum MyCLikeEnum_Prepended {
  Foo1_Prepended,
  Bar1_Prepended,
  Baz1_Prepended,
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct MyFancyStruct {
  public int i;
#ifdef __cplusplus
    inline void foo();
#endif
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct MyFancyEnum {
  public enum Tag {
    Foo,
    Bar,
    Baz,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Bar_Body {
    public int _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Baz_Body {
    public int _0;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public Bar_Body bar;
    [FieldOffset(0)]
    public Baz_Body baz;
  }

  public Variants variants;
#ifdef __cplusplus
    inline void wohoo();
#endif
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct MyUnion {
  [FieldOffset(0)]
  public float f;
  [FieldOffset(0)]
  public uint u;
  int32_t extra_member;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct MyFancyStruct_Prepended {
#ifdef __cplusplus
    inline void prepended_wohoo();
#endif
  public int i;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct MyFancyEnum_Prepended {
#ifdef __cplusplus
    inline void wohoo();
#endif
  public enum Tag {
    Foo_Prepended,
    Bar_Prepended,
    Baz_Prepended,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Bar_Prepended_Body {
    public int _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Baz_Prepended_Body {
    public int _0;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public Bar_Prepended_Body bar_prepended;
    [FieldOffset(0)]
    public Baz_Prepended_Body baz_prepended;
  }

  public Variants variants;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct MyUnion_Prepended {
    int32_t extra_member;
  [FieldOffset(0)]
  public float f;
  [FieldOffset(0)]
  public uint u;
}
