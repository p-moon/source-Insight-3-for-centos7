public interface IDtcTransaction
{

	// Methods
	public abstract virtual void Commit(int retaining, int commitType, int reserved) {}
	public abstract virtual void Abort(System.IntPtr reason, int retaining, int async) {}
	public abstract virtual void GetTransactionInfo(System.IntPtr transactionInformation) {}
}

