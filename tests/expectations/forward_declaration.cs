#if 0
''' '
#endif
#if defined(CBINDGEN_STYLE_TYPE)
/* ANONYMOUS STRUCTS DO NOT SUPPORT FORWARD DECLARATIONS!
#endif
#if 0
' '''
#endif


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct StructInfo {
  public TypeInfo** fields;
  public nuint num_fields;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct TypeData {
  public enum Tag {
    Primitive,
    Struct,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Struct_Body {
    public StructInfo _0;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public Struct_Body struct_;
  }

  public Variants variants;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct TypeInfo {
  public TypeData data;
}

#if 0
''' '
#endif
#if defined(CBINDGEN_STYLE_TYPE)
*/
#endif
#if 0
' '''
#endif
