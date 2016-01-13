public class SecureString : System.IDisposable
{

	// Constructors
	public SecureString() {}
	public SecureString(System.Char* value, int length) {}

	// Methods
	public void AppendChar(char c) {}
	public void Clear() {}
	public SecureString Copy() {}
	public virtual void Dispose() {}
	public void InsertAt(int index, char c) {}
	public bool IsReadOnly() {}
	public void MakeReadOnly() {}
	public void RemoveAt(int index) {}
	public void SetAt(int index, char c) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Length { get{} }
}

