public interface IAdsPropertyList
{

	// Methods
	public abstract virtual int Next(out System.Object& nextProp) {}
	public abstract virtual void Skip(int cElements) {}
	public abstract virtual void Reset() {}
	public abstract virtual object Item(object varIndex) {}
	public abstract virtual object GetPropertyItem(string bstrName, int ADsType) {}
	public abstract virtual void PutPropertyItem(object varData) {}
	public abstract virtual void ResetPropertyItem(object varEntry) {}
	public abstract virtual void PurgePropertyList() {}

	// Properties
	public int PropertyCount { get{} }
}

