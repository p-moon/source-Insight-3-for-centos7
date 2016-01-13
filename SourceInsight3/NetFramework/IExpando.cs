public interface IExpando : System.Reflection.IReflect
{

	// Methods
	public abstract virtual System.Reflection.FieldInfo AddField(string name) {}
	public abstract virtual System.Reflection.PropertyInfo AddProperty(string name) {}
	public abstract virtual System.Reflection.MethodInfo AddMethod(string name, System.Delegate method) {}
	public abstract virtual void RemoveMember(System.Reflection.MemberInfo m) {}
}

