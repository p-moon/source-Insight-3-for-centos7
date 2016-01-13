public class SoapExtensionImporter
{

	// Methods
	public abstract virtual void ImportMethod(System.CodeDom.CodeAttributeDeclarationCollection metadata) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SoapProtocolImporter ImportContext { get{} set{} }
}

