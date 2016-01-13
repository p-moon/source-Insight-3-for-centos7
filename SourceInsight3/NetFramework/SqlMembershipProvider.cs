public class SqlMembershipProvider : MembershipProvider
{

	// Constructors
	public SqlMembershipProvider() {}

	// Methods
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection config) {}
	public virtual MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKeyout , MembershipCreateStatus& status) {}
	public virtual bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer) {}
	public virtual string GetPassword(string username, string passwordAnswer) {}
	public virtual bool ChangePassword(string username, string oldPassword, string newPassword) {}
	public virtual string ResetPassword(string username, string passwordAnswer) {}
	public virtual void UpdateUser(MembershipUser user) {}
	public virtual bool ValidateUser(string username, string password) {}
	public virtual bool UnlockUser(string username) {}
	public virtual MembershipUser GetUser(object providerUserKey, bool userIsOnline) {}
	public virtual MembershipUser GetUser(string username, bool userIsOnline) {}
	public virtual string GetUserNameByEmail(string email) {}
	public virtual bool DeleteUser(string username, bool deleteAllRelatedData) {}
	public virtual MembershipUserCollection GetAllUsers(int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public virtual int GetNumberOfUsersOnline() {}
	public virtual MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public virtual MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public virtual string GeneratePassword() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool EnablePasswordRetrieval { get{} }
	public bool EnablePasswordReset { get{} }
	public bool RequiresQuestionAndAnswer { get{} }
	public bool RequiresUniqueEmail { get{} }
	public MembershipPasswordFormat PasswordFormat { get{} }
	public int MaxInvalidPasswordAttempts { get{} }
	public int PasswordAttemptWindow { get{} }
	public int MinRequiredPasswordLength { get{} }
	public int MinRequiredNonAlphanumericCharacters { get{} }
	public string PasswordStrengthRegularExpression { get{} }
	public string ApplicationName { get{} set{} }
	public string Name { get{} }
	public string Description { get{} }

	// Events
	public event System.Web.Security.MembershipValidatePasswordEventHandler ValidatingPassword;
}

