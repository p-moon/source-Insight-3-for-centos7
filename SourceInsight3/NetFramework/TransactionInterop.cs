public class TransactionInterop
{

	// Methods
	public static byte[] GetExportCookie(Transaction transaction, byte[] whereabouts) {}
	public static Transaction GetTransactionFromExportCookie(byte[] cookie) {}
	public static byte[] GetTransmitterPropagationToken(Transaction transaction) {}
	public static Transaction GetTransactionFromTransmitterPropagationToken(byte[] propagationToken) {}
	public static IDtcTransaction GetDtcTransaction(Transaction transaction) {}
	public static Transaction GetTransactionFromDtcTransaction(IDtcTransaction transactionNative) {}
	public static byte[] GetWhereabouts() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

