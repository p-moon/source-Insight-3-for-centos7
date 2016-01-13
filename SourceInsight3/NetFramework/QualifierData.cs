public class QualifierData
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public object Value { get{} set{} }
	public bool IsAmended { get{} set{} }
	public bool IsLocal { get{} }
	public bool PropagatesToInstance { get{} set{} }
	public bool PropagatesToSubclass { get{} set{} }
	public bool IsOverridable { get{} set{} }
}

