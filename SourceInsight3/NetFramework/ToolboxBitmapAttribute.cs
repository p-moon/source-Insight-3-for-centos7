public class ToolboxBitmapAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ToolboxBitmapAttribute(string imageFile) {}
	public ToolboxBitmapAttribute(Type t) {}
	public ToolboxBitmapAttribute(Type t, string name) {}

	// Methods
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public Image GetImage(object component) {}
	public Image GetImage(object component, bool large) {}
	public Image GetImage(Type type) {}
	public Image GetImage(Type type, bool large) {}
	public Image GetImage(Type type, string imgName, bool large) {}
	public static Image GetImageFromResource(Type t, string imageName, bool large) {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public ToolboxBitmapAttribute Default;

	// Properties
	public object TypeId { get{} }
}

