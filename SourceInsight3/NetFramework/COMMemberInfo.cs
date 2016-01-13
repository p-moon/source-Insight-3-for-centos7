public interface COMMemberInfo
{

	// Methods
	public abstract virtual object Call(System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] arguments, System.Globalization.CultureInfo culture) {}
	public abstract virtual object GetValue(System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture) {}
	public abstract virtual void SetValue(object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture) {}
}

