using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Rect {
  public float x;
  public float y;
  public float w;
  public float h;
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct Color {
  public byte r;
  public byte g;
  public byte b;
  public byte a;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe partial struct DisplayItem {
  public enum Tag : byte {
    Fill,
    Image,
    ClearScreen,
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Fill_Body {
    public Tag tag;
    public Rect _0;
    public Color _1;
  }

  [StructLayout(LayoutKind.Sequential)]
  public unsafe partial struct Image_Body {
    public Tag tag;
    public uint id;
    public Rect bounds;
  }

  [FieldOffset(0)]
  public Tag tag;

  [FieldOffset(0)]
  public Fill_Body fill;
  [FieldOffset(0)]
  public Image_Body image;
}
