public class ImageCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public void Add(string key, System.Drawing.Image image) {}
	public void Add(string key, System.Drawing.Icon icon) {}
	public void Add(System.Drawing.Icon value) {}
	public void Add(System.Drawing.Image value) {}
	public int Add(System.Drawing.Image value, System.Drawing.Color transparentColor) {}
	public void AddRange(System.Drawing.Image[] images) {}
	public int AddStrip(System.Drawing.Image value) {}
	public virtual void Clear() {}
	public bool Contains(System.Drawing.Image image) {}
	public bool ContainsKey(string key) {}
	public int IndexOf(System.Drawing.Image image) {}
	public int IndexOfKey(string key) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Remove(System.Drawing.Image image) {}
	public virtual void RemoveAt(int index) {}
	public void RemoveByKey(string key) {}
	public void SetKeyName(int index, string name) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.Specialized.StringCollection Keys { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool Empty { get{} }
	public System.Drawing.Image Item { get{} set{} }
	public System.Drawing.Image Item { get{} }
}

