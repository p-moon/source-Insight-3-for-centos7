public interface ITemplateEditingFrame : System.IDisposable
{

	// Methods
	public abstract virtual void Close(bool saveChanges) {}
	public abstract virtual void Open() {}
	public abstract virtual void Resize(int width, int height) {}
	public abstract virtual void Save() {}
	public abstract virtual void UpdateControlName(string newName) {}

	// Properties
	public System.Web.UI.WebControls.Style ControlStyle { get{} }
	public string Name { get{} }
	public int InitialHeight { get{} set{} }
	public int InitialWidth { get{} set{} }
	public string[] TemplateNames { get{} }
	public System.Web.UI.WebControls.Style[] TemplateStyles { get{} }
	public TemplateEditingVerb Verb { get{} set{} }
}

