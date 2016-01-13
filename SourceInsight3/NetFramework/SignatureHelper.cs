public class SignatureHelper : System.Runtime.InteropServices._SignatureHelper
{

	// Methods
	public static SignatureHelper GetMethodSigHelper(System.Reflection.Module mod, Type returnType, Type[] parameterTypes) {}
	public static SignatureHelper GetMethodSigHelper(System.Reflection.Module mod, System.Reflection.CallingConventions callingConvention, Type returnType) {}
	public static SignatureHelper GetMethodSigHelper(System.Reflection.Module mod, System.Runtime.InteropServices.CallingConvention unmanagedCallConv, Type returnType) {}
	public static SignatureHelper GetLocalVarSigHelper() {}
	public static SignatureHelper GetMethodSigHelper(System.Reflection.CallingConventions callingConvention, Type returnType) {}
	public static SignatureHelper GetMethodSigHelper(System.Runtime.InteropServices.CallingConvention unmanagedCallingConvention, Type returnType) {}
	public static SignatureHelper GetLocalVarSigHelper(System.Reflection.Module mod) {}
	public static SignatureHelper GetFieldSigHelper(System.Reflection.Module mod) {}
	public static SignatureHelper GetPropertySigHelper(System.Reflection.Module mod, Type returnType, Type[] parameterTypes) {}
	public static SignatureHelper GetPropertySigHelper(System.Reflection.Module mod, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers) {}
	public static SignatureHelper GetPropertySigHelper(System.Reflection.Module mod, System.Reflection.CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers) {}
	public void AddArgument(Type clsArgument) {}
	public void AddArgument(Type argument, bool pinned) {}
	public void AddArguments(Type[] arguments, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers) {}
	public void AddArgument(Type argument, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers) {}
	public void AddSentinel() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public byte[] GetSignature() {}
	public virtual string ToString() {}
	public Type GetType() {}
}

