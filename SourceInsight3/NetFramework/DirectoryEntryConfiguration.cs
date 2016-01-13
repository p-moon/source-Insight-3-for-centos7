public class DirectoryEntryConfiguration
{

	// Methods
	public string GetCurrentServerName() {}
	public bool IsMutuallyAuthenticated() {}
	public void SetUserNameQueryQuota(string accountName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ReferralChasingOption Referral { get{} set{} }
	public SecurityMasks SecurityMasks { get{} set{} }
	public int PageSize { get{} set{} }
	public int PasswordPort { get{} set{} }
	public PasswordEncodingMethod PasswordEncoding { get{} set{} }
}

