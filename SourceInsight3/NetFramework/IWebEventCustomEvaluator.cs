public interface IWebEventCustomEvaluator
{

	// Methods
	public abstract virtual bool CanFire(WebBaseEvent raisedEvent, RuleFiringRecord record) {}
}

