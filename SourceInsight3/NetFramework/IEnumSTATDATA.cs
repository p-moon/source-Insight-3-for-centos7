public interface IEnumSTATDATA
{

	// Methods
	public abstract virtual int Next(int celtout , STATDATA[] rgeltout , int[] pceltFetched) {}
	public abstract virtual int Skip(int celt) {}
	public abstract virtual int Reset() {}
	public abstract virtual void Clone(out IEnumSTATDATA& newEnum) {}
}

