public class VerificationAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public VerificationAttribute(string guideline, string checkpoint, VerificationReportLevel reportLevel, int priority, string message) {}
	public VerificationAttribute(string guideline, string checkpoint, VerificationReportLevel reportLevel, int priority, string message, VerificationRule rule, string conditionalProperty) {}
	public VerificationAttribute(string guideline, string checkpoint, VerificationReportLevel reportLevel, int priority, string message, VerificationRule rule, string conditionalProperty, VerificationConditionalOperator conditionalOperator, string conditionalValue, string guidelineUrl) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Guideline { get{} }
	public string Checkpoint { get{} }
	public VerificationReportLevel VerificationReportLevel { get{} }
	public int Priority { get{} }
	public string Message { get{} }
	public VerificationRule VerificationRule { get{} }
	public string ConditionalProperty { get{} }
	public VerificationConditionalOperator VerificationConditionalOperator { get{} }
	public string ConditionalValue { get{} }
	public string GuidelineUrl { get{} }
	public object TypeId { get{} }
}

