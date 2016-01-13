public class PrivateFontCollection : FontCollection, System.IDisposable
{

	// Constructors
	public PrivateFontCollection() {}

	// Methods
	public void AddFontFile(string filename) {}
	public void AddMemoryFont(System.IntPtr memory, int length) {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.FontFamily[] Families { get{} }
}

