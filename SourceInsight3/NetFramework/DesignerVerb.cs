public class DesignerVerb : MenuCommand
{

	// Constructors
	public DesignerVerb(string text, System.EventHandler handler) {}
	public DesignerVerb(string text, System.EventHandler handler, CommandID startCommandID) {}

	// Methods
	public virtual string ToString() {}
	public virtual void Invoke() {}
	public virtual void Invoke(object arg) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Description { get{} set{} }
	public string Text { get{} }
	public bool Checked { get{} set{} }
	public bool Enabled { get{} set{} }
	public System.Collections.IDictionary Properties { get{} }
	public bool Supported { get{} set{} }
	public bool Visible { get{} set{} }
	public CommandID CommandID { get{} }
	public int OleStatus { get{} }

	// Events
	public event System.EventHandler CommandChanged;
}

