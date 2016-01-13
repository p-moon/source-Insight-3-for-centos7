public class BitmapData
{

	// Constructors
	public BitmapData() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Width { get{} set{} }
	public int Height { get{} set{} }
	public int Stride { get{} set{} }
	public PixelFormat PixelFormat { get{} set{} }
	public System.IntPtr Scan0 { get{} set{} }
	public int Reserved { get{} set{} }
}

