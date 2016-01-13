public class PaintEventArgs : System.EventArgs, System.IDisposable
{

	// Constructors
	public PaintEventArgs(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipRect) {}

	// Methods
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Rectangle ClipRectangle { get{} }
	public System.Drawing.Graphics Graphics { get{} }
}

