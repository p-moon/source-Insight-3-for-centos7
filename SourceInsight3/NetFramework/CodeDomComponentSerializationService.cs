public class CodeDomComponentSerializationService : ComponentSerializationService
{

	// Constructors
	public CodeDomComponentSerializationService() {}
	public CodeDomComponentSerializationService(System.IServiceProvider provider) {}

	// Methods
	public virtual SerializationStore CreateStore() {}
	public virtual SerializationStore LoadStore(System.IO.Stream stream) {}
	public virtual void Serialize(SerializationStore store, object value) {}
	public virtual void SerializeAbsolute(SerializationStore store, object value) {}
	public virtual void SerializeMember(SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member) {}
	public virtual void SerializeMemberAbsolute(SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member) {}
	public virtual System.Collections.ICollection Deserialize(SerializationStore store) {}
	public virtual System.Collections.ICollection Deserialize(SerializationStore store, System.ComponentModel.IContainer container) {}
	public virtual void DeserializeTo(SerializationStore store, System.ComponentModel.IContainer container, bool validateRecycledTypes, bool applyDefaults) {}
	public void DeserializeTo(SerializationStore store, System.ComponentModel.IContainer container) {}
	public void DeserializeTo(SerializationStore store, System.ComponentModel.IContainer container, bool validateRecycledTypes) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

