using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public enum Status : uint {
  Ok,
  Err,
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Dep {
  public int a;
  public float b;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo_i32 {
  public int a;
  public int b;
  public Dep c;
}



[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo_f64 {
  public double a;
  public double b;
  public Dep c;
}






