public class SharedPersonalizationStateInfo : PersonalizationStateInfo
{

	// Constructors
	public SharedPersonalizationStateInfo(string path, System.DateTime lastUpdatedDate, int size, int sizeOfPersonalizations, int countOfPersonalizations) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int SizeOfPersonalizations { get{} }
	public int CountOfPersonalizations { get{} }
	public string Path { get{} }
	public System.DateTime LastUpdatedDate { get{} }
	public int Size { get{} }
}

