public interface ILease
{

	// Methods
	public abstract virtual void Register(ISponsor obj, System.TimeSpan renewalTime) {}
	public abstract virtual void Register(ISponsor obj) {}
	public abstract virtual void Unregister(ISponsor obj) {}
	public abstract virtual System.TimeSpan Renew(System.TimeSpan renewalTime) {}

	// Properties
	public System.TimeSpan RenewOnCallTime { get{} set{} }
	public System.TimeSpan SponsorshipTimeout { get{} set{} }
	public System.TimeSpan InitialLeaseTime { get{} set{} }
	public System.TimeSpan CurrentLeaseTime { get{} }
	public LeaseState CurrentState { get{} }
}

