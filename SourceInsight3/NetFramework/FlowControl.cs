public class FlowControl
{

	// Methods
	public static bool ForNextCheckR4(float count, float limit, float StepValue) {}
	public static bool ForNextCheckR8(double count, double limit, double StepValue) {}
	public static bool ForNextCheckDec(decimal count, decimal limit, decimal StepValue) {}
	public static bool ForLoopInitObj(object Counter, object Start, object Limit, object StepValue, System.Object& LoopForResult, System.Object& CounterResult) {}
	public static bool ForNextCheckObj(object Counter, object LoopObj, System.Object& CounterResult) {}
	public static System.Collections.IEnumerator ForEachInArr(System.Array ary) {}
	public static System.Collections.IEnumerator ForEachInObj(object obj) {}
	public static bool ForEachNextObj(System.Object& obj, System.Collections.IEnumerator enumerator) {}
	public static void CheckForSyncLockOnValueType(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

