public class XmlAttributes
{

	// Constructors
	public XmlAttributes() {}
	public XmlAttributes(System.Reflection.ICustomAttributeProvider provider) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlElementAttributes XmlElements { get{} }
	public XmlAttributeAttribute XmlAttribute { get{} set{} }
	public XmlEnumAttribute XmlEnum { get{} set{} }
	public XmlTextAttribute XmlText { get{} set{} }
	public XmlArrayAttribute XmlArray { get{} set{} }
	public XmlArrayItemAttributes XmlArrayItems { get{} }
	public object XmlDefaultValue { get{} set{} }
	public bool XmlIgnore { get{} set{} }
	public XmlTypeAttribute XmlType { get{} set{} }
	public XmlRootAttribute XmlRoot { get{} set{} }
	public XmlAnyElementAttributes XmlAnyElements { get{} }
	public XmlAnyAttributeAttribute XmlAnyAttribute { get{} set{} }
	public XmlChoiceIdentifierAttribute XmlChoiceIdentifier { get{} }
	public bool Xmlns { get{} set{} }
}

