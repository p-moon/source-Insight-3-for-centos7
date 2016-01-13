public class XmlFormatExtensionAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlFormatExtensionAttribute() {}
	public XmlFormatExtensionAttribute(string elementName, string ns, Type extensionPoint1) {}
	public XmlFormatExtensionAttribute(string elementName, string ns, Type extensionPoint1, Type extensionPoint2) {}
	public XmlFormatExtensionAttribute(string elementName, string ns, Type extensionPoint1, Type extensionPoint2, Type extensionPoint3) {}
	public XmlFormatExtensionAttribute(string elementName, string ns, Type extensionPoint1, Type extensionPoint2, Type extensionPoint3, Type extensionPoint4) {}
	public XmlFormatExtensionAttribute(string elementName, string ns, Type[] extensionPoints) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type[] ExtensionPoints { get{} set{} }
	public string Namespace { get{} set{} }
	public string ElementName { get{} set{} }
	public object TypeId { get{} }
}

