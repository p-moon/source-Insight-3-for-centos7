public class TypeDescriptor
{

	// Methods
	public static TypeConverter GetConverter(Type type) {}
	public static TypeDescriptionProvider AddAttributes(Type type, System.Attribute[] attributes) {}
	public static TypeDescriptionProvider AddAttributes(object instance, System.Attribute[] attributes) {}
	public static void AddEditorTable(Type editorBaseType, System.Collections.Hashtable table) {}
	public static void AddProvider(TypeDescriptionProvider provider, Type type) {}
	public static void AddProvider(TypeDescriptionProvider provider, object instance) {}
	public static void CreateAssociation(object primary, object secondary) {}
	public static System.ComponentModel.Design.IDesigner CreateDesigner(IComponent component, Type designerBaseType) {}
	public static EventDescriptor CreateEvent(Type componentType, string name, Type type, System.Attribute[] attributes) {}
	public static EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, System.Attribute[] attributes) {}
	public static object CreateInstance(System.IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) {}
	public static PropertyDescriptor CreateProperty(Type componentType, string name, Type type, System.Attribute[] attributes) {}
	public static PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, System.Attribute[] attributes) {}
	public static object GetAssociation(Type type, object primary) {}
	public static AttributeCollection GetAttributes(Type componentType) {}
	public static AttributeCollection GetAttributes(object component) {}
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) {}
	public static string GetClassName(object component) {}
	public static string GetClassName(object component, bool noCustomTypeDesc) {}
	public static string GetClassName(Type componentType) {}
	public static string GetComponentName(object component) {}
	public static string GetComponentName(object component, bool noCustomTypeDesc) {}
	public static TypeConverter GetConverter(object component) {}
	public static TypeConverter GetConverter(object component, bool noCustomTypeDesc) {}
	public static EventDescriptor GetDefaultEvent(Type componentType) {}
	public static EventDescriptor GetDefaultEvent(object component) {}
	public static EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc) {}
	public static PropertyDescriptor GetDefaultProperty(Type componentType) {}
	public static PropertyDescriptor GetDefaultProperty(object component) {}
	public static PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc) {}
	public static object GetEditor(object component, Type editorBaseType) {}
	public static object GetEditor(object component, Type editorBaseType, bool noCustomTypeDesc) {}
	public static object GetEditor(Type type, Type editorBaseType) {}
	public static EventDescriptorCollection GetEvents(Type componentType) {}
	public static EventDescriptorCollection GetEvents(Type componentType, System.Attribute[] attributes) {}
	public static EventDescriptorCollection GetEvents(object component) {}
	public static EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc) {}
	public static EventDescriptorCollection GetEvents(object component, System.Attribute[] attributes) {}
	public static EventDescriptorCollection GetEvents(object component, System.Attribute[] attributes, bool noCustomTypeDesc) {}
	public static string GetFullComponentName(object component) {}
	public static PropertyDescriptorCollection GetProperties(Type componentType) {}
	public static PropertyDescriptorCollection GetProperties(Type componentType, System.Attribute[] attributes) {}
	public static PropertyDescriptorCollection GetProperties(object component) {}
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) {}
	public static PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes) {}
	public static PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes, bool noCustomTypeDesc) {}
	public static TypeDescriptionProvider GetProvider(Type type) {}
	public static TypeDescriptionProvider GetProvider(object instance) {}
	public static Type GetReflectionType(Type type) {}
	public static Type GetReflectionType(object instance) {}
	public static void Refresh(object component) {}
	public static void Refresh(Type type) {}
	public static void Refresh(System.Reflection.Module module) {}
	public static void Refresh(System.Reflection.Assembly assembly) {}
	public static void RemoveAssociation(object primary, object secondary) {}
	public static void RemoveAssociations(object primary) {}
	public static void RemoveProvider(TypeDescriptionProvider provider, Type type) {}
	public static void RemoveProvider(TypeDescriptionProvider provider, object instance) {}
	public static void SortDescriptorArray(System.Collections.IList infos) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IComNativeDescriptorHandler ComNativeDescriptorHandler { get{} set{} }
	public Type ComObjectType { get{} }

	// Events
	public event System.ComponentModel.RefreshEventHandler Refreshed;
}

