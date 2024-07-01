#define CBINDGEN_PACKED     __attribute__ ((packed))
#define CBINDGEN_ALIGNED(n) __attribute__ ((aligned(n)))


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct RustAlign4Struct {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct RustAlign4Union {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct RustPackedStruct {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct RustPackedUnion {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct UnsupportedAlign4Enum {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct UnsupportedPacked4Struct {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct UnsupportedPacked4Union {

}

// WARNING: `packed` and `align(N)` is not implemented for C# yet.
// As a result, the size and alignment of this struct could be different from rust.
// Use with caution.[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Align1Struct {
  public nuint arg1;
  public byte* arg2;
}

// WARNING: `packed` and `align(N)` is not implemented for C# yet.
// As a result, the size and alignment of this struct could be different from rust.
// Use with caution.[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Align2Struct {
  public nuint arg1;
  public byte* arg2;
}

// WARNING: `packed` and `align(N)` is not implemented for C# yet.
// As a result, the size and alignment of this struct could be different from rust.
// Use with caution.[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Align4Struct {
  public nuint arg1;
  public byte* arg2;
}

// WARNING: `packed` and `align(N)` is not implemented for C# yet.
// As a result, the size and alignment of this struct could be different from rust.
// Use with caution.[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Align8Struct {
  public nuint arg1;
  public byte* arg2;
}

// WARNING: `packed` and `align(N)` is not implemented for C# yet.
// As a result, the size and alignment of this struct could be different from rust.
// Use with caution.[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Align32Struct {
  public nuint arg1;
  public byte* arg2;
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
internal unsafe partial struct Align1Union {
  [FieldOffset(0)]
  public nuint variant1;
  [FieldOffset(0)]
  public byte* variant2;
}

// WARNING: `packed` and `align(N)` is not implemented for C# yet.
// As a result, the size and alignment of this struct could be different from rust.
// Use with caution.[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Align4Union {
  [FieldOffset(0)]
  public nuint variant1;
  [FieldOffset(0)]
  public byte* variant2;
}

// WARNING: `packed` and `align(N)` is not implemented for C# yet.
// As a result, the size and alignment of this struct could be different from rust.
// Use with caution.[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Align16Union {
  [FieldOffset(0)]
  public nuint variant1;
  [FieldOffset(0)]
  public byte* variant2;
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
