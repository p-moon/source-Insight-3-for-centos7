public interface IOleCommandTarget
{

	// Methods
	public abstract virtual int QueryStatus(System.Guid& pguidCmdGroup, int cCmdsout , OLECMD prgCmdsout , System.IntPtr pCmdText) {}
	public abstract virtual int Exec(System.Guid& pguidCmdGroup, int nCmdID, int nCmdexecopt, object[] pvaIn, int pvaOut) {}
}

