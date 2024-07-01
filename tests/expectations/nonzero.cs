#if 0
''' '
#endif

#ifdef __cplusplus
struct NonZeroI64;
#endif

#if 0
' '''
#endif


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct Option_i64 {

}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct NonZeroAliases {
  public byte a;
  public ushort b;
  public uint c;
  public ulong d;
  public sbyte e;
  public short f;
  public int g;
  public long h;
  public long i;
  public Option_i64* j;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct NonZeroGenerics {
  public byte a;
  public ushort b;
  public uint c;
  public ulong d;
  public sbyte e;
  public short f;
  public int g;
  public long h;
  public long i;
  public Option_i64* j;
}
