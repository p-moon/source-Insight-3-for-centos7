public class IsolatedStorageFile : IsolatedStorage, System.IDisposable
{

	// Methods
	public static IsolatedStorageFile GetUserStoreForDomain() {}
	public static IsolatedStorageFile GetUserStoreForAssembly() {}
	public static IsolatedStorageFile GetUserStoreForApplication() {}
	public static IsolatedStorageFile GetMachineStoreForDomain() {}
	public static IsolatedStorageFile GetMachineStoreForAssembly() {}
	public static IsolatedStorageFile GetMachineStoreForApplication() {}
	public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, Type domainEvidenceType, Type assemblyEvidenceType) {}
	public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, object domainIdentity, object assemblyIdentity) {}
	public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, System.Security.Policy.Evidence domainEvidence, Type domainEvidenceType, System.Security.Policy.Evidence assemblyEvidence, Type assemblyEvidenceType) {}
	public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, Type applicationEvidenceType) {}
	public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, object applicationIdentity) {}
	public void DeleteFile(string file) {}
	public void CreateDirectory(string dir) {}
	public void DeleteDirectory(string dir) {}
	public string[] GetFileNames(string searchPattern) {}
	public string[] GetDirectoryNames(string searchPattern) {}
	public virtual void Remove() {}
	public void Close() {}
	public virtual void Dispose() {}
	public static void Remove(IsolatedStorageScope scope) {}
	public static System.Collections.IEnumerator GetEnumerator(IsolatedStorageScope scope) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ulong CurrentSize { get{} }
	public ulong MaximumSize { get{} }
	public object DomainIdentity { get{} }
	public object ApplicationIdentity { get{} }
	public object AssemblyIdentity { get{} }
	public IsolatedStorageScope Scope { get{} }
}

