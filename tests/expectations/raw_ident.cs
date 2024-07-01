using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public enum Enum : byte {
  a,
  b,
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Struct {
  public Enum field;
}
