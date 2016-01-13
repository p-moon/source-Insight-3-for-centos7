public interface ITypeDiscoveryService
{

	// Methods
	public abstract virtual System.Collections.ICollection GetTypes(Type baseType, bool excludeGlobalTypes) {}
}

