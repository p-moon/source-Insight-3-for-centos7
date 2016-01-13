public class ThemeableAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ThemeableAttribute(bool themeable) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public static bool IsObjectThemeable(object instance) {}
	public static bool IsTypeThemeable(Type type) {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public ThemeableAttribute Yes;
	public ThemeableAttribute No;
	public ThemeableAttribute Default;

	// Properties
	public bool Themeable { get{} }
	public object TypeId { get{} }
}

