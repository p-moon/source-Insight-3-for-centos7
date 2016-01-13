public class TextViewElement
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Text { get{} }
	public string Url { get{} }
	public bool IsBold { get{} }
	public bool IsItalic { get{} }
	public bool BreakAfter { get{} }
}

