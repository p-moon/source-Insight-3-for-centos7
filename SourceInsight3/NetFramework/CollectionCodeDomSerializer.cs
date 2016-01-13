public class CollectionCodeDomSerializer : CodeDomSerializer
{

	// Constructors
	public CollectionCodeDomSerializer() {}

	// Methods
	public virtual object Serialize(IDesignerSerializationManager manager, object value) {}
	public virtual string GetTargetComponentName(System.CodeDom.CodeStatement statement, System.CodeDom.CodeExpression expression, Type targetType) {}
	public virtual object Deserialize(IDesignerSerializationManager manager, object codeObject) {}
	public virtual object SerializeAbsolute(IDesignerSerializationManager manager, object value) {}
	public virtual System.CodeDom.CodeStatementCollection SerializeMember(IDesignerSerializationManager manager, object owningObject, System.ComponentModel.MemberDescriptor member) {}
	public virtual System.CodeDom.CodeStatementCollection SerializeMemberAbsolute(IDesignerSerializationManager manager, object owningObject, System.ComponentModel.MemberDescriptor member) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

