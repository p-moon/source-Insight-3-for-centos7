public class Configuration
{

	// Methods
	public ConfigurationSection GetSection(string sectionName) {}
	public ConfigurationSectionGroup GetSectionGroup(string sectionGroupName) {}
	public void Save() {}
	public void Save(ConfigurationSaveMode saveMode) {}
	public void Save(ConfigurationSaveMode saveMode, bool forceSaveAll) {}
	public void SaveAs(string filename) {}
	public void SaveAs(string filename, ConfigurationSaveMode saveMode) {}
	public void SaveAs(string filename, ConfigurationSaveMode saveMode, bool forceSaveAll) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AppSettingsSection AppSettings { get{} }
	public ConnectionStringsSection ConnectionStrings { get{} }
	public string FilePath { get{} }
	public bool HasFile { get{} }
	public ConfigurationLocationCollection Locations { get{} }
	public ContextInformation EvaluationContext { get{} }
	public ConfigurationSectionGroup RootSectionGroup { get{} }
	public ConfigurationSectionCollection Sections { get{} }
	public ConfigurationSectionGroupCollection SectionGroups { get{} }
	public bool NamespaceDeclared { get{} set{} }
}

