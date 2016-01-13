public class DiscoveryDocument
{

	// Constructors
	public DiscoveryDocument() {}

	// Methods
	public static DiscoveryDocument Read(System.IO.Stream stream) {}
	public static DiscoveryDocument Read(System.IO.TextReader reader) {}
	public static DiscoveryDocument Read(System.Xml.XmlReader xmlReader) {}
	public static bool CanRead(System.Xml.XmlReader xmlReader) {}
	public void Write(System.IO.TextWriter writer) {}
	public void Write(System.IO.Stream stream) {}
	public void Write(System.Xml.XmlWriter writer) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string Namespace;

	// Properties
	public System.Collections.IList References { get{} }
}

