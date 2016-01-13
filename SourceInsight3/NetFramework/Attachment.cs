public class Attachment : AttachmentBase, System.IDisposable
{

	// Constructors
	public Attachment(string fileName) {}
	public Attachment(string fileName, string mediaType) {}
	public Attachment(string fileName, System.Net.Mime.ContentType contentType) {}
	public Attachment(System.IO.Stream contentStream, string name) {}
	public Attachment(System.IO.Stream contentStream, string name, string mediaType) {}
	public Attachment(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) {}

	// Methods
	public static Attachment CreateAttachmentFromString(string content, string name) {}
	public static Attachment CreateAttachmentFromString(string content, string name, System.Text.Encoding contentEncoding, string mediaType) {}
	public static Attachment CreateAttachmentFromString(string content, System.Net.Mime.ContentType contentType) {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} set{} }
	public System.Text.Encoding NameEncoding { get{} set{} }
	public System.Net.Mime.ContentDisposition ContentDisposition { get{} }
	public System.IO.Stream ContentStream { get{} }
	public string ContentId { get{} set{} }
	public System.Net.Mime.ContentType ContentType { get{} set{} }
	public System.Net.Mime.TransferEncoding TransferEncoding { get{} set{} }
}

