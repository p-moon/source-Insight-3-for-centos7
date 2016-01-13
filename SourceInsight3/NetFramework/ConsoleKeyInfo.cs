public class ConsoleKeyInfo : ValueType
{

	// Constructors
	public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) {}

	// Methods
	public virtual bool Equals(object value) {}
	public bool Equals(ConsoleKeyInfo obj) {}
	public static bool op_Equality(ConsoleKeyInfo a, ConsoleKeyInfo b) {}
	public static bool op_Inequality(ConsoleKeyInfo a, ConsoleKeyInfo b) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public char KeyChar { get{} }
	public ConsoleKey Key { get{} }
	public ConsoleModifiers Modifiers { get{} }
}

