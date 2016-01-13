public interface IEnumSTATDATA
{

	// Methods
	public abstract virtual void Next(int celtout , STATDATA rgeltout , int[] pceltFetched) {}
	public abstract virtual void Skip(int celt) {}
	public abstract virtual void Reset() {}
	public abstract virtual void Clone(out IEnumSTATDATA[] ppenum) {}
}

