public class FileDialogCustomPlacesCollection : Collection<System.Windows.Forms.FileDialogCustomPlace>, IList<System.Windows.Forms.FileDialogCustomPlace>, ICollection<System.Windows.Forms.FileDialogCustomPlace>, IEnumerable<System.Windows.Forms.FileDialogCustomPlace>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection
{

	// Constructors
	public FileDialogCustomPlacesCollection() {}

	// Methods
	public void Add(string path) {}
	public void Add(System.Guid knownFolderGuid) {}
	public virtual void Add(FileDialogCustomPlace item) {}
	public virtual void Clear() {}
	public virtual void CopyTo(FileDialogCustomPlace[] array, int index) {}
	public virtual bool Contains(FileDialogCustomPlace item) {}
	public virtual IEnumerator<System.Windows.Forms.FileDialogCustomPlace> GetEnumerator() {}
	public virtual int IndexOf(FileDialogCustomPlace item) {}
	public virtual void Insert(int index, FileDialogCustomPlace item) {}
	public virtual bool Remove(FileDialogCustomPlace item) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public FileDialogCustomPlace Item { get{} set{} }
}

