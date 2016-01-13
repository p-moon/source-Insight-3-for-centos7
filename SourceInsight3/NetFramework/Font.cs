public class Font : System.MarshalByRefObject, System.ICloneable, System.Runtime.Serialization.ISerializable, System.IDisposable
{

	// Constructors
	public Font(FontFamily family, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet, bool gdiVerticalFont) {}
	public Font(Font prototype, FontStyle newStyle) {}
	public Font(FontFamily family, float emSize, FontStyle style, GraphicsUnit unit) {}
	public Font(FontFamily family, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet) {}
	public Font(string familyName, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet) {}
	public Font(string familyName, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet, bool gdiVerticalFont) {}
	public Font(FontFamily family, float emSize, FontStyle style) {}
	public Font(FontFamily family, float emSize, GraphicsUnit unit) {}
	public Font(FontFamily family, float emSize) {}
	public Font(string familyName, float emSize, FontStyle style, GraphicsUnit unit) {}
	public Font(string familyName, float emSize, FontStyle style) {}
	public Font(string familyName, float emSize, GraphicsUnit unit) {}
	public Font(string familyName, float emSize) {}

	// Methods
	public static Font FromHfont(System.IntPtr hfont) {}
	public static Font FromLogFont(object lf, System.IntPtr hdc) {}
	public void ToLogFont(object logFont, Graphics graphics) {}
	public System.IntPtr ToHfont() {}
	public static Font FromLogFont(object lf) {}
	public static Font FromHdc(System.IntPtr hdc) {}
	public virtual object Clone() {}
	public virtual void Dispose() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public void ToLogFont(object logFont) {}
	public float GetHeight(Graphics graphics) {}
	public float GetHeight() {}
	public float GetHeight(float dpi) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}

	// Properties
	public FontFamily FontFamily { get{} }
	public bool Bold { get{} }
	public byte GdiCharSet { get{} }
	public bool GdiVerticalFont { get{} }
	public bool Italic { get{} }
	public string Name { get{} }
	public string OriginalFontName { get{} }
	public bool Strikeout { get{} }
	public bool Underline { get{} }
	public FontStyle Style { get{} }
	public float Size { get{} }
	public float SizeInPoints { get{} }
	public GraphicsUnit Unit { get{} }
	public int Height { get{} }
	public bool IsSystemFont { get{} }
	public string SystemFontName { get{} }
}

