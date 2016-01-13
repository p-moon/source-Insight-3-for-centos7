public class CreateParams
{

	// Constructors
	public CreateParams() {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ClassName { get{} set{} }
	public string Caption { get{} set{} }
	public int Style { get{} set{} }
	public int ExStyle { get{} set{} }
	public int ClassStyle { get{} set{} }
	public int X { get{} set{} }
	public int Y { get{} set{} }
	public int Width { get{} set{} }
	public int Height { get{} set{} }
	public System.IntPtr Parent { get{} set{} }
	public object Param { get{} set{} }
}

