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

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo_i32 {
  public int* data;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo_f32 {
  public float* data;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Foo_Bar_f32 {
  public Bar_f32* data;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Tuple_Foo_f32_____f32 {
  public Foo_f32* a;
  public float* b;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Tuple_f32__f32 {
  public float* a;
  public float* b;
}


