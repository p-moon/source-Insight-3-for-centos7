public class ListBindingHelper
{

	// Methods
	public static object GetList(object list) {}
	public static object GetList(object dataSource, string dataMember) {}
	public static string GetListName(object list, System.ComponentModel.PropertyDescriptor[] listAccessors) {}
	public static System.ComponentModel.PropertyDescriptorCollection GetListItemProperties(object list) {}
	public static System.ComponentModel.PropertyDescriptorCollection GetListItemProperties(object list, System.ComponentModel.PropertyDescriptor[] listAccessors) {}
	public static System.ComponentModel.PropertyDescriptorCollection GetListItemProperties(object dataSource, string dataMember, System.ComponentModel.PropertyDescriptor[] listAccessors) {}
	public static Type GetListItemType(object list) {}
	public static Type GetListItemType(object dataSource, string dataMember) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

