public interface IBuildResults
{

	// Properties
	public bool Succeeded { get{} }
	public string KeyFile { get{} }
	public string[] ComponentFiles { get{} }
	public BuildMessage[] Messages { get{} }
}

