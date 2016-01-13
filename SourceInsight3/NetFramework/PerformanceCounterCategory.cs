public class PerformanceCounterCategory
{

	// Constructors
	public PerformanceCounterCategory() {}
	public PerformanceCounterCategory(string categoryName) {}
	public PerformanceCounterCategory(string categoryName, string machineName) {}

	// Methods
	public bool CounterExists(string counterName) {}
	public static bool CounterExists(string counterName, string categoryName) {}
	public static bool CounterExists(string counterName, string categoryName, string machineName) {}
	public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, string counterName, string counterHelp) {}
	public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, string counterName, string counterHelp) {}
	public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, CounterCreationDataCollection counterData) {}
	public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, CounterCreationDataCollection counterData) {}
	public static void Delete(string categoryName) {}
	public static bool Exists(string categoryName) {}
	public static bool Exists(string categoryName, string machineName) {}
	public PerformanceCounter[] GetCounters() {}
	public PerformanceCounter[] GetCounters(string instanceName) {}
	public static PerformanceCounterCategory[] GetCategories() {}
	public static PerformanceCounterCategory[] GetCategories(string machineName) {}
	public string[] GetInstanceNames() {}
	public bool InstanceExists(string instanceName) {}
	public static bool InstanceExists(string instanceName, string categoryName) {}
	public static bool InstanceExists(string instanceName, string categoryName, string machineName) {}
	public InstanceDataCollectionCollection ReadCategory() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string CategoryName { get{} set{} }
	public string CategoryHelp { get{} }
	public PerformanceCounterCategoryType CategoryType { get{} }
	public string MachineName { get{} set{} }
}

