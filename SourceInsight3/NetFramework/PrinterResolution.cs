public class PrinterResolution
{

	// Constructors
	public PrinterResolution() {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PrinterResolutionKind Kind { get{} set{} }
	public int X { get{} set{} }
	public int Y { get{} set{} }
}

