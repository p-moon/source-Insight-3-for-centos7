public class ProfileManager
{

	// Methods
	public static bool DeleteProfile(string username) {}
	public static int DeleteProfiles(ProfileInfoCollection profiles) {}
	public static int DeleteProfiles(string[] usernames) {}
	public static int DeleteInactiveProfiles(ProfileAuthenticationOption authenticationOption, System.DateTime userInactiveSinceDate) {}
	public static int GetNumberOfProfiles(ProfileAuthenticationOption authenticationOption) {}
	public static int GetNumberOfInactiveProfiles(ProfileAuthenticationOption authenticationOption, System.DateTime userInactiveSinceDate) {}
	public static ProfileInfoCollection GetAllProfiles(ProfileAuthenticationOption authenticationOption) {}
	public static ProfileInfoCollection GetAllProfiles(ProfileAuthenticationOption authenticationOption, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public static ProfileInfoCollection GetAllInactiveProfiles(ProfileAuthenticationOption authenticationOption, System.DateTime userInactiveSinceDate) {}
	public static ProfileInfoCollection GetAllInactiveProfiles(ProfileAuthenticationOption authenticationOption, System.DateTime userInactiveSinceDate, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public static ProfileInfoCollection FindProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch) {}
	public static ProfileInfoCollection FindProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public static ProfileInfoCollection FindInactiveProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch, System.DateTime userInactiveSinceDate) {}
	public static ProfileInfoCollection FindInactiveProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch, System.DateTime userInactiveSinceDate, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Enabled { get{} }
	public string ApplicationName { get{} set{} }
	public bool AutomaticSaveEnabled { get{} }
	public ProfileProvider Provider { get{} }
	public ProfileProviderCollection Providers { get{} }
}

