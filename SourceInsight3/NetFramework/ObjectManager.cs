public class ObjectManager
{

	// Constructors
	public ObjectManager(ISurrogateSelector selector, StreamingContext context) {}

	// Methods
	public virtual object GetObject(long objectID) {}
	public virtual void RegisterObject(object obj, long objectID) {}
	public void RegisterObject(object obj, long objectID, SerializationInfo info) {}
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, System.Reflection.MemberInfo member) {}
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, System.Reflection.MemberInfo member, int[] arrayIndex) {}
	public virtual void DoFixups() {}
	public virtual void RecordFixup(long objectToBeFixed, System.Reflection.MemberInfo member, long objectRequired) {}
	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) {}
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int index, long objectRequired) {}
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) {}
	public virtual void RaiseDeserializationEvent() {}
	public void RaiseOnDeserializingEvent(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

