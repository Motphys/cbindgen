using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#ifndef NO_RETURN_ATTR
  #ifdef __GNUC__
    #define NO_RETURN_ATTR __attribute__ ((noreturn))
  #else // __GNUC__
    #define NO_RETURN_ATTR
  #endif // __GNUC__
#endif // NO_RETURN_ATTR


[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Example {
  public Callback f;
}
