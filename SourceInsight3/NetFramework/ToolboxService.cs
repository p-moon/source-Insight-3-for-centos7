public class ToolboxService : IToolboxService, System.ComponentModel.Design.IComponentDiscoveryService
{

	// Methods
	public static ToolboxItem GetToolboxItem(Type toolType) {}
	public static ToolboxItem GetToolboxItem(Type toolType, bool nonPublic) {}
	public static System.Collections.ICollection GetToolboxItems(System.Reflection.Assembly a, string newCodeBase) {}
	public static System.Collections.ICollection GetToolboxItems(System.Reflection.Assembly a, string newCodeBase, bool throwOnError) {}
	public static System.Collections.ICollection GetToolboxItems(System.Reflection.AssemblyName an) {}
	public static System.Collections.ICollection GetToolboxItems(System.Reflection.AssemblyName an, bool throwOnError) {}
	public static void UnloadToolboxItems() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

