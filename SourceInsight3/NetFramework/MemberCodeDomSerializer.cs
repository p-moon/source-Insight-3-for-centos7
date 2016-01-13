public class MemberCodeDomSerializer : CodeDomSerializerBase
{

	// Methods
	public abstract virtual void Serialize(IDesignerSerializationManager manager, object value, System.ComponentModel.MemberDescriptor descriptor, System.CodeDom.CodeStatementCollection statements) {}
	public abstract virtual bool ShouldSerialize(IDesignerSerializationManager manager, object value, System.ComponentModel.MemberDescriptor descriptor) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

