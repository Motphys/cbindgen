using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct A {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct B {

}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct List_A {
  public A* members;
  public nuint count;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct List_B {
  public B* members;
  public nuint count;
}
