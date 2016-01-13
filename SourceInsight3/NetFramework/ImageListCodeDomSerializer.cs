public class ImageListCodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializer
{

	// Constructors
	public ImageListCodeDomSerializer() {}

	// Methods
	public virtual object Deserialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object codeObject) {}
	public virtual object Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) {}
	public virtual string GetTargetComponentName(System.CodeDom.CodeStatement statement, System.CodeDom.CodeExpression expression, Type targetType) {}
	public virtual object SerializeAbsolute(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) {}
	public virtual System.CodeDom.CodeStatementCollection SerializeMember(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object owningObject, System.ComponentModel.MemberDescriptor member) {}
	public virtual System.CodeDom.CodeStatementCollection SerializeMemberAbsolute(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object owningObject, System.ComponentModel.MemberDescriptor member) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

