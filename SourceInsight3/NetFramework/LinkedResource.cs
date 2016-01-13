public class LinkedResource : AttachmentBase, System.IDisposable
{

	// Constructors
	public LinkedResource(string fileName) {}
	public LinkedResource(string fileName, string mediaType) {}
	public LinkedResource(string fileName, System.Net.Mime.ContentType contentType) {}
	public LinkedResource(System.IO.Stream contentStream) {}
	public LinkedResource(System.IO.Stream contentStream, string mediaType) {}
	public LinkedResource(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) {}

	// Methods
	public static LinkedResource CreateLinkedResourceFromString(string content) {}
	public static LinkedResource CreateLinkedResourceFromString(string content, System.Text.Encoding contentEncoding, string mediaType) {}
	public static LinkedResource CreateLinkedResourceFromString(string content, System.Net.Mime.ContentType contentType) {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Uri ContentLink { get{} set{} }
	public System.IO.Stream ContentStream { get{} }
	public string ContentId { get{} set{} }
	public System.Net.Mime.ContentType ContentType { get{} set{} }
	public System.Net.Mime.TransferEncoding TransferEncoding { get{} set{} }
}

