#if 0
DEF FOO = 0
DEF BAR = 0
#endif


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if defined(FOO)


#endif

#if defined(BAR)


#endif

#if defined(FOO)
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo {

}
#endif

#if defined(BAR)
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Bar {

}
#endif
