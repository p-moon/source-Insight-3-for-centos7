public class PassportIdentity : System.Security.Principal.IIdentity, System.IDisposable
{

	// Constructors
	public PassportIdentity() {}

	// Methods
	public bool GetIsAuthenticated(int iTimeWindow, bool bForceLogin, bool bCheckSecure) {}
	public bool GetIsAuthenticated(int iTimeWindow, int iForceLogin, int iCheckSecure) {}
	public object GetProfileObject(string strProfileName) {}
	public string GetDomainFromMemberName(string strMemberName) {}
	public bool HasProfile(string strProfile) {}
	public bool HasFlag(int iFlagMask) {}
	public bool HaveConsent(bool bNeedFullConsent, bool bNeedBirthdate) {}
	public object GetOption(string strOpt) {}
	public void SetOption(string strOpt, object vOpt) {}
	public string LogoutURL() {}
	public string LogoutURL(string szReturnURL, string szCOBrandArgs, int iLangID, string strDomain, int iUseSecureAuth) {}
	public string LogoTag() {}
	public string LogoTag(string strReturnUrl) {}
	public string LogoTag2() {}
	public string LogoTag2(string strReturnUrl) {}
	public string LogoTag(string strReturnUrl, int iTimeWindow, bool fForceLogin, string strCoBrandedArgs, int iLangID, bool fSecure, string strNameSpace, int iKPP, bool bUseSecureAuth) {}
	public string LogoTag(string strReturnUrl, int iTimeWindow, int iForceLogin, string strCoBrandedArgs, int iLangID, int iSecure, string strNameSpace, int iKPP, int iUseSecureAuth) {}
	public string LogoTag2(string strReturnUrl, int iTimeWindow, bool fForceLogin, string strCoBrandedArgs, int iLangID, bool fSecure, string strNameSpace, int iKPP, bool bUseSecureAuth) {}
	public string LogoTag2(string strReturnUrl, int iTimeWindow, int iForceLogin, string strCoBrandedArgs, int iLangID, int iSecure, string strNameSpace, int iKPP, int iUseSecureAuth) {}
	public string AuthUrl() {}
	public string AuthUrl(string strReturnUrl) {}
	public string AuthUrl2() {}
	public string AuthUrl2(string strReturnUrl) {}
	public string AuthUrl(string strReturnUrl, int iTimeWindow, bool fForceLogin, string strCoBrandedArgs, int iLangID, string strNameSpace, int iKPP, bool bUseSecureAuth) {}
	public string AuthUrl2(string strReturnUrl, int iTimeWindow, bool fForceLogin, string strCoBrandedArgs, int iLangID, string strNameSpace, int iKPP, bool bUseSecureAuth) {}
	public string AuthUrl(string strReturnUrl, int iTimeWindow, int iForceLogin, string strCoBrandedArgs, int iLangID, string strNameSpace, int iKPP, int iUseSecureAuth) {}
	public string AuthUrl2(string strReturnUrl, int iTimeWindow, int iForceLogin, string strCoBrandedArgs, int iLangID, string strNameSpace, int iKPP, int iUseSecureAuth) {}
	public int LoginUser(string szRetURL, int iTimeWindow, bool fForceLogin, string szCOBrandArgs, int iLangID, string strNameSpace, int iKPP, bool fUseSecureAuth, object oExtraParams) {}
	public int LoginUser(string szRetURL, int iTimeWindow, int fForceLogin, string szCOBrandArgs, int iLangID, string strNameSpace, int iKPP, int iUseSecureAuth, object oExtraParams) {}
	public int LoginUser() {}
	public int LoginUser(string strReturnUrl) {}
	public string GetLoginChallenge() {}
	public string GetLoginChallenge(string strReturnUrl) {}
	public string GetLoginChallenge(string szRetURL, int iTimeWindow, int fForceLogin, string szCOBrandArgs, int iLangID, string strNameSpace, int iKPP, int iUseSecureAuth, object oExtraParams) {}
	public string GetDomainAttribute(string strAttribute, int iLCID, string strDomain) {}
	public object Ticket(string strAttribute) {}
	public object GetCurrentConfig(string strAttribute) {}
	public static void SignOut(string strSignOutDotGifFileName) {}
	public static string Encrypt(string strData) {}
	public static string Decrypt(string strData) {}
	public static string Compress(string strData) {}
	public static string Decompress(string strData) {}
	public static int CryptPutHost(string strHost) {}
	public static int CryptPutSite(string strSite) {}
	public static bool CryptIsValid() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string AuthenticationType { get{} }
	public bool IsAuthenticated { get{} }
	public string Item { get{} }
	public int Error { get{} }
	public bool GetFromNetworkServer { get{} }
	public bool HasSavedPassword { get{} }
	public bool HasTicket { get{} }
	public int TicketAge { get{} }
	public int TimeSinceSignIn { get{} }
	public string HexPUID { get{} }
}

