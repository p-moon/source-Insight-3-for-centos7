public class StackTrace
{

	// Constructors
	public StackTrace() {}
	public StackTrace(bool fNeedFileInfo) {}
	public StackTrace(int skipFrames) {}
	public StackTrace(int skipFrames, bool fNeedFileInfo) {}
	public StackTrace(System.Exception e) {}
	public StackTrace(System.Exception e, bool fNeedFileInfo) {}
	public StackTrace(System.Exception e, int skipFrames) {}
	public StackTrace(System.Exception e, int skipFrames, bool fNeedFileInfo) {}
	public StackTrace(StackFrame frame) {}
	public StackTrace(System.Threading.Thread targetThread, bool needFileInfo) {}

	// Methods
	public virtual StackFrame GetFrame(int index) {}
	public virtual StackFrame[] GetFrames() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int METHODS_TO_SKIP;

	// Properties
	public int FrameCount { get{} }
}

