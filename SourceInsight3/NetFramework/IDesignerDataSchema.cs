public interface IDesignerDataSchema
{

	// Methods
	public abstract virtual System.Collections.ICollection GetSchemaItems(DesignerDataSchemaClass schemaClass) {}
	public abstract virtual bool SupportsSchemaClass(DesignerDataSchemaClass schemaClass) {}
}

