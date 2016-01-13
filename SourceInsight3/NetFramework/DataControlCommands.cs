public class DataControlCommands
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string SortCommandName;
	public string SelectCommandName;
	public string EditCommandName;
	public string DeleteCommandName;
	public string UpdateCommandName;
	public string CancelCommandName;
	public string PageCommandName;
	public string NextPageCommandArgument;
	public string PreviousPageCommandArgument;
	public string FirstPageCommandArgument;
	public string LastPageCommandArgument;
	public string InsertCommandName;
	public string NewCommandName;
}

