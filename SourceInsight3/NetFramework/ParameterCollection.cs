public class ParameterCollection : System.Web.UI.StateManagedCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Web.UI.IStateManager
{

	// Constructors
	public ParameterCollection() {}

	// Methods
	public int Add(Parameter parameter) {}
	public int Add(string name, string value) {}
	public int Add(string name, System.TypeCode type, string value) {}
	public bool Contains(Parameter parameter) {}
	public void CopyTo(Parameter[] parameterArray, int index) {}
	public System.Collections.Specialized.IOrderedDictionary GetValues(System.Web.HttpContext context, System.Web.UI.Control control) {}
	public int IndexOf(Parameter parameter) {}
	public void Insert(int index, Parameter parameter) {}
	public void Remove(Parameter parameter) {}
	public void RemoveAt(int index) {}
	public void UpdateValues(System.Web.HttpContext context, System.Web.UI.Control control) {}
	public void Clear() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public void SetDirty() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Parameter Item { get{} set{} }
	public Parameter Item { get{} set{} }
	public int Count { get{} }

	// Events
	public event System.EventHandler ParametersChanged;
}

