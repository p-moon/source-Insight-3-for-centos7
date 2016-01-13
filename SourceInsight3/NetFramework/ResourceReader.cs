public class ResourceReader : IResourceReader, System.Collections.IEnumerable, System.IDisposable
{

	// Constructors
	public ResourceReader(string fileName) {}
	public ResourceReader(System.IO.Stream stream) {}

	// Methods
	public virtual void Close() {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public void GetResourceData(string resourceNameout , System.String& resourceTypeout , System.Byte[]& resourceData) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

