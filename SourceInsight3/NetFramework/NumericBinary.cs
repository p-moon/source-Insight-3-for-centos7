public class NumericBinary : BinaryOp
{

	// Constructors
	public NumericBinary(int operatorTok) {}

	// Methods
	public object EvaluateNumericBinary(object v1, object v2) {}
	public static object DoOp(object v1, object v2, JSToken operatorTok) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

