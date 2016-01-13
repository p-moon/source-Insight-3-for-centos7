public class tagEXCEPINFO
{

	// Constructors
	public tagEXCEPINFO() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

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

