public class DesignerCommandSet
{

	// Constructors
	public DesignerCommandSet() {}

	// Methods
	public virtual System.Collections.ICollection GetCommands(string name) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DesignerVerbCollection Verbs { get{} }
	public DesignerActionListCollection ActionLists { get{} }
}

