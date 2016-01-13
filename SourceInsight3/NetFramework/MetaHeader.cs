public class MetaHeader
{

	// Constructors
	public MetaHeader() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public short Type { get{} set{} }
	public short HeaderSize { get{} set{} }
	public short Version { get{} set{} }
	public int Size { get{} set{} }
	public short NoObjects { get{} set{} }
	public int MaxRecord { get{} set{} }
	public short NoParameters { get{} set{} }
}

