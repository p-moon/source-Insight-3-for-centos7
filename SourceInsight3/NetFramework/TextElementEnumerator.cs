public class TextElementEnumerator : System.Collections.IEnumerator
{

	// Methods
	public virtual bool MoveNext() {}
	public string GetTextElement() {}
	public virtual void Reset() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Current { get{} }
	public int ElementIndex { get{} }
}

