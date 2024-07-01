#if 0
''' '
#endif

#ifdef __cplusplus
template <typename T>
using ManuallyDrop = T;
#endif

#if 0
' '''
#endif


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct NotReprC_Point {

}



[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Point {
  public int x;
  public int y;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct MyStruct {
  public Point point;
}
