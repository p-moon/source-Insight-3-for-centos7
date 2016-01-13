public interface IEnlistmentNotification
{

	// Methods
	public abstract virtual void Prepare(PreparingEnlistment preparingEnlistment) {}
	public abstract virtual void Commit(Enlistment enlistment) {}
	public abstract virtual void Rollback(Enlistment enlistment) {}
	public abstract virtual void InDoubt(Enlistment enlistment) {}
}

