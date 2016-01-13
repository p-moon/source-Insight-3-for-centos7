public class TypeCodeDomSerializer : CodeDomSerializerBase
{

	// Constructors
	public TypeCodeDomSerializer() {}

	// Methods
	public virtual object Deserialize(IDesignerSerializationManager manager, System.CodeDom.CodeTypeDeclaration declaration) {}
	public virtual System.CodeDom.CodeTypeDeclaration Serialize(IDesignerSerializationManager manager, object root, System.Collections.ICollection members) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

