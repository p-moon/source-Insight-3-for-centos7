public class Membership
{

	// Methods
	public static MembershipUser CreateUser(string username, string password) {}
	public static MembershipUser CreateUser(string username, string password, string email) {}
	public static MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApprovedout , MembershipCreateStatus& status) {}
	public static MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKeyout , MembershipCreateStatus& status) {}
	public static bool ValidateUser(string username, string password) {}
	public static MembershipUser GetUser() {}
	public static MembershipUser GetUser(bool userIsOnline) {}
	public static MembershipUser GetUser(string username) {}
	public static MembershipUser GetUser(string username, bool userIsOnline) {}
	public static MembershipUser GetUser(object providerUserKey) {}
	public static MembershipUser GetUser(object providerUserKey, bool userIsOnline) {}
	public static string GetUserNameByEmail(string emailToMatch) {}
	public static bool DeleteUser(string username) {}
	public static bool DeleteUser(string username, bool deleteAllRelatedData) {}
	public static void UpdateUser(MembershipUser user) {}
	public static MembershipUserCollection GetAllUsers() {}
	public static MembershipUserCollection GetAllUsers(int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public static int GetNumberOfUsersOnline() {}
	public static string GeneratePassword(int length, int numberOfNonAlphanumericCharacters) {}
	public static MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public static MembershipUserCollection FindUsersByName(string usernameToMatch) {}
	public static MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public static MembershipUserCollection FindUsersByEmail(string emailToMatch) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool EnablePasswordRetrieval { get{} }
	public bool EnablePasswordReset { get{} }
	public bool RequiresQuestionAndAnswer { get{} }
	public int UserIsOnlineTimeWindow { get{} }
	public MembershipProviderCollection Providers { get{} }
	public MembershipProvider Provider { get{} }
	public string HashAlgorithmType { get{} }
	public int MaxInvalidPasswordAttempts { get{} }
	public int PasswordAttemptWindow { get{} }
	public int MinRequiredPasswordLength { get{} }
	public int MinRequiredNonAlphanumericCharacters { get{} }
	public string PasswordStrengthRegularExpression { get{} }
	public string ApplicationName { get{} set{} }

	// Events
	public event System.Web.Security.MembershipValidatePasswordEventHandler ValidatingPassword;
}

