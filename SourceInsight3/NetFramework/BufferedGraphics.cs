public class BufferedGraphics : System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public void Render() {}
	public void Render(Graphics target) {}
	public void Render(System.IntPtr targetDC) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Graphics Graphics { get{} }
}

