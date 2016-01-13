public interface UCOMIEnumString
{

	// Methods
	public abstract virtual int Next(int celtout , string[] rgeltout , System.Int32& pceltFetched) {}
	public abstract virtual int Skip(int celt) {}
	public abstract virtual int Reset() {}
	public abstract virtual void Clone(out UCOMIEnumString& ppenum) {}
}

