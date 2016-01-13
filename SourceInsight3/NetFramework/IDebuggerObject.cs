public interface IDebuggerObject
{

	// Methods
	public abstract virtual bool IsCOMObject() {}
	public abstract virtual bool IsEqual(IDebuggerObject o) {}
	public abstract virtual bool HasEnumerableMember(string name) {}
	public abstract virtual bool IsScriptFunction() {}
	public abstract virtual bool IsScriptObject() {}
}

