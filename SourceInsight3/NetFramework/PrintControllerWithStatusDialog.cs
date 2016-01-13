public class PrintControllerWithStatusDialog : System.Drawing.Printing.PrintController
{

	// Constructors
	public PrintControllerWithStatusDialog(System.Drawing.Printing.PrintController underlyingController) {}
	public PrintControllerWithStatusDialog(System.Drawing.Printing.PrintController underlyingController, string dialogTitle) {}

	// Methods
	public virtual void OnStartPrint(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintEventArgs e) {}
	public virtual System.Drawing.Graphics OnStartPage(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintPageEventArgs e) {}
	public virtual void OnEndPage(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintPageEventArgs e) {}
	public virtual void OnEndPrint(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintEventArgs e) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsPreview { get{} }
}

