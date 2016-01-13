public interface IEventBindingService
{

	// Methods
	public abstract virtual string CreateUniqueMethodName(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e) {}
	public abstract virtual System.Collections.ICollection GetCompatibleMethods(System.ComponentModel.EventDescriptor e) {}
	public abstract virtual System.ComponentModel.EventDescriptor GetEvent(System.ComponentModel.PropertyDescriptor property) {}
	public abstract virtual System.ComponentModel.PropertyDescriptorCollection GetEventProperties(System.ComponentModel.EventDescriptorCollection events) {}
	public abstract virtual System.ComponentModel.PropertyDescriptor GetEventProperty(System.ComponentModel.EventDescriptor e) {}
	public abstract virtual bool ShowCode() {}
	public abstract virtual bool ShowCode(int lineNumber) {}
	public abstract virtual bool ShowCode(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e) {}
}

