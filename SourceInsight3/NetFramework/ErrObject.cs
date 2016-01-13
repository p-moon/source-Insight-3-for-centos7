public class ErrObject
{

	// Methods
	public System.Exception GetException() {}
	public void Clear() {}
	public void Raise(int Number, object Source, object Description, object HelpFile, object HelpContext) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Erl { get{} }
	public int Number { get{} set{} }
	public string Source { get{} set{} }
	public string Description { get{} set{} }
	public string HelpFile { get{} set{} }
	public int HelpContext { get{} set{} }
	public int LastDllError { get{} }
}

