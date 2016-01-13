public class StackFrame
{

	// Constructors
	public StackFrame() {}
	public StackFrame(bool fNeedFileInfo) {}
	public StackFrame(int skipFrames) {}
	public StackFrame(int skipFrames, bool fNeedFileInfo) {}
	public StackFrame(string fileName, int lineNumber) {}
	public StackFrame(string fileName, int lineNumber, int colNumber) {}

	// Methods
	public virtual System.Reflection.MethodBase GetMethod() {}
	public virtual int GetNativeOffset() {}
	public virtual int GetILOffset() {}
	public virtual string GetFileName() {}
	public virtual int GetFileLineNumber() {}
	public virtual int GetFileColumnNumber() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int OFFSET_UNKNOWN;
}

