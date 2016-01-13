public class FileVersionInfo
{

	// Methods
	public static FileVersionInfo GetVersionInfo(string fileName) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Comments { get{} }
	public string CompanyName { get{} }
	public int FileBuildPart { get{} }
	public string FileDescription { get{} }
	public int FileMajorPart { get{} }
	public int FileMinorPart { get{} }
	public string FileName { get{} }
	public int FilePrivatePart { get{} }
	public string FileVersion { get{} }
	public string InternalName { get{} }
	public bool IsDebug { get{} }
	public bool IsPatched { get{} }
	public bool IsPrivateBuild { get{} }
	public bool IsPreRelease { get{} }
	public bool IsSpecialBuild { get{} }
	public string Language { get{} }
	public string LegalCopyright { get{} }
	public string LegalTrademarks { get{} }
	public string OriginalFilename { get{} }
	public string PrivateBuild { get{} }
	public int ProductBuildPart { get{} }
	public int ProductMajorPart { get{} }
	public int ProductMinorPart { get{} }
	public string ProductName { get{} }
	public int ProductPrivatePart { get{} }
	public string ProductVersion { get{} }
	public string SpecialBuild { get{} }
}

