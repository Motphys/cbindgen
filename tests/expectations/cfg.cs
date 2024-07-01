#if 0
DEF PLATFORM_UNIX = 0
DEF PLATFORM_WIN = 0
DEF X11 = 0
DEF M_32 = 0
#endif


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if (defined(PLATFORM_WIN) || defined(M_32))
public enum BarType : uint {
  A,
  B,
  C,
}
#endif

#if (defined(PLATFORM_UNIX) && defined(X11))
public enum FooType : uint {
  A,
  B,
  C,
}
#endif

#if (defined(PLATFORM_UNIX) && defined(X11))
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct FooHandle {
  public FooType ty;
  public int x;
  public float y;

  bool operator==(const FooHandle& other) const {
    return ty == other.ty &&
           x == other.x &&
           y == other.y;
  }
  bool operator!=(const FooHandle& other) const {
    return ty != other.ty ||
           x != other.x ||
           y != other.y;
  }
}
#endif

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct C {
  public enum Tag : byte {
    C1,
    C2,
#if defined(PLATFORM_WIN)
    C3,
#endif
#if defined(PLATFORM_UNIX)
    C5,
#endif
  }

#if defined(PLATFORM_UNIX)
  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct C5_Body {
    public Tag tag;
    public int int_;

    bool operator==(const C5_Body& other) const {
      return int_ == other.int_;
    }
    bool operator!=(const C5_Body& other) const {
      return int_ != other.int_;
    }
  }
#endif

  [FieldOffset(0)]
  public Tag tag;

#if defined(PLATFORM_UNIX)
  [FieldOffset(0)]
  public C5_Body c5;
#endif
}

#if (defined(PLATFORM_WIN) || defined(M_32))
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct BarHandle {
  public BarType ty;
  public int x;
  public float y;

  bool operator==(const BarHandle& other) const {
    return ty == other.ty &&
           x == other.x &&
           y == other.y;
  }
  bool operator!=(const BarHandle& other) const {
    return ty != other.ty ||
           x != other.x ||
           y != other.y;
  }
}
#endif

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct ConditionalField {
#if defined(X11)
  public int field
#endif
  ;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Normal {
  public int x;
  public float y;

  bool operator==(const Normal& other) const {
    return x == other.x &&
           y == other.y;
  }
  bool operator!=(const Normal& other) const {
    return x != other.x ||
           y != other.y;
  }
}
