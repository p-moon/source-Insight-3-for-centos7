public class BuildSettings : IBuildSettings
{

	// Constructors
	public BuildSettings() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationName { get{} set{} }
	public string ApplicationFile { get{} set{} }
	public string ApplicationUrl { get{} set{} }
	public ComponentsLocation ComponentsLocation { get{} set{} }
	public string ComponentsUrl { get{} set{} }
	public bool CopyComponents { get{} set{} }
	public int LCID { get{} set{} }
	public int FallbackLCID { get{} set{} }
	public string OutputPath { get{} set{} }
	public ProductBuilderCollection ProductBuilders { get{} }
	public string SupportUrl { get{} set{} }
	public bool Validate { get{} set{} }
}

