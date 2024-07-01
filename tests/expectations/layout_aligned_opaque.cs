#define CBINDGEN_PACKED        __attribute__ ((packed))
#define CBINDGEN_ALIGNED(n)    __attribute__ ((aligned(n)))


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct OpaqueAlign16Union {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct OpaqueAlign1Struct {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct OpaqueAlign1Union {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct OpaqueAlign2Struct {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct OpaqueAlign32Struct {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct OpaqueAlign4Struct {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct OpaqueAlign4Union {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct OpaqueAlign8Struct {

}

// WARNING: `packed` and `align(N)` is not implemented for C# yet.
// As a result, the size and alignment of this struct could be different from rust.
// Use with caution.[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct PackedStruct {
  public nuint arg1;
  public byte* arg2;
}

// WARNING: `packed` and `align(N)` is not implemented for C# yet.
// As a result, the size and alignment of this struct could be different from rust.
// Use with caution.[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct PackedUnion {
  [FieldOffset(0)]
  public nuint variant1;
  [FieldOffset(0)]
  public byte* variant2;
}
