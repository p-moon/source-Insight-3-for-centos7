public interface ICertificatePolicy
{

	// Methods
	public abstract virtual bool CheckValidationResult(ServicePoint srvPoint, System.Security.Cryptography.X509Certificates.X509Certificate certificate, WebRequest request, int certificateProblem) {}
}

