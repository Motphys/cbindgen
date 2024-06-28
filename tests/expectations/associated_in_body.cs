using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/// Constants shared by multiple CSS Box Alignment properties
///
/// These constants match Gecko's `NS_STYLE_ALIGN_*` constants.
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct StyleAlignFlags {
  public byte bits;

  constexpr explicit operator bool() const {
    return !!bits;
  }
  constexpr StyleAlignFlags operator~() const {
    return StyleAlignFlags { static_cast<decltype(bits)>(~bits) };
  }
  constexpr StyleAlignFlags operator|(const StyleAlignFlags& other) const {
    return StyleAlignFlags { static_cast<decltype(bits)>(this->bits | other.bits) };
  }
  StyleAlignFlags& operator|=(const StyleAlignFlags& other) {
    *this = (*this | other);
    return *this;
  }
  constexpr StyleAlignFlags operator&(const StyleAlignFlags& other) const {
    return StyleAlignFlags { static_cast<decltype(bits)>(this->bits & other.bits) };
  }
  StyleAlignFlags& operator&=(const StyleAlignFlags& other) {
    *this = (*this & other);
    return *this;
  }
  constexpr StyleAlignFlags operator^(const StyleAlignFlags& other) const {
    return StyleAlignFlags { static_cast<decltype(bits)>(this->bits ^ other.bits) };
  }
  StyleAlignFlags& operator^=(const StyleAlignFlags& other) {
    *this = (*this ^ other);
    return *this;
  }
}
/// 'auto'


/// 'normal'


/// 'start'


/// 'end'




/// 'flex-start'







/// An arbitrary identifier for a native (OS compositor) surface
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct StyleNativeSurfaceId {
  public ulong _0;
}
/// A special id for the native surface that is used for debug / profiler overlays.



[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct StyleNativeTileId {
  public StyleNativeSurfaceId surface_id;
  public int x;
  public int y;
}
/// A special id for the native surface that is used for debug / profiler overlays.


