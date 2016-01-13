public class ToolStripPanelRowCollection : System.Windows.Forms.Layout.ArrangedElementCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ToolStripPanelRowCollection(ToolStripPanel owner) {}
	public ToolStripPanelRowCollection(ToolStripPanel owner, ToolStripPanelRow[] value) {}

	// Methods
	public int Add(ToolStripPanelRow value) {}
	public void AddRange(ToolStripPanelRow[] value) {}
	public void AddRange(ToolStripPanelRowCollection value) {}
	public bool Contains(ToolStripPanelRow value) {}
	public virtual void Clear() {}
	public int IndexOf(ToolStripPanelRow value) {}
	public void Insert(int index, ToolStripPanelRow value) {}
	public void Remove(ToolStripPanelRow value) {}
	public void RemoveAt(int index) {}
	public void CopyTo(ToolStripPanelRow[] array, int index) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ToolStripPanelRow Item { get{} }
	public bool IsReadOnly { get{} }
	public int Count { get{} }
}

