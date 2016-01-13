public interface IEnumString
{

	// Methods
	public abstract virtual int Next(int celtout , string[] rgelt, System.IntPtr pceltFetched) {}
	public abstract virtual int Skip(int celt) {}
	public abstract virtual void Reset() {}
	public abstract virtual void Clone(out IEnumString& ppenum) {}
}

