public class State : System.Runtime.Serialization.ISerializable
{

	// Constructors
	public State(System.IO.Stream ms, int storageType, bool manualUpdate, string licKey) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

