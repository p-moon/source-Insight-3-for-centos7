public class OpCode : System.ValueType
{

	// Methods
	public virtual bool Equals(object obj) {}
	public bool Equals(OpCode obj) {}
	public static bool op_Equality(OpCode a, OpCode b) {}
	public static bool op_Inequality(OpCode a, OpCode b) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public OperandType OperandType { get{} }
	public FlowControl FlowControl { get{} }
	public OpCodeType OpCodeType { get{} }
	public StackBehaviour StackBehaviourPop { get{} }
	public StackBehaviour StackBehaviourPush { get{} }
	public int Size { get{} }
	public short Value { get{} }
	public string Name { get{} }
}

