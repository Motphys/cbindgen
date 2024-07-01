using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct HasBitfields {
  public ulong: 8 foo;
  public ulong: 56 bar;
}
