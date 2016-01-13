public class ManifestReader
{

	// Methods
	public static Manifest ReadManifest(string path, bool preserveStream) {}
	public static Manifest ReadManifest(string manifestType, string path, bool preserveStream) {}
	public static Manifest ReadManifest(System.IO.Stream input, bool preserveStream) {}
	public static Manifest ReadManifest(string manifestType, System.IO.Stream input, bool preserveStream) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

