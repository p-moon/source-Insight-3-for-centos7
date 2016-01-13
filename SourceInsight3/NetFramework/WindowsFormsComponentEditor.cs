public class WindowsFormsComponentEditor : System.ComponentModel.ComponentEditor
{

	// Methods
	public virtual bool EditComponent(System.ComponentModel.ITypeDescriptorContext context, object component) {}
	public bool EditComponent(object component, System.Windows.Forms.IWin32Window owner) {}
	public virtual bool EditComponent(System.ComponentModel.ITypeDescriptorContext context, object component, System.Windows.Forms.IWin32Window owner) {}
	public bool EditComponent(object component) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

