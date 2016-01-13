public class PaperSize
{

	// Constructors
	public PaperSize() {}
	public PaperSize(string name, int width, int height) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Height { get{} set{} }
	public PaperKind Kind { get{} }
	public string PaperName { get{} set{} }
	public int RawKind { get{} set{} }
	public int Width { get{} set{} }
}

