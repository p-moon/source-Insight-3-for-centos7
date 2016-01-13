public interface IEnumVariant
{

	// Methods
	public abstract virtual int Next(int celtout , System.IntPtr rgvarout , int[] pceltFetched) {}
	public abstract virtual void Skip(int celt) {}
	public abstract virtual void Reset() {}
	public abstract virtual void Clone(out IEnumVariant[] ppenum) {}
}

