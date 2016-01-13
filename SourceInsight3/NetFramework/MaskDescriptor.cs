public class MaskDescriptor
{

	// Methods
	public static bool IsValidMaskDescriptor(MaskDescriptor maskDescriptor) {}
	public static bool IsValidMaskDescriptor(MaskDescriptor maskDescriptorout , System.String& validationErrorDescription) {}
	public virtual bool Equals(object maskDescriptor) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public string Mask { get{} }
	public string Name { get{} }
	public string Sample { get{} }
	public Type ValidatingType { get{} }
	public System.Globalization.CultureInfo Culture { get{} }
}

