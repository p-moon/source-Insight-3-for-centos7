public class TempFileCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.IDisposable
{

	// Constructors
	public TempFileCollection() {}
	public TempFileCollection(string tempDir) {}
	public TempFileCollection(string tempDir, bool keepFiles) {}

	// Methods
	public string AddExtension(string fileExtension) {}
	public string AddExtension(string fileExtension, bool keepFile) {}
	public void AddFile(string fileName, bool keepFile) {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(string[] fileNames, int start) {}
	public void Delete() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public string TempDir { get{} }
	public string BasePath { get{} }
	public bool KeepFiles { get{} set{} }
}

