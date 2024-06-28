#if 0
''' '
#endif

#ifdef __cplusplus
template <typename T>
using MaybeUninit = T;
#endif

#if 0
' '''
#endif


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct NotReprC______i32 {

}



[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct MyStruct {
  public int* number;
}
