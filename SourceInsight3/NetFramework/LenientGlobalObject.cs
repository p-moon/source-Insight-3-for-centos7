public class LenientGlobalObject : GlobalObject
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public object Infinity;
	public object NaN;
	public object undefined;
	public object decodeURI;
	public object decodeURIComponent;
	public object encodeURI;
	public object encodeURIComponent;
	public object escape;
	public object eval;
	public object isNaN;
	public object isFinite;
	public object parseInt;
	public object parseFloat;
	public object GetObject;
	public object ScriptEngine;
	public object ScriptEngineBuildVersion;
	public object ScriptEngineMajorVersion;
	public object ScriptEngineMinorVersion;
	public object unescape;
	public object boolean;
	public object byte;
	public object char;
	public object decimal;
	public object double;
	public object float;
	public object int;
	public object long;
	public object sbyte;
	public object short;
	public object void;
	public object uint;
	public object ulong;
	public object ushort;

	// Properties
	public object ActiveXObject { get{} set{} }
	public object Array { get{} set{} }
	public object Boolean { get{} set{} }
	public object Date { get{} set{} }
	public object Enumerator { get{} set{} }
	public object Error { get{} set{} }
	public object EvalError { get{} set{} }
	public object Function { get{} set{} }
	public object Math { get{} set{} }
	public object Number { get{} set{} }
	public object Object { get{} set{} }
	public object RangeError { get{} set{} }
	public object ReferenceError { get{} set{} }
	public object RegExp { get{} set{} }
	public object String { get{} set{} }
	public object SyntaxError { get{} set{} }
	public object TypeError { get{} set{} }
	public object URIError { get{} set{} }
	public object VBArray { get{} set{} }
}

