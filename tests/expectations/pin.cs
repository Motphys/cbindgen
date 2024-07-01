#if 0
''' '
#endif

#ifdef __cplusplus
template <typename T>
using Pin = T;
template <typename T>
using Box = T*;
#endif

#if 0
' '''
#endif


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct PinTest {
  public int* pinned_box;
  public int* pinned_ref;
}
