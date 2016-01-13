public class Instrumentation
{

	// Constructors
	public Instrumentation() {}

	// Methods
	public static void RegisterAssembly(System.Reflection.Assembly assemblyToRegister) {}
	public static bool IsAssemblyRegistered(System.Reflection.Assembly assemblyToRegister) {}
	public static void Fire(object eventData) {}
	public static void Publish(object instanceData) {}
	public static void Revoke(object instanceData) {}
	public static void SetBatchSize(Type instrumentationClass, int batchSize) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

