public class Forest : System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public static Forest GetForest(DirectoryContext context) {}
	public void RaiseForestFunctionality(ForestMode forestMode) {}
	public virtual string ToString() {}
	public GlobalCatalog FindGlobalCatalog() {}
	public GlobalCatalog FindGlobalCatalog(string siteName) {}
	public GlobalCatalog FindGlobalCatalog(LocatorOptions flag) {}
	public GlobalCatalog FindGlobalCatalog(string siteName, LocatorOptions flag) {}
	public GlobalCatalogCollection FindAllGlobalCatalogs() {}
	public GlobalCatalogCollection FindAllGlobalCatalogs(string siteName) {}
	public GlobalCatalogCollection FindAllDiscoverableGlobalCatalogs() {}
	public GlobalCatalogCollection FindAllDiscoverableGlobalCatalogs(string siteName) {}
	public TrustRelationshipInformationCollection GetAllTrustRelationships() {}
	public ForestTrustRelationshipInformation GetTrustRelationship(string targetForestName) {}
	public bool GetSelectiveAuthenticationStatus(string targetForestName) {}
	public void SetSelectiveAuthenticationStatus(string targetForestName, bool enable) {}
	public bool GetSidFilteringStatus(string targetForestName) {}
	public void SetSidFilteringStatus(string targetForestName, bool enable) {}
	public void DeleteLocalSideOfTrustRelationship(string targetForestName) {}
	public void DeleteTrustRelationship(Forest targetForest) {}
	public void VerifyOutboundTrustRelationship(string targetForestName) {}
	public void VerifyTrustRelationship(Forest targetForest, TrustDirection direction) {}
	public void CreateLocalSideOfTrustRelationship(string targetForestName, TrustDirection direction, string trustPassword) {}
	public void CreateTrustRelationship(Forest targetForest, TrustDirection direction) {}
	public void UpdateLocalSideOfTrustRelationship(string targetForestName, string newTrustPassword) {}
	public void UpdateLocalSideOfTrustRelationship(string targetForestName, TrustDirection newTrustDirection, string newTrustPassword) {}
	public void UpdateTrustRelationship(Forest targetForest, TrustDirection newTrustDirection) {}
	public void RepairTrustRelationship(Forest targetForest) {}
	public static Forest GetCurrentForest() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public ReadOnlySiteCollection Sites { get{} }
	public DomainCollection Domains { get{} }
	public GlobalCatalogCollection GlobalCatalogs { get{} }
	public ApplicationPartitionCollection ApplicationPartitions { get{} }
	public ForestMode ForestMode { get{} }
	public Domain RootDomain { get{} }
	public ActiveDirectorySchema Schema { get{} }
	public DomainController SchemaRoleOwner { get{} }
	public DomainController NamingRoleOwner { get{} }
}

