public class PersonalizationStateInfo
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Path { get{} }
	public System.DateTime LastUpdatedDate { get{} }
	public int Size { get{} }
}

