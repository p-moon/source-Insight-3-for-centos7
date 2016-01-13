public class WizardStepCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public void Add(WizardStepBase wizardStep) {}
	public void AddAt(int index, WizardStepBase wizardStep) {}
	public virtual void Clear() {}
	public bool Contains(WizardStepBase wizardStep) {}
	public void CopyTo(WizardStepBase[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int IndexOf(WizardStepBase wizardStep) {}
	public void Insert(int index, WizardStepBase wizardStep) {}
	public void Remove(WizardStepBase wizardStep) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public WizardStepBase Item { get{} }
}

