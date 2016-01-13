public class LinkArea : System.ValueType
{

	// Constructors
	public LinkArea(int start, int length) {}

	// Methods
	public virtual bool Equals(object o) {}
	public virtual string ToString() {}
	public static bool op_Equality(LinkArea linkArea1, LinkArea linkArea2) {}
	public static bool op_Inequality(LinkArea linkArea1, LinkArea linkArea2) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public int Start { get{} set{} }
	public int Length { get{} set{} }
	public bool IsEmpty { get{} }
}

