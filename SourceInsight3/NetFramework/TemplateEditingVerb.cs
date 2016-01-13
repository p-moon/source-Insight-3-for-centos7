public class TemplateEditingVerb : System.ComponentModel.Design.DesignerVerb, System.IDisposable
{

	// Constructors
	public TemplateEditingVerb(string text, int index, TemplatedControlDesigner designer) {}
	public TemplateEditingVerb(string text, int index) {}

	// Methods
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual void Invoke() {}
	public virtual void Invoke(object arg) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Index { get{} }
	public string Description { get{} set{} }
	public string Text { get{} }
	public bool Checked { get{} set{} }
	public bool Enabled { get{} set{} }
	public System.Collections.IDictionary Properties { get{} }
	public bool Supported { get{} set{} }
	public bool Visible { get{} set{} }
	public System.ComponentModel.Design.CommandID CommandID { get{} }
	public int OleStatus { get{} }

	// Events
	public event System.EventHandler CommandChanged;
}

