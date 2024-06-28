using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct Opaque {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct Option_____Opaque {

}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo {
  public Opaque* x;
  public Opaque* y;
  public Callback z;
  public Callback* zz;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Bar {
  [FieldOffset(0)]
  public Opaque* x;
  [FieldOffset(0)]
  public Opaque* y;
  [FieldOffset(0)]
  public Callback z;
  [FieldOffset(0)]
  public Callback* zz;
}
