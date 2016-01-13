public class PersonalizationProvider : System.Configuration.Provider.ProviderBase
{

	// Methods
	public virtual PersonalizationScope DetermineInitialScope(WebPartManager webPartManager, PersonalizationState loadedState) {}
	public virtual System.Collections.IDictionary DetermineUserCapabilities(WebPartManager webPartManager) {}
	public abstract virtual PersonalizationStateInfoCollection FindState(PersonalizationScope scope, PersonalizationStateQuery query, int pageIndex, int pageSizeout , System.Int32& totalRecords) {}
	public abstract virtual int GetCountOfState(PersonalizationScope scope, PersonalizationStateQuery query) {}
	public virtual PersonalizationState LoadPersonalizationState(WebPartManager webPartManager, bool ignoreCurrentUser) {}
	public virtual void ResetPersonalizationState(WebPartManager webPartManager) {}
	public abstract virtual int ResetState(PersonalizationScope scope, string[] paths, string[] usernames) {}
	public abstract virtual int ResetUserState(string path, System.DateTime userInactiveSinceDate) {}
	public virtual void SavePersonalizationState(PersonalizationState state) {}
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection config) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationName { get{} set{} }
	public string Name { get{} }
	public string Description { get{} }
}

