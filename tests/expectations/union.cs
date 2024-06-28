using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct Opaque {

}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Normal {
  [FieldOffset(0)]
  public int x;
  [FieldOffset(0)]
  public float y;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct NormalWithZST {
  [FieldOffset(0)]
  public int x;
  [FieldOffset(0)]
  public float y;
}
