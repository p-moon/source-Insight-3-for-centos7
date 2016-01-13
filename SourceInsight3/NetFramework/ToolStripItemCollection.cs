public class ToolStripItemCollection : System.Windows.Forms.Layout.ArrangedElementCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ToolStripItemCollection(ToolStrip owner, ToolStripItem[] value) {}

	// Methods
	public void AddRange(ToolStripItem[] toolStripItems) {}
	public ToolStripItem Add(string text) {}
	public ToolStripItem Add(System.Drawing.Image image) {}
	public ToolStripItem Add(string text, System.Drawing.Image image) {}
	public ToolStripItem Add(string text, System.Drawing.Image image, System.EventHandler onClick) {}
	public int Add(ToolStripItem value) {}
	public void AddRange(ToolStripItemCollection toolStripItems) {}
	public bool Contains(ToolStripItem value) {}
	public virtual void Clear() {}
	public virtual bool ContainsKey(string key) {}
	public ToolStripItem[] Find(string key, bool searchAllChildren) {}
	public void Insert(int index, ToolStripItem value) {}
	public int IndexOf(ToolStripItem value) {}
	public virtual int IndexOfKey(string key) {}
	public void Remove(ToolStripItem value) {}
	public void RemoveAt(int index) {}
	public virtual void RemoveByKey(string key) {}
	public void CopyTo(ToolStripItem[] array, int index) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ToolStripItem Item { get{} }
	public ToolStripItem Item { get{} }
	public bool IsReadOnly { get{} }
	public int Count { get{} }
}

