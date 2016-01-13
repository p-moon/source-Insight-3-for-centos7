public interface IEnumVARIANT
{

	// Methods
	public abstract virtual int Next(int celtout , object[] rgVar, System.IntPtr pceltFetched) {}
	public abstract virtual int Skip(int celt) {}
	public abstract virtual int Reset() {}
	public abstract virtual IEnumVARIANT Clone() {}
}

