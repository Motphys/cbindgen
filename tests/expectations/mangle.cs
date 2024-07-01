using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public enum Bar {
  BarSome,
  BarThing,
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct FooU8 {
  public byte a;
}


