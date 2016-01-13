public interface IEnumOLEVERB
{

	// Methods
	public abstract virtual int Next(int celtout , tagOLEVERB rgeltout , int[] pceltFetched) {}
	public abstract virtual int Skip(int celt) {}
	public abstract virtual void Reset() {}
	public abstract virtual void Clone(out IEnumOLEVERB& ppenum) {}
}

