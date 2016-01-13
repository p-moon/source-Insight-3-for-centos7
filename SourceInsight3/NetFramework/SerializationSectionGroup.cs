public class SerializationSectionGroup : System.Configuration.ConfigurationSectionGroup
{

	// Constructors
	public SerializationSectionGroup() {}

	// Methods
	public void ForceDeclaration() {}
	public void ForceDeclaration(bool force) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SchemaImporterExtensionsSection SchemaImporterExtensions { get{} }
	public DateTimeSerializationSection DateTimeSerialization { get{} }
	public XmlSerializerSection XmlSerializer { get{} }
	public bool IsDeclared { get{} }
	public bool IsDeclarationRequired { get{} }
	public string SectionGroupName { get{} }
	public string Name { get{} }
	public string Type { get{} set{} }
	public System.Configuration.ConfigurationSectionCollection Sections { get{} }
	public System.Configuration.ConfigurationSectionGroupCollection SectionGroups { get{} }
}

