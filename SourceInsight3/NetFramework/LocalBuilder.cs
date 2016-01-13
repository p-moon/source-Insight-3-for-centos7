public class LocalBuilder : System.Reflection.LocalVariableInfo, System.Runtime.InteropServices._LocalBuilder
{

	// Methods
	public void SetLocalSymInfo(string name) {}
	public void SetLocalSymInfo(string name, int startOffset, int endOffset) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsPinned { get{} }
	public Type LocalType { get{} }
	public int LocalIndex { get{} }
}

