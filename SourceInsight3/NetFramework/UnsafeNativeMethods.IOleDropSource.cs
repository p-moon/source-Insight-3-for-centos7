public interface IOleDropSource
{

	// Methods
	public abstract virtual int OleQueryContinueDrag(int fEscapePressed, int grfKeyState) {}
	public abstract virtual int OleGiveFeedback(int dwEffect) {}
}

