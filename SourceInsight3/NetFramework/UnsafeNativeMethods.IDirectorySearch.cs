public interface IDirectorySearch
{

	// Methods
	public abstract virtual void SetSearchPreference(System.IntPtr pSearchPrefs, int dwNumPrefs) {}
	public abstract virtual void ExecuteSearch(string pszSearchFilter, string[] pAttributeNames, int dwNumberAttributesout , System.IntPtr& hSearchResult) {}
	public abstract virtual void AbandonSearch(System.IntPtr hSearchResult) {}
	public abstract virtual int GetFirstRow(System.IntPtr hSearchResult) {}
	public abstract virtual int GetNextRow(System.IntPtr hSearchResult) {}
	public abstract virtual int GetPreviousRow(System.IntPtr hSearchResult) {}
	public abstract virtual int GetNextColumnName(System.IntPtr hSearchResultout , System.IntPtr ppszColumnName) {}
	public abstract virtual void GetColumn(System.IntPtr hSearchResult, System.IntPtr szColumnName, System.IntPtr pSearchColumn) {}
	public abstract virtual void FreeColumn(System.IntPtr pSearchColumn) {}
	public abstract virtual void CloseSearchHandle(System.IntPtr hSearchResult) {}
}

