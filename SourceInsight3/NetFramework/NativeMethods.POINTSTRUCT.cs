public class POINTSTRUCT : System.ValueType
{

	// Constructors
	public POINTSTRUCT(int x, int y) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int x;
	public int y;
}

