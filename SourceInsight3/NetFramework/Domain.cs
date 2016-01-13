public class Domain : ActiveDirectoryPartition, System.IDisposable
{

	// Methods
	public static Domain GetDomain(DirectoryContext context) {}
	public static Domain GetComputerDomain() {}
	public void RaiseDomainFunctionality(DomainMode domainMode) {}
	public DomainController FindDomainController() {}
	public DomainController FindDomainController(string siteName) {}
	public DomainController FindDomainController(LocatorOptions flag) {}
	public DomainController FindDomainController(string siteName, LocatorOptions flag) {}
	public DomainControllerCollection FindAllDomainControllers() {}
	public DomainControllerCollection FindAllDomainControllers(string siteName) {}
	public DomainControllerCollection FindAllDiscoverableDomainControllers() {}
	public DomainControllerCollection FindAllDiscoverableDomainControllers(string siteName) {}
	public virtual System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public TrustRelationshipInformationCollection GetAllTrustRelationships() {}
	public TrustRelationshipInformation GetTrustRelationship(string targetDomainName) {}
	public bool GetSelectiveAuthenticationStatus(string targetDomainName) {}
	public void SetSelectiveAuthenticationStatus(string targetDomainName, bool enable) {}
	public bool GetSidFilteringStatus(string targetDomainName) {}
	public void SetSidFilteringStatus(string targetDomainName, bool enable) {}
	public void DeleteLocalSideOfTrustRelationship(string targetDomainName) {}
	public void DeleteTrustRelationship(Domain targetDomain) {}
	public void VerifyOutboundTrustRelationship(string targetDomainName) {}
	public void VerifyTrustRelationship(Domain targetDomain, TrustDirection direction) {}
	public void CreateLocalSideOfTrustRelationship(string targetDomainName, TrustDirection direction, string trustPassword) {}
	public void CreateTrustRelationship(Domain targetDomain, TrustDirection direction) {}
	public void UpdateLocalSideOfTrustRelationship(string targetDomainName, string newTrustPassword) {}
	public void UpdateLocalSideOfTrustRelationship(string targetDomainName, TrustDirection newTrustDirection, string newTrustPassword) {}
	public void UpdateTrustRelationship(Domain targetDomain, TrustDirection newTrustDirection) {}
	public void RepairTrustRelationship(Domain targetDomain) {}
	public static Domain GetCurrentDomain() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Forest Forest { get{} }
	public DomainControllerCollection DomainControllers { get{} }
	public DomainCollection Children { get{} }
	public DomainMode DomainMode { get{} }
	public Domain Parent { get{} }
	public DomainController PdcRoleOwner { get{} }
	public DomainController RidRoleOwner { get{} }
	public DomainController InfrastructureRoleOwner { get{} }
	public string Name { get{} }
}

