public class BufferedGraphicsContext : System.IDisposable
{

	// Constructors
	public BufferedGraphicsContext() {}

	// Methods
	public BufferedGraphics Allocate(Graphics targetGraphics, Rectangle targetRectangle) {}
	public BufferedGraphics Allocate(System.IntPtr targetDC, Rectangle targetRectangle) {}
	public virtual void Dispose() {}
	public void Invalidate() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Size MaximumBuffer { get{} set{} }
}

