public interface IVsaError
{

	// Properties
	public int Line { get{} }
	public int Severity { get{} }
	public string Description { get{} }
	public string LineText { get{} }
	public IVsaItem SourceItem { get{} }
	public int EndColumn { get{} }
	public int StartColumn { get{} }
	public int Number { get{} }
	public string SourceMoniker { get{} }
}

