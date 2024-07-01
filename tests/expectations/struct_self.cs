using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo_Bar {
  public int* something;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Bar {
  public int something;
  public Foo_Bar subexpressions;
}
