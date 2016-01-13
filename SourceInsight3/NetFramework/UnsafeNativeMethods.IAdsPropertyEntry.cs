public interface IAdsPropertyEntry
{

	// Methods
	public abstract virtual void Clear() {}

	// Properties
	public string Name { get{} set{} }
	public int ADsType { get{} set{} }
	public int ControlCode { get{} set{} }
	public object Values { get{} set{} }
}

