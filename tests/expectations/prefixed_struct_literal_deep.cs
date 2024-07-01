using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct PREFIXBar {
  public int a;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct PREFIXFoo {
  public int a;
  public uint b;
  public PREFIXBar bar;
}



