public class DesignTimeParseData
{

	// Constructors
	public DesignTimeParseData(System.ComponentModel.Design.IDesignerHost designerHost, string parseText) {}
	public DesignTimeParseData(System.ComponentModel.Design.IDesignerHost designerHost, string parseText, string filter) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool ShouldApplyTheme { get{} set{} }
	public System.EventHandler DataBindingHandler { get{} set{} }
	public System.ComponentModel.Design.IDesignerHost DesignerHost { get{} }
	public string DocumentUrl { get{} set{} }
	public string Filter { get{} }
	public string ParseText { get{} }
	public System.Collections.ICollection UserControlRegisterEntries { get{} }
}

