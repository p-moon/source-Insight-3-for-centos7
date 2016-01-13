public class GC
{

	// Methods
	public static int GetGeneration(object obj) {}
	public static void KeepAlive(object obj) {}
	public static void WaitForPendingFinalizers() {}
	public static void SuppressFinalize(object obj) {}
	public static void AddMemoryPressure(long bytesAllocated) {}
	public static void RemoveMemoryPressure(long bytesAllocated) {}
	public static void Collect(int generation) {}
	public static void Collect() {}
	public static void Collect(int generation, GCCollectionMode mode) {}
	public static int CollectionCount(int generation) {}
	public static int GetGeneration(WeakReference wo) {}
	public static void ReRegisterForFinalize(object obj) {}
	public static long GetTotalMemory(bool forceFullCollection) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int MaxGeneration { get{} }
}

