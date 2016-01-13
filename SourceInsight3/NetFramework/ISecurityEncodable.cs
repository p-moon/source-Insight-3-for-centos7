public interface ISecurityEncodable
{

	// Methods
	public abstract virtual SecurityElement ToXml() {}
	public abstract virtual void FromXml(SecurityElement e) {}
}

