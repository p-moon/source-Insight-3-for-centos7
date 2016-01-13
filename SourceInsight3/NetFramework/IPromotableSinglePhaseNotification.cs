public interface IPromotableSinglePhaseNotification : ITransactionPromoter
{

	// Methods
	public abstract virtual void Initialize() {}
	public abstract virtual void SinglePhaseCommit(SinglePhaseEnlistment singlePhaseEnlistment) {}
	public abstract virtual void Rollback(SinglePhaseEnlistment singlePhaseEnlistment) {}
}

