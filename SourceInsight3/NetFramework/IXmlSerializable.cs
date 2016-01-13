public interface IXmlSerializable
{

	// Methods
	public abstract virtual System.Xml.Schema.XmlSchema GetSchema() {}
	public abstract virtual void ReadXml(System.Xml.XmlReader reader) {}
	public abstract virtual void WriteXml(System.Xml.XmlWriter writer) {}
}

