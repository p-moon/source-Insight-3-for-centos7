public class AttachmentBase : System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.IO.Stream ContentStream { get{} }
	public string ContentId { get{} set{} }
	public System.Net.Mime.ContentType ContentType { get{} set{} }
	public System.Net.Mime.TransferEncoding TransferEncoding { get{} set{} }
}

