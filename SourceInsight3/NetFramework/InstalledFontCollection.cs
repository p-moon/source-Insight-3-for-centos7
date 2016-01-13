public class InstalledFontCollection : FontCollection, System.IDisposable
{

	// Constructors
	public InstalledFontCollection() {}

	// Methods
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.FontFamily[] Families { get{} }
}

