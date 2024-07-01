using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct A {
  public int namespace_;
  public float float_;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct B {
  public int namespace_;
  public float float_;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct C {
  public enum Tag : byte {
    D,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct D_Body {
    public int namespace_;
    public float float_;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public D_Body d;
  }

  public Variants variants;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct E {
  public enum Tag : byte {
    Double,
    Float,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Double_Body {
    public double _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Float_Body {
    public float _0;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public Double_Body double_;
    [FieldOffset(0)]
    public Float_Body float_;
  }

  public Variants variants;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct F {
  public enum Tag : byte {
    double_,
    float_,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct double_Body {
    public double _0;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct float_Body {
    public float _0;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public double_Body double_;
    [FieldOffset(0)]
    public float_Body float_;
  }

  public Variants variants;
}
