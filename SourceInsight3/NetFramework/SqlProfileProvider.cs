public class SqlProfileProvider : ProfileProvider
{

	// Constructors
	public SqlProfileProvider() {}

	// Methods
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection config) {}
	public virtual System.Configuration.SettingsPropertyValueCollection GetPropertyValues(System.Configuration.SettingsContext sc, System.Configuration.SettingsPropertyCollection properties) {}
	public virtual void SetPropertyValues(System.Configuration.SettingsContext sc, System.Configuration.SettingsPropertyValueCollection properties) {}
	public virtual int DeleteProfiles(ProfileInfoCollection profiles) {}
	public virtual int DeleteProfiles(string[] usernames) {}
	public virtual int DeleteInactiveProfiles(ProfileAuthenticationOption authenticationOption, System.DateTime userInactiveSinceDate) {}
	public virtual int GetNumberOfInactiveProfiles(ProfileAuthenticationOption authenticationOption, System.DateTime userInactiveSinceDate) {}
	public virtual ProfileInfoCollection GetAllProfiles(ProfileAuthenticationOption authenticationOption, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public virtual ProfileInfoCollection GetAllInactiveProfiles(ProfileAuthenticationOption authenticationOption, System.DateTime userInactiveSinceDate, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public virtual ProfileInfoCollection FindProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public virtual ProfileInfoCollection FindInactiveProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch, System.DateTime userInactiveSinceDate, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationName { get{} set{} }
	public string Name { get{} }
	public string Description { get{} }
}

