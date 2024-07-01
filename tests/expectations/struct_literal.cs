using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct Bar {

}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo {
  public int a;
  public uint b;
}












