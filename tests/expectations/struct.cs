using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct Opaque {

}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Normal {
  public int x;
  public float y;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct NormalWithZST {
  public int x;
  public float y;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct TupleRenamed {
  public int m0;
  public float m1;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct TupleNamed {
  public int x;
  public float y;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct WithBool {
  public int x;
  public float y;
  [MarshalAs(UnmanagedType.U1)]
  public bool z;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct TupleWithBool {
  public int _0;
  public float _1;
  [MarshalAs(UnmanagedType.U1)]
  public bool _2;
}
