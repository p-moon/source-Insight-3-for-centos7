public class ILGenerator : System.Runtime.InteropServices._ILGenerator
{

	// Methods
	public virtual void Emit(OpCode opcode) {}
	public virtual void Emit(OpCode opcode, byte arg) {}
	public void Emit(OpCode opcode, System.SByte arg) {}
	public virtual void Emit(OpCode opcode, short arg) {}
	public virtual void Emit(OpCode opcode, int arg) {}
	public virtual void Emit(OpCode opcode, System.Reflection.MethodInfo meth) {}
	public virtual void EmitCalli(OpCode opcode, System.Reflection.CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type[] optionalParameterTypes) {}
	public virtual void EmitCalli(OpCode opcode, System.Runtime.InteropServices.CallingConvention unmanagedCallConv, Type returnType, Type[] parameterTypes) {}
	public virtual void EmitCall(OpCode opcode, System.Reflection.MethodInfo methodInfo, Type[] optionalParameterTypes) {}
	public virtual void Emit(OpCode opcode, SignatureHelper signature) {}
	public virtual void Emit(OpCode opcode, System.Reflection.ConstructorInfo con) {}
	public virtual void Emit(OpCode opcode, Type cls) {}
	public virtual void Emit(OpCode opcode, long arg) {}
	public virtual void Emit(OpCode opcode, float arg) {}
	public virtual void Emit(OpCode opcode, double arg) {}
	public virtual void Emit(OpCode opcode, Label label) {}
	public virtual void Emit(OpCode opcode, Label[] labels) {}
	public virtual void Emit(OpCode opcode, System.Reflection.FieldInfo field) {}
	public virtual void Emit(OpCode opcode, string str) {}
	public virtual void Emit(OpCode opcode, LocalBuilder local) {}
	public virtual Label BeginExceptionBlock() {}
	public virtual void EndExceptionBlock() {}
	public virtual void BeginExceptFilterBlock() {}
	public virtual void BeginCatchBlock(Type exceptionType) {}
	public virtual void BeginFaultBlock() {}
	public virtual void BeginFinallyBlock() {}
	public virtual Label DefineLabel() {}
	public virtual void MarkLabel(Label loc) {}
	public virtual void ThrowException(Type excType) {}
	public virtual void EmitWriteLine(string value) {}
	public virtual void EmitWriteLine(LocalBuilder localBuilder) {}
	public virtual void EmitWriteLine(System.Reflection.FieldInfo fld) {}
	public virtual LocalBuilder DeclareLocal(Type localType) {}
	public virtual LocalBuilder DeclareLocal(Type localType, bool pinned) {}
	public virtual void UsingNamespace(string usingNamespace) {}
	public virtual void MarkSequencePoint(System.Diagnostics.SymbolStore.ISymbolDocumentWriter document, int startLine, int startColumn, int endLine, int endColumn) {}
	public virtual void BeginScope() {}
	public virtual void EndScope() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

