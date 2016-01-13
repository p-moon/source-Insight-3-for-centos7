public class XmlDocumentSchema : IDataSourceSchema
{

	// Constructors
	public XmlDocumentSchema(System.Xml.XmlDocument xmlDocument, string xPath) {}

	// Methods
	public virtual IDataSourceViewSchema[] GetViews() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

