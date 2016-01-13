public interface IDataGridEditingService
{

	// Methods
	public abstract virtual bool BeginEdit(DataGridColumnStyle gridColumn, int rowNumber) {}
	public abstract virtual bool EndEdit(DataGridColumnStyle gridColumn, int rowNumber, bool shouldAbort) {}
}

