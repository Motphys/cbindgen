using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct ABC {
  public float a;
  public uint b;
  public uint c;
}







[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct BAC {
  public uint b;
  public float a;
  public int c;
}






