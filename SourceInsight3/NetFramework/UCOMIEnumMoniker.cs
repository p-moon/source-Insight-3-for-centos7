public interface UCOMIEnumMoniker
{

	// Methods
	public abstract virtual int Next(int celtout , UCOMIMoniker[] rgeltout , System.Int32& pceltFetched) {}
	public abstract virtual int Skip(int celt) {}
	public abstract virtual int Reset() {}
	public abstract virtual void Clone(out UCOMIEnumMoniker& ppenum) {}
}

