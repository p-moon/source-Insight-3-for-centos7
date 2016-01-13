public class ManifestResourceInfo
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Assembly ReferencedAssembly { get{} }
	public string FileName { get{} }
	public ResourceLocation ResourceLocation { get{} }
}

