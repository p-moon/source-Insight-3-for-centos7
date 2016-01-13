public class Options
{

	// Constructors
	public Options() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string outputName;
	public string outputDirectory;
	public byte[] publicKey;
	public System.Reflection.StrongNameKeyPair keyPair;
	public string keyFile;
	public string keyContainer;
	public bool genSources;
	public bool msBuildErrors;
	public bool noLogo;
	public bool silentMode;
	public bool verboseMode;
	public bool delaySign;
	public bool overwriteRCW;
	public IReferenceResolver references;
}

