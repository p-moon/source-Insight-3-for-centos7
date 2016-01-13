public class SqlPersonalizationProvider : PersonalizationProvider
{

	// Constructors
	public SqlPersonalizationProvider() {}

	// Methods
	public virtual PersonalizationStateInfoCollection FindState(PersonalizationScope scope, PersonalizationStateQuery query, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public virtual int GetCountOfState(PersonalizationScope scope, PersonalizationStateQuery query) {}
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection configSettings) {}
	public virtual int ResetUserState(string path, System.DateTime userInactiveSinceDate) {}
	public virtual int ResetState(PersonalizationScope scope, string[] paths, string[] usernames) {}
	public virtual PersonalizationScope DetermineInitialScope(WebPartManager webPartManager, PersonalizationState loadedState) {}
	public virtual System.Collections.IDictionary DetermineUserCapabilities(WebPartManager webPartManager) {}
	public virtual PersonalizationState LoadPersonalizationState(WebPartManager webPartManager, bool ignoreCurrentUser) {}
	public virtual void ResetPersonalizationState(WebPartManager webPartManager) {}
	public virtual void SavePersonalizationState(PersonalizationState state) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationName { get{} set{} }
	public string Name { get{} }
	public string Description { get{} }
}

