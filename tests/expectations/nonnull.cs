using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct Opaque {

}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo_u64 {
  public float* a;
  public ulong* b;
  public Opaque* c;
  public ulong** d;
  public float** e;
  public Opaque** f;
  public ulong* g;
  public int* h;
  public int** i;
}
