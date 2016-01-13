public class ComponentSerializationService
{

	// Methods
	public abstract virtual SerializationStore CreateStore() {}
	public abstract virtual SerializationStore LoadStore(System.IO.Stream stream) {}
	public abstract virtual void Serialize(SerializationStore store, object value) {}
	public abstract virtual void SerializeAbsolute(SerializationStore store, object value) {}
	public abstract virtual void SerializeMember(SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member) {}
	public abstract virtual void SerializeMemberAbsolute(SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member) {}
	public abstract virtual System.Collections.ICollection Deserialize(SerializationStore store) {}
	public abstract virtual System.Collections.ICollection Deserialize(SerializationStore store, System.ComponentModel.IContainer container) {}
	public abstract virtual void DeserializeTo(SerializationStore store, System.ComponentModel.IContainer container, bool validateRecycledTypes, bool applyDefaults) {}
	public void DeserializeTo(SerializationStore store, System.ComponentModel.IContainer container) {}
	public void DeserializeTo(SerializationStore store, System.ComponentModel.IContainer container, bool validateRecycledTypes) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

