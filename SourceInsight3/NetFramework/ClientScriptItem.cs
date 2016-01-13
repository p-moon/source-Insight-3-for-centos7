public class ClientScriptItem
{

	// Constructors
	public ClientScriptItem(string text, string source, string language, string type, string id) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Id { get{} }
	public string Language { get{} }
	public string Source { get{} }
	public string Text { get{} }
	public string Type { get{} }
}

