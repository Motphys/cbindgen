#if 0
DEF DEFINED = 1
DEF NOT_DEFINED = 0
#endif


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if defined(NOT_DEFINED)


#endif

#if defined(DEFINED)


#endif

#if (defined(NOT_DEFINED) || defined(DEFINED))
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo {
  public int x;
}
#endif

#if defined(NOT_DEFINED)
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Bar {
  public Foo y;
}
#endif

#if defined(DEFINED)
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Bar {
  public Foo z;
}
#endif

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Root {
  public Bar w;
}
