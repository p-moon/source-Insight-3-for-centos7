public class SystemFonts
{

	// Methods
	public static Font GetFontByName(string systemFontName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Font CaptionFont { get{} }
	public Font SmallCaptionFont { get{} }
	public Font MenuFont { get{} }
	public Font StatusFont { get{} }
	public Font MessageBoxFont { get{} }
	public Font IconTitleFont { get{} }
	public Font DefaultFont { get{} }
	public Font DialogFont { get{} }
}

