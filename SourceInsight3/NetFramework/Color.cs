public class Color : System.ValueType
{

	// Methods
	public static Color FromArgb(int alpha, int red, int green, int blue) {}
	public static Color FromArgb(int argb) {}
	public static Color FromArgb(int alpha, Color baseColor) {}
	public static Color FromArgb(int red, int green, int blue) {}
	public static Color FromKnownColor(KnownColor color) {}
	public static Color FromName(string name) {}
	public float GetBrightness() {}
	public float GetHue() {}
	public float GetSaturation() {}
	public int ToArgb() {}
	public KnownColor ToKnownColor() {}
	public virtual string ToString() {}
	public static bool op_Equality(Color left, Color right) {}
	public static bool op_Inequality(Color left, Color right) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Fields
	public Color Empty;

	// Properties
	public Color Transparent { get{} }
	public Color AliceBlue { get{} }
	public Color AntiqueWhite { get{} }
	public Color Aqua { get{} }
	public Color Aquamarine { get{} }
	public Color Azure { get{} }
	public Color Beige { get{} }
	public Color Bisque { get{} }
	public Color Black { get{} }
	public Color BlanchedAlmond { get{} }
	public Color Blue { get{} }
	public Color BlueViolet { get{} }
	public Color Brown { get{} }
	public Color BurlyWood { get{} }
	public Color CadetBlue { get{} }
	public Color Chartreuse { get{} }
	public Color Chocolate { get{} }
	public Color Coral { get{} }
	public Color CornflowerBlue { get{} }
	public Color Cornsilk { get{} }
	public Color Crimson { get{} }
	public Color Cyan { get{} }
	public Color DarkBlue { get{} }
	public Color DarkCyan { get{} }
	public Color DarkGoldenrod { get{} }
	public Color DarkGray { get{} }
	public Color DarkGreen { get{} }
	public Color DarkKhaki { get{} }
	public Color DarkMagenta { get{} }
	public Color DarkOliveGreen { get{} }
	public Color DarkOrange { get{} }
	public Color DarkOrchid { get{} }
	public Color DarkRed { get{} }
	public Color DarkSalmon { get{} }
	public Color DarkSeaGreen { get{} }
	public Color DarkSlateBlue { get{} }
	public Color DarkSlateGray { get{} }
	public Color DarkTurquoise { get{} }
	public Color DarkViolet { get{} }
	public Color DeepPink { get{} }
	public Color DeepSkyBlue { get{} }
	public Color DimGray { get{} }
	public Color DodgerBlue { get{} }
	public Color Firebrick { get{} }
	public Color FloralWhite { get{} }
	public Color ForestGreen { get{} }
	public Color Fuchsia { get{} }
	public Color Gainsboro { get{} }
	public Color GhostWhite { get{} }
	public Color Gold { get{} }
	public Color Goldenrod { get{} }
	public Color Gray { get{} }
	public Color Green { get{} }
	public Color GreenYellow { get{} }
	public Color Honeydew { get{} }
	public Color HotPink { get{} }
	public Color IndianRed { get{} }
	public Color Indigo { get{} }
	public Color Ivory { get{} }
	public Color Khaki { get{} }
	public Color Lavender { get{} }
	public Color LavenderBlush { get{} }
	public Color LawnGreen { get{} }
	public Color LemonChiffon { get{} }
	public Color LightBlue { get{} }
	public Color LightCoral { get{} }
	public Color LightCyan { get{} }
	public Color LightGoldenrodYellow { get{} }
	public Color LightGreen { get{} }
	public Color LightGray { get{} }
	public Color LightPink { get{} }
	public Color LightSalmon { get{} }
	public Color LightSeaGreen { get{} }
	public Color LightSkyBlue { get{} }
	public Color LightSlateGray { get{} }
	public Color LightSteelBlue { get{} }
	public Color LightYellow { get{} }
	public Color Lime { get{} }
	public Color LimeGreen { get{} }
	public Color Linen { get{} }
	public Color Magenta { get{} }
	public Color Maroon { get{} }
	public Color MediumAquamarine { get{} }
	public Color MediumBlue { get{} }
	public Color MediumOrchid { get{} }
	public Color MediumPurple { get{} }
	public Color MediumSeaGreen { get{} }
	public Color MediumSlateBlue { get{} }
	public Color MediumSpringGreen { get{} }
	public Color MediumTurquoise { get{} }
	public Color MediumVioletRed { get{} }
	public Color MidnightBlue { get{} }
	public Color MintCream { get{} }
	public Color MistyRose { get{} }
	public Color Moccasin { get{} }
	public Color NavajoWhite { get{} }
	public Color Navy { get{} }
	public Color OldLace { get{} }
	public Color Olive { get{} }
	public Color OliveDrab { get{} }
	public Color Orange { get{} }
	public Color OrangeRed { get{} }
	public Color Orchid { get{} }
	public Color PaleGoldenrod { get{} }
	public Color PaleGreen { get{} }
	public Color PaleTurquoise { get{} }
	public Color PaleVioletRed { get{} }
	public Color PapayaWhip { get{} }
	public Color PeachPuff { get{} }
	public Color Peru { get{} }
	public Color Pink { get{} }
	public Color Plum { get{} }
	public Color PowderBlue { get{} }
	public Color Purple { get{} }
	public Color Red { get{} }
	public Color RosyBrown { get{} }
	public Color RoyalBlue { get{} }
	public Color SaddleBrown { get{} }
	public Color Salmon { get{} }
	public Color SandyBrown { get{} }
	public Color SeaGreen { get{} }
	public Color SeaShell { get{} }
	public Color Sienna { get{} }
	public Color Silver { get{} }
	public Color SkyBlue { get{} }
	public Color SlateBlue { get{} }
	public Color SlateGray { get{} }
	public Color Snow { get{} }
	public Color SpringGreen { get{} }
	public Color SteelBlue { get{} }
	public Color Tan { get{} }
	public Color Teal { get{} }
	public Color Thistle { get{} }
	public Color Tomato { get{} }
	public Color Turquoise { get{} }
	public Color Violet { get{} }
	public Color Wheat { get{} }
	public Color White { get{} }
	public Color WhiteSmoke { get{} }
	public Color Yellow { get{} }
	public Color YellowGreen { get{} }
	public byte R { get{} }
	public byte G { get{} }
	public byte B { get{} }
	public byte A { get{} }
	public bool IsKnownColor { get{} }
	public bool IsEmpty { get{} }
	public bool IsNamedColor { get{} }
	public bool IsSystemColor { get{} }
	public string Name { get{} }
}

