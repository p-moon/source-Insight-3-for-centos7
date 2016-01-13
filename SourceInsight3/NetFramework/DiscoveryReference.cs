public class DiscoveryReference
{

	// Methods
	public abstract virtual void WriteDocument(object document, System.IO.Stream stream) {}
	public abstract virtual object ReadDocument(System.IO.Stream stream) {}
	public static string FilenameFromUrl(string url) {}
	public void Resolve() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DiscoveryClientProtocol ClientProtocol { get{} set{} }
	public string DefaultFilename { get{} }
	public string Url { get{} set{} }
}

