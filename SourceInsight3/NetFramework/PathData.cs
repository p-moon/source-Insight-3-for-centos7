public class PathData
{

	// Constructors
	public PathData() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.PointF[] Points { get{} set{} }
	public byte[] Types { get{} set{} }
}

