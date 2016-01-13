public class WindowsFormsDesignerOptionService : System.ComponentModel.Design.DesignerOptionService, System.ComponentModel.Design.IDesignerOptionService
{

	// Constructors
	public WindowsFormsDesignerOptionService() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DesignerOptions CompatibilityOptions { get{} }
	public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection Options { get{} }
}

