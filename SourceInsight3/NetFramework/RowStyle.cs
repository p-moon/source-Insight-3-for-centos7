public class RowStyle : TableLayoutStyle
{

	// Constructors
	public RowStyle(SizeType sizeType, float height) {}
	public RowStyle() {}
	public RowStyle(SizeType sizeType) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public float Height { get{} set{} }
	public SizeType SizeType { get{} set{} }
}

