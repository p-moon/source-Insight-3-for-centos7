public interface UCOMIEnumConnections
{

	// Methods
	public abstract virtual int Next(int celtout , CONNECTDATA[] rgeltout , System.Int32& pceltFetched) {}
	public abstract virtual int Skip(int celt) {}
	public abstract virtual void Reset() {}
	public abstract virtual void Clone(out UCOMIEnumConnections& ppenum) {}
}

