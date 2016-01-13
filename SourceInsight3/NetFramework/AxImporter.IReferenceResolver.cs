public interface IReferenceResolver
{

	// Methods
	public abstract virtual string ResolveManagedReference(string assemName) {}
	public abstract virtual string ResolveComReference(System.Runtime.InteropServices.UCOMITypeLib typeLib) {}
	public abstract virtual string ResolveComReference(System.Reflection.AssemblyName name) {}
	public abstract virtual string ResolveActiveXReference(System.Runtime.InteropServices.UCOMITypeLib typeLib) {}
}

