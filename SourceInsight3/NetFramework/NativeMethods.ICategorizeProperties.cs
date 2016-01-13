public interface ICategorizeProperties
{

	// Methods
	public abstract virtual int MapPropertyToCategory(int dispID, System.Int32& categoryID) {}
	public abstract virtual int GetCategoryName(int propcat, int lcidout , System.String& categoryName) {}
}

