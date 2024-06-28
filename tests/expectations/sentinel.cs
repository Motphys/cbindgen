using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public enum A : byte {
  A_A1,
  A_A2,
  A_A3,
  /// Must be last for serialization purposes
  A_Sentinel,
}

public enum B : byte {
  B_B1,
  B_B2,
  B_B3,
  /// Must be last for serialization purposes
  B_Sentinel,
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct C {
  public enum Tag : byte {
    C_C1,
    C_C2,
    C_C3,
    /// Must be last for serialization purposes
    C_Sentinel,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct C_C1_Body {
    public Tag tag;
    public uint a;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct C_C2_Body {
    public Tag tag;
    public uint b;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public C_C1_Body c1;
  [FieldOffset(0)]
  public C_C2_Body c2;
}
