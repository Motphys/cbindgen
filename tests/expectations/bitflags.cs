using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/// Constants shared by multiple CSS Box Alignment properties
///
/// These constants match Gecko's `NS_STYLE_ALIGN_*` constants.
[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct AlignFlags {
  public byte bits;

  constexpr explicit operator bool() const {
    return !!bits;
  }
  constexpr AlignFlags operator~() const {
    return AlignFlags { static_cast<decltype(bits)>(~bits) };
  }
  constexpr AlignFlags operator|(const AlignFlags& other) const {
    return AlignFlags { static_cast<decltype(bits)>(this->bits | other.bits) };
  }
  AlignFlags& operator|=(const AlignFlags& other) {
    *this = (*this | other);
    return *this;
  }
  constexpr AlignFlags operator&(const AlignFlags& other) const {
    return AlignFlags { static_cast<decltype(bits)>(this->bits & other.bits) };
  }
  AlignFlags& operator&=(const AlignFlags& other) {
    *this = (*this & other);
    return *this;
  }
  constexpr AlignFlags operator^(const AlignFlags& other) const {
    return AlignFlags { static_cast<decltype(bits)>(this->bits ^ other.bits) };
  }
  AlignFlags& operator^=(const AlignFlags& other) {
    *this = (*this ^ other);
    return *this;
  }
}
/// 'auto'


/// 'normal'


/// 'start'


/// 'end'




/// 'flex-start'







[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct DebugFlags {
  public uint bits;

  constexpr explicit operator bool() const {
    return !!bits;
  }
  constexpr DebugFlags operator~() const {
    return DebugFlags { static_cast<decltype(bits)>(~bits) };
  }
  constexpr DebugFlags operator|(const DebugFlags& other) const {
    return DebugFlags { static_cast<decltype(bits)>(this->bits | other.bits) };
  }
  DebugFlags& operator|=(const DebugFlags& other) {
    *this = (*this | other);
    return *this;
  }
  constexpr DebugFlags operator&(const DebugFlags& other) const {
    return DebugFlags { static_cast<decltype(bits)>(this->bits & other.bits) };
  }
  DebugFlags& operator&=(const DebugFlags& other) {
    *this = (*this & other);
    return *this;
  }
  constexpr DebugFlags operator^(const DebugFlags& other) const {
    return DebugFlags { static_cast<decltype(bits)>(this->bits ^ other.bits) };
  }
  DebugFlags& operator^=(const DebugFlags& other) {
    *this = (*this ^ other);
    return *this;
  }
}
/// Flag with the topmost bit set of the u32



[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct LargeFlags {
  public ulong bits;

  constexpr explicit operator bool() const {
    return !!bits;
  }
  constexpr LargeFlags operator~() const {
    return LargeFlags { static_cast<decltype(bits)>(~bits) };
  }
  constexpr LargeFlags operator|(const LargeFlags& other) const {
    return LargeFlags { static_cast<decltype(bits)>(this->bits | other.bits) };
  }
  LargeFlags& operator|=(const LargeFlags& other) {
    *this = (*this | other);
    return *this;
  }
  constexpr LargeFlags operator&(const LargeFlags& other) const {
    return LargeFlags { static_cast<decltype(bits)>(this->bits & other.bits) };
  }
  LargeFlags& operator&=(const LargeFlags& other) {
    *this = (*this & other);
    return *this;
  }
  constexpr LargeFlags operator^(const LargeFlags& other) const {
    return LargeFlags { static_cast<decltype(bits)>(this->bits ^ other.bits) };
  }
  LargeFlags& operator^=(const LargeFlags& other) {
    *this = (*this ^ other);
    return *this;
  }
}
/// Flag with a very large shift that usually would be narrowed.





[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct OutOfLine {
  public uint _0;

  constexpr explicit operator bool() const {
    return !!_0;
  }
  constexpr OutOfLine operator~() const {
    return OutOfLine { static_cast<decltype(_0)>(~_0) };
  }
  constexpr OutOfLine operator|(const OutOfLine& other) const {
    return OutOfLine { static_cast<decltype(_0)>(this->_0 | other._0) };
  }
  OutOfLine& operator|=(const OutOfLine& other) {
    *this = (*this | other);
    return *this;
  }
  constexpr OutOfLine operator&(const OutOfLine& other) const {
    return OutOfLine { static_cast<decltype(_0)>(this->_0 & other._0) };
  }
  OutOfLine& operator&=(const OutOfLine& other) {
    *this = (*this & other);
    return *this;
  }
  constexpr OutOfLine operator^(const OutOfLine& other) const {
    return OutOfLine { static_cast<decltype(_0)>(this->_0 ^ other._0) };
  }
  OutOfLine& operator^=(const OutOfLine& other) {
    *this = (*this ^ other);
    return *this;
  }
}






