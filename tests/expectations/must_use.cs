#define MUST_USE_FUNC __attribute__((warn_unused_result))
#define MUST_USE_STRUCT __attribute__((warn_unused))
#define MUST_USE_ENUM /* nothing */


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct MaybeOwnedPtr_i32 {
  public enum MUST_USE_ENUM Tag : byte {
    Owned_i32,
    None_i32,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Owned_Body_i32 {
    public int* _0;
  }

  public Tag tag;

  [StructLayout(LayoutKind.Explicit)]
  public unsafe partial struct Variants {
    [FieldOffset(0)]
    public Owned_Body_i32 owned;
  }

  public Variants variants;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct MUST_USE_STRUCT OwnedPtr_i32 {
  public int* ptr;
}
