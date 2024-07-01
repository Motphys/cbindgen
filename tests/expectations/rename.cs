using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;




public enum C_E : byte {
  x = 0,
  y = 1,
}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct C_A {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct C_C {

}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct C_AwesomeB {
  public int x;
  public float y;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct C_D {
  [FieldOffset(0)]
  public int x;
  [FieldOffset(0)]
  public float y;
}





