#if 0
DEF DEFINE_FREEBSD = 0
#endif


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo {
  public int x;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct RenamedTy {
  public ulong y;
}

#if !defined(DEFINE_FREEBSD)
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct NoExternTy {
  public byte field;
}
#endif

#if !defined(DEFINE_FREEBSD)
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct ContainsNoExternTy {
  public NoExternTy field;
}
#endif

#if defined(DEFINE_FREEBSD)
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct ContainsNoExternTy {
  public ulong field;
}
#endif
