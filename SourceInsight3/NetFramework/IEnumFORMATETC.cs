public interface IEnumFORMATETC
{

	// Methods
	public abstract virtual int Next(int celtout , FORMATETC[] rgeltout , int[] pceltFetched) {}
	public abstract virtual int Skip(int celt) {}
	public abstract virtual int Reset() {}
	public abstract virtual void Clone(out IEnumFORMATETC& newEnum) {}
}

