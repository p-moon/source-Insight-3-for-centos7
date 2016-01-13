public class HtmlElementErrorEventArgs : System.EventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Description { get{} }
	public bool Handled { get{} set{} }
	public int LineNumber { get{} }
	public System.Uri Url { get{} }
}

