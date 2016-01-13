public class TemplateGroupCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public TemplateGroupCollection() {}

	// Methods
	public int Add(TemplateGroup group) {}
	public void AddRange(TemplateGroupCollection groups) {}
	public void Clear() {}
	public bool Contains(TemplateGroup group) {}
	public void CopyTo(TemplateGroup[] array, int index) {}
	public int IndexOf(TemplateGroup group) {}
	public void Insert(int index, TemplateGroup group) {}
	public void Remove(TemplateGroup group) {}
	public void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public TemplateGroup Item { get{} set{} }
}

