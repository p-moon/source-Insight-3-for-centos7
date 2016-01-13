public class PropertyTab : System.ComponentModel.IExtenderProvider
{

	// Methods
	public virtual bool CanExtend(object extendee) {}
	public virtual void Dispose() {}
	public virtual System.ComponentModel.PropertyDescriptor GetDefaultProperty(object component) {}
	public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties(object component) {}
	public abstract virtual System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes) {}
	public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object component, System.Attribute[] attributes) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Bitmap Bitmap { get{} }
	public object[] Components { get{} set{} }
	public string TabName { get{} }
	public string HelpKeyword { get{} }
}

