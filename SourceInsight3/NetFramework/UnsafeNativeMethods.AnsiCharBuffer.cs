public class AnsiCharBuffer : CharBuffer
{

	// Constructors
	public AnsiCharBuffer(int size) {}

	// Methods
	public virtual System.IntPtr AllocCoTaskMem() {}
	public virtual string GetString() {}
	public virtual void PutCoTaskMem(System.IntPtr ptr) {}
	public virtual void PutString(string s) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

