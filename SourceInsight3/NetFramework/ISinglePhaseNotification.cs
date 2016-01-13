public interface ISinglePhaseNotification : IEnlistmentNotification
{

	// Methods
	public abstract virtual void SinglePhaseCommit(SinglePhaseEnlistment singlePhaseEnlistment) {}
}

