public interface IPerPropertyBrowsing
{

	// Methods
	public abstract virtual int GetDisplayString(int dispIDout , string[] pBstr) {}
	public abstract virtual int MapPropertyToPage(int dispIDout , System.Guid& pGuid) {}
	public abstract virtual int GetPredefinedStrings(int dispIDout , CA_STRUCT pCaStringsOutout , CA_STRUCT pCaCookiesOut) {}
	public abstract virtual int GetPredefinedValue(int dispID, int dwCookieout , VARIANT pVarOut) {}
}

