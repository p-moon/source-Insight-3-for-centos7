public interface IEnumConnections
{

	// Methods
	public abstract virtual int Next(int celtout , CONNECTDATA[] rgelt, System.IntPtr pceltFetched) {}
	public abstract virtual int Skip(int celt) {}
	public abstract virtual void Reset() {}
	public abstract virtual void Clone(out IEnumConnections& ppenum) {}
}

