public class AxComponentEditor : System.Windows.Forms.Design.WindowsFormsComponentEditor
{

	// Constructors
	public AxComponentEditor() {}

	// Methods
	public virtual bool EditComponent(System.ComponentModel.ITypeDescriptorContext context, object obj, IWin32Window parent) {}
	public virtual bool EditComponent(System.ComponentModel.ITypeDescriptorContext context, object component) {}
	public bool EditComponent(object component, IWin32Window owner) {}
	public bool EditComponent(object component) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

