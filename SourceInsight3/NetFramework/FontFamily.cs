public class FontFamily : System.MarshalByRefObject, System.IDisposable
{

	// Constructors
	public FontFamily(string name) {}
	public FontFamily(string name, System.Drawing.Text.FontCollection fontCollection) {}
	public FontFamily(System.Drawing.Text.GenericFontFamilies genericFamily) {}

	// Methods
	public int GetEmHeight(FontStyle style) {}
	public int GetLineSpacing(FontStyle style) {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public virtual int GetHashCode() {}
	public virtual void Dispose() {}
	public string GetName(int language) {}
	public static FontFamily[] GetFamilies(Graphics graphics) {}
	public bool IsStyleAvailable(FontStyle style) {}
	public int GetCellAscent(FontStyle style) {}
	public int GetCellDescent(FontStyle style) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}

	// Properties
	public string Name { get{} }
	public FontFamily[] Families { get{} }
	public FontFamily GenericSansSerif { get{} }
	public FontFamily GenericSerif { get{} }
	public FontFamily GenericMonospace { get{} }
}

