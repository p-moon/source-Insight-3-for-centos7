public class SectionInformation
{

	// Methods
	public void ForceDeclaration() {}
	public void ForceDeclaration(bool force) {}
	public void ProtectSection(string protectionProvider) {}
	public void UnprotectSection() {}
	public ConfigurationSection GetParentSection() {}
	public string GetRawXml() {}
	public void SetRawXml(string rawXml) {}
	public void RevertToParent() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string SectionName { get{} }
	public string Name { get{} }
	public ConfigurationAllowDefinition AllowDefinition { get{} set{} }
	public ConfigurationAllowExeDefinition AllowExeDefinition { get{} set{} }
	public OverrideMode OverrideModeDefault { get{} set{} }
	public bool AllowLocation { get{} set{} }
	public bool AllowOverride { get{} set{} }
	public OverrideMode OverrideMode { get{} set{} }
	public OverrideMode OverrideModeEffective { get{} }
	public string ConfigSource { get{} set{} }
	public bool InheritInChildApplications { get{} set{} }
	public bool IsDeclared { get{} }
	public bool IsDeclarationRequired { get{} }
	public bool IsLocked { get{} }
	public bool IsProtected { get{} }
	public ProtectedConfigurationProvider ProtectionProvider { get{} }
	public bool RestartOnExternalChanges { get{} set{} }
	public bool RequirePermission { get{} set{} }
	public string Type { get{} set{} }
	public bool ForceSave { get{} set{} }
}

