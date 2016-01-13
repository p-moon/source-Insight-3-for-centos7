public class ColumnStyle : TableLayoutStyle
{

	// Constructors
	public ColumnStyle(SizeType sizeType, float width) {}
	public ColumnStyle() {}
	public ColumnStyle(SizeType sizeType) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public float Width { get{} set{} }
	public SizeType SizeType { get{} set{} }
}

