public class CssStyleCollection
{

	// Methods
	public void Add(string key, string value) {}
	public void Add(HtmlTextWriterStyle key, string value) {}
	public void Remove(string key) {}
	public void Remove(HtmlTextWriterStyle key) {}
	public void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Item { get{} set{} }
	public string Item { get{} set{} }
	public System.Collections.ICollection Keys { get{} }
	public int Count { get{} }
	public string Value { get{} set{} }
}

