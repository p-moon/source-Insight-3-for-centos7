public class ObjectListCommand
{

	// Constructors
	public ObjectListCommand() {}
	public ObjectListCommand(string name, string text) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} set{} }
	public string Text { get{} set{} }
}

