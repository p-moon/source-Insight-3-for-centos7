public class DataListComponentEditor : BaseDataListComponentEditor
{

	// Constructors
	public DataListComponentEditor() {}
	public DataListComponentEditor(int initialPage) {}

	// Methods
	public virtual bool EditComponent(System.ComponentModel.ITypeDescriptorContext context, object obj, System.Windows.Forms.IWin32Window parent) {}
	public virtual bool EditComponent(System.ComponentModel.ITypeDescriptorContext context, object component) {}
	public bool EditComponent(object component, System.Windows.Forms.IWin32Window owner) {}
	public bool EditComponent(object component) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

