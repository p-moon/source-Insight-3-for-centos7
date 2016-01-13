public class TypeLib
{

	// Constructors
	public TypeLib() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Flags { get{} }
	public string HelpDirectory { get{} }
	public string ResourceId { get{} }
	public string TlbId { get{} }
	public string Version { get{} }
	public string XmlFlags { get{} set{} }
	public string XmlHelpDirectory { get{} set{} }
	public string XmlResourceId { get{} set{} }
	public string XmlTlbId { get{} set{} }
	public string XmlVersion { get{} set{} }
}

