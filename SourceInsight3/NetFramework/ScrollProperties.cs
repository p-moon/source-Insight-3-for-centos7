public class ScrollProperties
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Enabled { get{} set{} }
	public int LargeChange { get{} set{} }
	public int Maximum { get{} set{} }
	public int Minimum { get{} set{} }
	public int SmallChange { get{} set{} }
	public int Value { get{} set{} }
	public bool Visible { get{} set{} }
}

