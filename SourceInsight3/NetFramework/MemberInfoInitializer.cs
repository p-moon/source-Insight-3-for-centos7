public interface MemberInfoInitializer
{

	// Methods
	public abstract virtual void Initialize(string name, COMMemberInfo dispatch) {}
	public abstract virtual COMMemberInfo GetCOMMemberInfo() {}
}

