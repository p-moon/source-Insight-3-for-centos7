public class EventsTab : PropertyTab, System.ComponentModel.IExtenderProvider
{

	// Constructors
	public EventsTab(System.IServiceProvider sp) {}

	// Methods
	public virtual bool CanExtend(object extendee) {}
	public virtual System.ComponentModel.PropertyDescriptor GetDefaultProperty(object obj) {}
	public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes) {}
	public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object component, System.Attribute[] attributes) {}
	public virtual void Dispose() {}
	public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties(object component) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string TabName { get{} }
	public string HelpKeyword { get{} }
	public System.Drawing.Bitmap Bitmap { get{} }
	public object[] Components { get{} set{} }
}

