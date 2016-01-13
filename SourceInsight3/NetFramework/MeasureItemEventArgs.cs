public class MeasureItemEventArgs : System.EventArgs
{

	// Constructors
	public MeasureItemEventArgs(System.Drawing.Graphics graphics, int index, int itemHeight) {}
	public MeasureItemEventArgs(System.Drawing.Graphics graphics, int index) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Graphics Graphics { get{} }
	public int Index { get{} }
	public int ItemHeight { get{} set{} }
	public int ItemWidth { get{} set{} }
}

