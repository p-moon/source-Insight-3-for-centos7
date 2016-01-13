public class CommandID
{

	// Constructors
	public CommandID(System.Guid menuGroup, int commandID) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public int ID { get{} }
	public System.Guid Guid { get{} }
}

