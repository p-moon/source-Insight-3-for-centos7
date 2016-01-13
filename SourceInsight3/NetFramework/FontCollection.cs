public class FontCollection : System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.FontFamily[] Families { get{} }
}

