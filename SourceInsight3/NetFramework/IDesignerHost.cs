public interface IDesignerHost : IServiceContainer, System.IServiceProvider
{

	// Methods
	public abstract virtual void Activate() {}
	public abstract virtual System.ComponentModel.IComponent CreateComponent(Type componentClass) {}
	public abstract virtual System.ComponentModel.IComponent CreateComponent(Type componentClass, string name) {}
	public abstract virtual DesignerTransaction CreateTransaction() {}
	public abstract virtual DesignerTransaction CreateTransaction(string description) {}
	public abstract virtual void DestroyComponent(System.ComponentModel.IComponent component) {}
	public abstract virtual IDesigner GetDesigner(System.ComponentModel.IComponent component) {}
	public abstract virtual Type GetType(string typeName) {}

	// Properties
	public bool Loading { get{} }
	public bool InTransaction { get{} }
	public System.ComponentModel.IContainer Container { get{} }
	public System.ComponentModel.IComponent RootComponent { get{} }
	public string RootComponentClassName { get{} }
	public string TransactionDescription { get{} }

	// Events
	public event System.EventHandler Activated;
	public event System.EventHandler Deactivated;
	public event System.EventHandler LoadComplete;
	public event System.ComponentModel.Design.DesignerTransactionCloseEventHandler TransactionClosed;
	public event System.ComponentModel.Design.DesignerTransactionCloseEventHandler TransactionClosing;
	public event System.EventHandler TransactionOpened;
	public event System.EventHandler TransactionOpening;
}

