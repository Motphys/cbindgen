using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public enum E {
  V,
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct S {
  public byte field;
}











