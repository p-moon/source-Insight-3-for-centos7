public class MenuCommand
{

	// Constructors
	public MenuCommand(System.EventHandler handler, CommandID command) {}

	// Methods
	public virtual void Invoke() {}
	public virtual void Invoke(object arg) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
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

