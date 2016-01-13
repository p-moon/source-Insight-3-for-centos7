public interface UCOMIEnumVARIANT
{

	// Methods
	public abstract virtual int Next(int celt, int rgvar, int pceltFetched) {}
	public abstract virtual int Skip(int celt) {}
	public abstract virtual int Reset() {}
	public abstract virtual void Clone(int ppenum) {}
}

