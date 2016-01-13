public class ObjectStateFormatter : IStateFormatter, System.Runtime.Serialization.IFormatter
{

	// Constructors
	public ObjectStateFormatter() {}

	// Methods
	public object Deserialize(System.IO.Stream inputStream) {}
	public object Deserialize(string inputString) {}
	public string Serialize(object stateGraph) {}
	public void Serialize(System.IO.Stream outputStream, object stateGraph) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

