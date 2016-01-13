public class TextInfo : System.ICloneable, System.Runtime.Serialization.IDeserializationCallback
{

	// Methods
	public virtual object Clone() {}
	public static TextInfo ReadOnly(TextInfo textInfo) {}
	public virtual char ToLower(char c) {}
	public virtual string ToLower(string str) {}
	public virtual char ToUpper(char c) {}
	public virtual string ToUpper(string str) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public string ToTitleCase(string str) {}
	public Type GetType() {}

	// Properties
	public int ANSICodePage { get{} }
	public int OEMCodePage { get{} }
	public int MacCodePage { get{} }
	public int EBCDICCodePage { get{} }
	public int LCID { get{} }
	public string CultureName { get{} }
	public bool IsReadOnly { get{} }
	public string ListSeparator { get{} set{} }
	public bool IsRightToLeft { get{} }
}

