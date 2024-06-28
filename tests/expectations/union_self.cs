using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo_Bar {
  public int* something;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Bar {
  [FieldOffset(0)]
  public int something;
  [FieldOffset(0)]
  public Foo_Bar subexpressions;
}
