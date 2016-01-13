public class MembershipProvider : System.Configuration.Provider.ProviderBase
{

	// Methods
	public abstract virtual MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKeyout , MembershipCreateStatus& status) {}
	public abstract virtual bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer) {}
	public abstract virtual string GetPassword(string username, string answer) {}
	public abstract virtual bool ChangePassword(string username, string oldPassword, string newPassword) {}
	public abstract virtual string ResetPassword(string username, string answer) {}
	public abstract virtual void UpdateUser(MembershipUser user) {}
	public abstract virtual bool ValidateUser(string username, string password) {}
	public abstract virtual bool UnlockUser(string userName) {}
	public abstract virtual MembershipUser GetUser(object providerUserKey, bool userIsOnline) {}
	public abstract virtual MembershipUser GetUser(string username, bool userIsOnline) {}
	public abstract virtual string GetUserNameByEmail(string email) {}
	public abstract virtual bool DeleteUser(string username, bool deleteAllRelatedData) {}
	public abstract virtual MembershipUserCollection GetAllUsers(int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public abstract virtual int GetNumberOfUsersOnline() {}
	public abstract virtual MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public abstract virtual MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection config) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool EnablePasswordRetrieval { get{} }
	public bool EnablePasswordReset { get{} }
	public bool RequiresQuestionAndAnswer { get{} }
	public string ApplicationName { get{} set{} }
	public int MaxInvalidPasswordAttempts { get{} }
	public int PasswordAttemptWindow { get{} }
	public bool RequiresUniqueEmail { get{} }
	public MembershipPasswordFormat PasswordFormat { get{} }
	public int MinRequiredPasswordLength { get{} }
	public int MinRequiredNonAlphanumericCharacters { get{} }
	public string PasswordStrengthRegularExpression { get{} }
	public string Name { get{} }
	public string Description { get{} }

	// Events
	public event System.Web.Security.MembershipValidatePasswordEventHandler ValidatingPassword;
}

