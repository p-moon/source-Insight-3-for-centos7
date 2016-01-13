public class Operators
{

	// Methods
	public static object CompareObjectEqual(object Left, object Right, bool TextCompare) {}
	public static bool ConditionalCompareObjectEqual(object Left, object Right, bool TextCompare) {}
	public static object CompareObjectNotEqual(object Left, object Right, bool TextCompare) {}
	public static bool ConditionalCompareObjectNotEqual(object Left, object Right, bool TextCompare) {}
	public static object CompareObjectLess(object Left, object Right, bool TextCompare) {}
	public static bool ConditionalCompareObjectLess(object Left, object Right, bool TextCompare) {}
	public static object CompareObjectLessEqual(object Left, object Right, bool TextCompare) {}
	public static bool ConditionalCompareObjectLessEqual(object Left, object Right, bool TextCompare) {}
	public static object CompareObjectGreaterEqual(object Left, object Right, bool TextCompare) {}
	public static bool ConditionalCompareObjectGreaterEqual(object Left, object Right, bool TextCompare) {}
	public static object CompareObjectGreater(object Left, object Right, bool TextCompare) {}
	public static bool ConditionalCompareObjectGreater(object Left, object Right, bool TextCompare) {}
	public static int CompareObject(object Left, object Right, bool TextCompare) {}
	public static int CompareString(string Left, string Right, bool TextCompare) {}
	public static object PlusObject(object Operand) {}
	public static object NegateObject(object Operand) {}
	public static object NotObject(object Operand) {}
	public static object AndObject(object Left, object Right) {}
	public static object OrObject(object Left, object Right) {}
	public static object XorObject(object Left, object Right) {}
	public static object AddObject(object Left, object Right) {}
	public static object SubtractObject(object Left, object Right) {}
	public static object MultiplyObject(object Left, object Right) {}
	public static object DivideObject(object Left, object Right) {}
	public static object ExponentObject(object Left, object Right) {}
	public static object ModObject(object Left, object Right) {}
	public static object IntDivideObject(object Left, object Right) {}
	public static object LeftShiftObject(object Operand, object Amount) {}
	public static object RightShiftObject(object Operand, object Amount) {}
	public static object LikeObject(object Source, object Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) {}
	public static bool LikeString(string Source, string Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) {}
	public static object ConcatenateObject(object Left, object Right) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

