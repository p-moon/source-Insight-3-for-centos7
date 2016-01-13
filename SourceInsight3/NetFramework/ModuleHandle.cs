public class ModuleHandle : ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(ModuleHandle handle) {}
	public static bool op_Equality(ModuleHandle left, ModuleHandle right) {}
	public static bool op_Inequality(ModuleHandle left, ModuleHandle right) {}
	public RuntimeTypeHandle GetRuntimeTypeHandleFromMetadataToken(int typeToken) {}
	public RuntimeTypeHandle ResolveTypeHandle(int typeToken) {}
	public RuntimeTypeHandle ResolveTypeHandle(int typeToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext) {}
	public RuntimeMethodHandle GetRuntimeMethodHandleFromMetadataToken(int methodToken) {}
	public RuntimeMethodHandle ResolveMethodHandle(int methodToken) {}
	public RuntimeMethodHandle ResolveMethodHandle(int methodToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext) {}
	public RuntimeFieldHandle GetRuntimeFieldHandleFromMetadataToken(int fieldToken) {}
	public RuntimeFieldHandle ResolveFieldHandle(int fieldToken) {}
	public RuntimeFieldHandle ResolveFieldHandle(int fieldToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public ModuleHandle EmptyHandle;

	// Properties
	public int MDStreamVersion { get{} }
}

