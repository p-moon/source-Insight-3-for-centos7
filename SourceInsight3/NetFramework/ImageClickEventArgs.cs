public class ImageClickEventArgs : System.EventArgs
{

	// Constructors
	public ImageClickEventArgs(int x, int y) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int X;
	public int Y;
}

