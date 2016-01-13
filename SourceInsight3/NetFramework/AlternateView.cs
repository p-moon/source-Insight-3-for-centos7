public class AlternateView : AttachmentBase, System.IDisposable
{

	// Constructors
	public AlternateView(string fileName) {}
	public AlternateView(string fileName, string mediaType) {}
	public AlternateView(string fileName, System.Net.Mime.ContentType contentType) {}
	public AlternateView(System.IO.Stream contentStream) {}
	public AlternateView(System.IO.Stream contentStream, string mediaType) {}
	public AlternateView(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) {}

	// Methods
	public static AlternateView CreateAlternateViewFromString(string content) {}
	public static AlternateView CreateAlternateViewFromString(string content, System.Text.Encoding contentEncoding, string mediaType) {}
	public static AlternateView CreateAlternateViewFromString(string content, System.Net.Mime.ContentType contentType) {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public LinkedResourceCollection LinkedResources { get{} }
	public System.Uri BaseUri { get{} set{} }
	public System.IO.Stream ContentStream { get{} }
	public string ContentId { get{} set{} }
	public System.Net.Mime.ContentType ContentType { get{} set{} }
	public System.Net.Mime.TransferEncoding TransferEncoding { get{} set{} }
}

