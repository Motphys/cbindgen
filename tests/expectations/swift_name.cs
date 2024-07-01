#define CF_SWIFT_NAME(_name) __attribute__((swift_name(#_name)))

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct Opaque {

}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct SelfTypeTestStruct {
  public byte times;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct PointerToOpaque {
  public Opaque* ptr;
}
