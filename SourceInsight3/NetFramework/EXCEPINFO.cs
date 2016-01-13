public class EXCEPINFO : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public short wCode;
	public short wReserved;
	public string bstrSource;
	public string bstrDescription;
	public string bstrHelpFile;
	public int dwHelpContext;
	public System.IntPtr pvReserved;
	public System.IntPtr pfnDeferredFillIn;
	public int scode;
}

