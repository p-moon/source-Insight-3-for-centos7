public interface ITypeResolutionService
{

	// Methods
	public abstract virtual System.Reflection.Assembly GetAssembly(System.Reflection.AssemblyName name) {}
	public abstract virtual System.Reflection.Assembly GetAssembly(System.Reflection.AssemblyName name, bool throwOnError) {}
	public abstract virtual Type GetType(string name) {}
	public abstract virtual Type GetType(string name, bool throwOnError) {}
	public abstract virtual Type GetType(string name, bool throwOnError, bool ignoreCase) {}
	public abstract virtual void ReferenceAssembly(System.Reflection.AssemblyName name) {}
	public abstract virtual string GetPathOfAssembly(System.Reflection.AssemblyName name) {}
}

