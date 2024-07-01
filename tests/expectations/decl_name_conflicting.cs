using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public enum BindingType : uint {
  Buffer = 0,
  NotBuffer = 1,
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct BindGroupLayoutEntry {
  public BindingType ty;
}
