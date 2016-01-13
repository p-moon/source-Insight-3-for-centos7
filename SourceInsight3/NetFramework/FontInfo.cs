public class FontInfo
{

	// Methods
	public void ClearDefaults() {}
	public void CopyFrom(FontInfo f) {}
	public void MergeWith(FontInfo f) {}
	public bool ShouldSerializeNames() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Bold { get{} set{} }
	public bool Italic { get{} set{} }
	public string Name { get{} set{} }
	public string[] Names { get{} set{} }
	public bool Overline { get{} set{} }
	public FontUnit Size { get{} set{} }
	public bool Strikeout { get{} set{} }
	public bool Underline { get{} set{} }
}

