public interface IBuildSettings
{

	// Properties
	public string ApplicationName { get{} set{} }
	public string ApplicationFile { get{} set{} }
	public string ApplicationUrl { get{} set{} }
	public string ComponentsUrl { get{} set{} }
	public bool CopyComponents { get{} set{} }
	public int LCID { get{} set{} }
	public int FallbackLCID { get{} set{} }
	public string OutputPath { get{} set{} }
	public ProductBuilderCollection ProductBuilders { get{} }
	public bool Validate { get{} set{} }
	public ComponentsLocation ComponentsLocation { get{} set{} }
	public string SupportUrl { get{} set{} }
}

