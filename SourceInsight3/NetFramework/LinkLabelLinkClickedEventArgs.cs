public class LinkLabelLinkClickedEventArgs : System.EventArgs
{

	// Constructors
	public LinkLabelLinkClickedEventArgs(Link link) {}
	public LinkLabelLinkClickedEventArgs(Link link, MouseButtons button) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MouseButtons Button { get{} }
	public Link Link { get{} }
}

