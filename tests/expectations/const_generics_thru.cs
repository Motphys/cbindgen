using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Inner_1 {
  public byte[] bytes;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Outer_1 {
  public Inner_1 inner;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Inner_2 {
  public byte[] bytes;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Outer_2 {
  public Inner_2 inner;
}
