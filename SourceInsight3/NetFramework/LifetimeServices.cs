public class LifetimeServices
{

	// Constructors
	public LifetimeServices() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.TimeSpan LeaseTime { get{} set{} }
	public System.TimeSpan RenewOnCallTime { get{} set{} }
	public System.TimeSpan SponsorshipTimeout { get{} set{} }
	public System.TimeSpan LeaseManagerPollTime { get{} set{} }
}

