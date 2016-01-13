public class WqlEventQuery : EventQuery, System.ICloneable
{

	// Constructors
	public WqlEventQuery() {}
	public WqlEventQuery(string queryOrEventClassName) {}
	public WqlEventQuery(string eventClassName, string condition) {}
	public WqlEventQuery(string eventClassName, System.TimeSpan withinInterval) {}
	public WqlEventQuery(string eventClassName, System.TimeSpan withinInterval, string condition) {}
	public WqlEventQuery(string eventClassName, string condition, System.TimeSpan groupWithinInterval) {}
	public WqlEventQuery(string eventClassName, string condition, System.TimeSpan groupWithinInterval, string[] groupByPropertyList) {}
	public WqlEventQuery(string eventClassName, System.TimeSpan withinInterval, string condition, System.TimeSpan groupWithinInterval, string[] groupByPropertyList, string havingCondition) {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string QueryLanguage { get{} }
	public string QueryString { get{} set{} }
	public string EventClassName { get{} set{} }
	public string Condition { get{} set{} }
	public System.TimeSpan WithinInterval { get{} set{} }
	public System.TimeSpan GroupWithinInterval { get{} set{} }
	public System.Collections.Specialized.StringCollection GroupByPropertyList { get{} set{} }
	public string HavingCondition { get{} set{} }
}

