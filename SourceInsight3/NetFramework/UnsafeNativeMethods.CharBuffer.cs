public class CharBuffer
{

	// Methods
	public static CharBuffer CreateBuffer(int size) {}
	public abstract virtual System.IntPtr AllocCoTaskMem() {}
	public abstract virtual string GetString() {}
	public abstract virtual void PutCoTaskMem(System.IntPtr ptr) {}
	public abstract virtual void PutString(string s) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

