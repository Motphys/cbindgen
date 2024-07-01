using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Fns {
  public Callback noArgs;
  public Callback anonymousArg;
  public Callback returnsNumber;
  public Callback namedArgs;
  public Callback namedArgsWildcards;
}
