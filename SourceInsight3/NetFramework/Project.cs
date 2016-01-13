public class Project
{

	// Constructors
	public Project(Engine engine) {}
	public Project() {}

	// Methods
	public string GetEvaluatedProperty(string propertyName) {}
	public void MarkProjectAsDirty() {}
	public string[] GetConditionedPropertyValues(string propertyName) {}
	public BuildItemGroup GetEvaluatedItemsByName(string itemName) {}
	public BuildItemGroup GetEvaluatedItemsByNameIgnoringCondition(string itemName) {}
	public void ResetBuildStatus() {}
	public void Load(string projectFileName) {}
	public void Load(System.IO.TextReader textReader) {}
	public void LoadXml(string projectXml) {}
	public void Save(string projectFileName) {}
	public void Save(string projectFileName, System.Text.Encoding encoding) {}
	public void Save(System.IO.TextWriter textWriter) {}
	public BuildPropertyGroup AddNewPropertyGroup(bool insertAtEndOfProject) {}
	public void SetProperty(string propertyName, string propertyValue) {}
	public void SetProperty(string propertyName, string propertyValue, string condition) {}
	public void SetImportedProperty(string propertyName, string propertyValue, string condition, Project importProject) {}
	public void SetProperty(string propertyName, string propertyValue, string condition, PropertyPosition position) {}
	public void SetProperty(string propertyName, string propertyValue, string condition, PropertyPosition position, bool treatPropertyValueAsLiteral) {}
	public void SetImportedProperty(string propertyName, string propertyValue, string condition, Project importedProject, PropertyPosition position) {}
	public void SetImportedProperty(string propertyName, string propertyValue, string condition, Project importedProject, PropertyPosition position, bool treatPropertyValueAsLiteral) {}
	public void RemoveAllPropertyGroups() {}
	public void RemovePropertyGroupsWithMatchingCondition(string matchCondition) {}
	public void RemovePropertyGroup(BuildPropertyGroup propertyGroupToRemove) {}
	public BuildItemGroup AddNewItemGroup() {}
	public BuildItem AddNewItem(string itemName, string itemInclude, bool treatItemIncludeAsLiteral) {}
	public BuildItem AddNewItem(string itemName, string itemInclude) {}
	public void RemoveAllItemGroups() {}
	public void RemoveItemGroupsWithMatchingCondition(string matchCondition) {}
	public void RemoveItemGroup(BuildItemGroup itemGroupToRemove) {}
	public void RemoveItemsByName(string itemName) {}
	public void RemoveItem(BuildItem itemToRemove) {}
	public void AddNewImport(string projectFile, string condition) {}
	public void AddNewUsingTaskFromAssemblyName(string taskName, string assemblyName) {}
	public void AddNewUsingTaskFromAssemblyFile(string taskName, string assemblyFile) {}
	public void SetProjectExtensions(string id, string content) {}
	public string GetProjectExtensions(string id) {}
	public bool Build() {}
	public bool Build(string targetName) {}
	public bool Build(string[] targetNames) {}
	public bool Build(string[] targetNames, System.Collections.IDictionary targetOutputs) {}
	public bool Build(string[] targetNames, System.Collections.IDictionary targetOutputs, BuildSettings buildFlags) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string FullFileName { get{} set{} }
	public string DefaultTargets { get{} set{} }
	public string InitialTargets { get{} set{} }
	public Engine ParentEngine { get{} }
	public bool IsValidated { get{} set{} }
	public string SchemaFile { get{} set{} }
	public bool BuildEnabled { get{} set{} }
	public BuildPropertyGroup GlobalProperties { get{} set{} }
	public BuildPropertyGroup EvaluatedProperties { get{} }
	public BuildItemGroup EvaluatedItems { get{} }
	public BuildItemGroup EvaluatedItemsIgnoringCondition { get{} }
	public BuildPropertyGroupCollection PropertyGroups { get{} }
	public TargetCollection Targets { get{} }
	public UsingTaskCollection UsingTasks { get{} }
	public ImportCollection Imports { get{} }
	public BuildItemGroupCollection ItemGroups { get{} }
	public string Xml { get{} }
	public bool IsDirty { get{} }
	public System.DateTime TimeOfLastDirty { get{} }
	public System.Text.Encoding Encoding { get{} }
}

