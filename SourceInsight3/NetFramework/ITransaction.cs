public interface ITransaction
{

	// Methods
	public abstract virtual void Commit(int fRetaining, int grfTC, int grfRM) {}
	public abstract virtual void Abort(BOID& pboidReason, int fRetaining, int fAsync) {}
	public abstract virtual void GetTransactionInfo(out XACTTRANSINFO& pinfo) {}
}

