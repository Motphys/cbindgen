using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct A {
  public int x;
  public float y;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct B {
  public A data;
}
