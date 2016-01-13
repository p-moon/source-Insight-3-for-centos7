public class PersonalizationAdministration
{

	// Methods
	public static int ResetAllState(PersonalizationScope scope) {}
	public static int ResetState(PersonalizationStateInfoCollection data) {}
	public static bool ResetSharedState(string path) {}
	public static int ResetSharedState(string[] paths) {}
	public static int ResetUserState(string path) {}
	public static int ResetUserState(string[] usernames) {}
	public static bool ResetUserState(string path, string username) {}
	public static int ResetUserState(string path, string[] usernames) {}
	public static int ResetInactiveUserState(System.DateTime userInactiveSinceDate) {}
	public static int ResetInactiveUserState(string path, System.DateTime userInactiveSinceDate) {}
	public static int GetCountOfState(PersonalizationScope scope) {}
	public static int GetCountOfState(PersonalizationScope scope, string pathToMatch) {}
	public static int GetCountOfUserState(string usernameToMatch) {}
	public static int GetCountOfInactiveUserState(System.DateTime userInactiveSinceDate) {}
	public static int GetCountOfInactiveUserState(string pathToMatch, System.DateTime userInactiveSinceDate) {}
	public static PersonalizationStateInfoCollection GetAllState(PersonalizationScope scope) {}
	public static PersonalizationStateInfoCollection GetAllState(PersonalizationScope scope, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public static PersonalizationStateInfoCollection GetAllInactiveUserState(System.DateTime userInactiveSinceDate) {}
	public static PersonalizationStateInfoCollection GetAllInactiveUserState(System.DateTime userInactiveSinceDate, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public static PersonalizationStateInfoCollection FindSharedState(string pathToMatch) {}
	public static PersonalizationStateInfoCollection FindSharedState(string pathToMatch, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public static PersonalizationStateInfoCollection FindUserState(string pathToMatch, string usernameToMatch) {}
	public static PersonalizationStateInfoCollection FindUserState(string pathToMatch, string usernameToMatch, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public static PersonalizationStateInfoCollection FindInactiveUserState(string pathToMatch, string usernameToMatch, System.DateTime userInactiveSinceDate) {}
	public static PersonalizationStateInfoCollection FindInactiveUserState(string pathToMatch, string usernameToMatch, System.DateTime userInactiveSinceDate, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationName { get{} set{} }
	public PersonalizationProvider Provider { get{} }
	public PersonalizationProviderCollection Providers { get{} }
}

