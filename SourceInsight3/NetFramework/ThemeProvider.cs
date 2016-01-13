public class ThemeProvider
{

	// Constructors
	public ThemeProvider(System.ComponentModel.Design.IDesignerHost host, string name, string themeDefinition, string[] cssFiles, string themePath) {}

	// Methods
	public System.Collections.ICollection GetSkinsForControl(Type type) {}
	public SkinBuilder GetSkinBuilder(Control control) {}
	public System.Collections.IDictionary GetSkinControlBuildersForControlType(Type type) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ContentHashCode { get{} }
	public System.Collections.ICollection CssFiles { get{} }
	public System.ComponentModel.Design.IDesignerHost DesignerHost { get{} }
	public string ThemeName { get{} }
}

