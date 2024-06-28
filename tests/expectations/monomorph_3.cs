using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct Bar_Bar_f32 {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct Bar_Foo_f32 {

}

// WARNING: Opaque type, no details available, so only pointers to it are allowed
internal unsafe struct Bar_f32 {

}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Foo_i32 {
  [FieldOffset(0)]
  public int* data;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Foo_f32 {
  [FieldOffset(0)]
  public float* data;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Foo_Bar_f32 {
  [FieldOffset(0)]
  public Bar_f32* data;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Tuple_Foo_f32_____f32 {
  [FieldOffset(0)]
  public Foo_f32* a;
  [FieldOffset(0)]
  public float* b;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct Tuple_f32__f32 {
  [FieldOffset(0)]
  public float* a;
  [FieldOffset(0)]
  public float* b;
}


