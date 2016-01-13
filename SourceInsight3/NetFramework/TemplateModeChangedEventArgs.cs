public class TemplateModeChangedEventArgs : System.EventArgs
{

	// Constructors
	public TemplateModeChangedEventArgs(TemplateGroup newTemplateGroup) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TemplateGroup NewTemplateGroup { get{} }
}

