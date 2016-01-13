public interface IProvidePropertyBuilder
{

	// Methods
	public abstract virtual int MapPropertyToBuilder(int dispidout , int[] pdwCtlBldTypeout , string[] pbstrGuidBldrout , System.Boolean& builderAvailable) {}
	public abstract virtual int ExecuteBuilder(int dispid, string bstrGuidBldr, object pdispApp, System.Runtime.InteropServices.HandleRef hwndBldrOwnerout , System.Object& pvarValueout , System.Boolean& actionCommitted) {}
}

