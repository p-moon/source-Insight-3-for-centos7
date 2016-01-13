public class SettingChangingEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public SettingChangingEventArgs(string settingName, string settingClass, string settingKey, object newValue, bool cancel) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object NewValue { get{} }
	public string SettingClass { get{} }
	public string SettingName { get{} }
	public string SettingKey { get{} }
	public bool Cancel { get{} set{} }
}

