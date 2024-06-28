#ifdef __clang__
#define CBINDGEN_NONNULL _Nonnull
#else
#define CBINDGEN_NONNULL
#endif


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct Opaque {

}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct References {
  public Opaque* a;
  public Opaque* b;
  public Opaque* c;
  public Opaque* d;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Pointers_u64 {
  public float* a;
  public ulong* b;
  public Opaque* c;
  public ulong** d;
  public float** e;
  public Opaque** f;
  public ulong* g;
  public int* h;
  public int** i;
  public ulong* j;
  public ulong* k;
}
