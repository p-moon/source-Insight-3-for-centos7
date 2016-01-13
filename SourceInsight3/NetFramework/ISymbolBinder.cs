public interface ISymbolBinder
{

	// Methods
	public abstract virtual ISymbolReader GetReader(int importer, string filename, string searchPath) {}
}

