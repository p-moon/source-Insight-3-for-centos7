public class MQCOLUMNSET
{

	// Constructors
	public MQCOLUMNSET() {}

	// Methods
	public virtual void SetId(int columnId, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int columnCount;
	public System.IntPtr columnIdentifiers;
}

