public class UserSettingsGroup : ConfigurationSectionGroup
{

	// Constructors
	public UserSettingsGroup() {}

	// Methods
	public void ForceDeclaration() {}
	public void ForceDeclaration(bool force) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsDeclared { get{} }
	public bool IsDeclarationRequired { get{} }
	public string SectionGroupName { get{} }
	public string Name { get{} }
	public string Type { get{} set{} }
	public ConfigurationSectionCollection Sections { get{} }
	public ConfigurationSectionGroupCollection SectionGroups { get{} }
}

