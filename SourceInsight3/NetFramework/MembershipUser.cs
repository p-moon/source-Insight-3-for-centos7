public class MembershipUser
{

	// Constructors
	public MembershipUser(string providerName, string name, object providerUserKey, string email, string passwordQuestion, string comment, bool isApproved, bool isLockedOut, System.DateTime creationDate, System.DateTime lastLoginDate, System.DateTime lastActivityDate, System.DateTime lastPasswordChangedDate, System.DateTime lastLockoutDate) {}

	// Methods
	public virtual string ToString() {}
	public virtual string GetPassword() {}
	public virtual string GetPassword(string passwordAnswer) {}
	public virtual bool ChangePassword(string oldPassword, string newPassword) {}
	public virtual bool ChangePasswordQuestionAndAnswer(string password, string newPasswordQuestion, string newPasswordAnswer) {}
	public virtual string ResetPassword(string passwordAnswer) {}
	public virtual string ResetPassword() {}
	public virtual bool UnlockUser() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string UserName { get{} }
	public object ProviderUserKey { get{} }
	public string Email { get{} set{} }
	public string PasswordQuestion { get{} }
	public string Comment { get{} set{} }
	public bool IsApproved { get{} set{} }
	public bool IsLockedOut { get{} }
	public System.DateTime LastLockoutDate { get{} }
	public System.DateTime CreationDate { get{} }
	public System.DateTime LastLoginDate { get{} set{} }
	public System.DateTime LastActivityDate { get{} set{} }
	public System.DateTime LastPasswordChangedDate { get{} }
	public bool IsOnline { get{} }
	public string ProviderName { get{} }
}

