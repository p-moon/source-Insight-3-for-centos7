public class SymBinder : ISymbolBinder, ISymbolBinder1
{

	// Constructors
	public SymBinder() {}

	// Methods
	public virtual ISymbolReader GetReader(System.IntPtr importer, string filename, string searchPath) {}
	public virtual ISymbolReader GetReader(int importer, string filename, string searchPath) {}
	public void {dtor}() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

