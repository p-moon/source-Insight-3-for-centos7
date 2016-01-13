public class Margins : System.ICloneable
{

	// Constructors
	public Margins() {}
	public Margins(int left, int right, int top, int bottom) {}

	// Methods
	public virtual object Clone() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public static bool op_Equality(Margins m1, Margins m2) {}
	public static bool op_Inequality(Margins m1, Margins m2) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public int Left { get{} set{} }
	public int Right { get{} set{} }
	public int Top { get{} set{} }
	public int Bottom { get{} set{} }
}

