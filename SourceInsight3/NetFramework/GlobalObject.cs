public class GlobalObject
{

	// Methods
	public static void CollectGarbage() {}
	public static string decodeURI(object encodedURI) {}
	public static string decodeURIComponent(object encodedURI) {}
	public static string encodeURI(object uri) {}
	public static string encodeURIComponent(object uriComponent) {}
	public static string escape(object string) {}
	public static object eval(object x) {}
	public static object GetObject(object moniker, object progId) {}
	public static bool isNaN(object num) {}
	public static bool isFinite(double number) {}
	public static double parseFloat(object string) {}
	public static double parseInt(object string, object radix) {}
	public static string ScriptEngine() {}
	public static int ScriptEngineBuildVersion() {}
	public static int ScriptEngineMajorVersion() {}
	public static int ScriptEngineMinorVersion() {}
	public static string unescape(object string) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public Empty undefined;
	public double Infinity;
	public double NaN;

	// Properties
	public ActiveXObjectConstructor ActiveXObject { get{} }
	public ArrayConstructor Array { get{} }
	public BooleanConstructor Boolean { get{} }
	public Type boolean { get{} }
	public Type byte { get{} }
	public Type char { get{} }
	public DateConstructor Date { get{} }
	public Type decimal { get{} }
	public Type double { get{} }
	public EnumeratorConstructor Enumerator { get{} }
	public ErrorConstructor Error { get{} }
	public ErrorConstructor EvalError { get{} }
	public Type float { get{} }
	public FunctionConstructor Function { get{} }
	public Type int { get{} }
	public Type long { get{} }
	public MathObject Math { get{} }
	public NumberConstructor Number { get{} }
	public ObjectConstructor Object { get{} }
	public ErrorConstructor RangeError { get{} }
	public ErrorConstructor ReferenceError { get{} }
	public RegExpConstructor RegExp { get{} }
	public Type sbyte { get{} }
	public Type short { get{} }
	public StringConstructor String { get{} }
	public ErrorConstructor SyntaxError { get{} }
	public ErrorConstructor TypeError { get{} }
	public ErrorConstructor URIError { get{} }
	public VBArrayConstructor VBArray { get{} }
	public Type void { get{} }
	public Type uint { get{} }
	public Type ulong { get{} }
	public Type ushort { get{} }
}

