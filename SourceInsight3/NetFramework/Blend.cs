public class Blend
{

	// Constructors
	public Blend() {}
	public Blend(int count) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public float[] Factors { get{} set{} }
	public float[] Positions { get{} set{} }
}

