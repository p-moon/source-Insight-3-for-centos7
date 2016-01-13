public class PaintValueEventArgs : System.EventArgs
{

	// Constructors
	public PaintValueEventArgs(System.ComponentModel.ITypeDescriptorContext context, object value, System.Drawing.Graphics graphics, System.Drawing.Rectangle bounds) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Rectangle Bounds { get{} }
	public System.ComponentModel.ITypeDescriptorContext Context { get{} }
	public System.Drawing.Graphics Graphics { get{} }
	public object Value { get{} }
}

