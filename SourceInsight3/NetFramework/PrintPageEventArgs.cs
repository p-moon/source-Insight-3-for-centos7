public class PrintPageEventArgs : System.EventArgs
{

	// Constructors
	public PrintPageEventArgs(System.Drawing.Graphics graphics, System.Drawing.Rectangle marginBounds, System.Drawing.Rectangle pageBounds, PageSettings pageSettings) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Cancel { get{} set{} }
	public System.Drawing.Graphics Graphics { get{} }
	public bool HasMorePages { get{} set{} }
	public System.Drawing.Rectangle MarginBounds { get{} }
	public System.Drawing.Rectangle PageBounds { get{} }
	public PageSettings PageSettings { get{} }
}

