using System.Threading.Tasks;
using Keycloak.Net.Models.ClientAttributeCertificate;

namespace Keycloak.Net.ClientAttributeCertificate
{
    public interface IClientAttributeCertificate
    {
        Task<byte[]> GenerateCertificateWithNewKeyPairAndGetKeyStoreAsync(string realm, string clientId, string attribute, KeyStoreConfig keyStoreConfig);
        Task<Certificate> GenerateCertificateWithNewKeyPairAsync(string realm, string clientId, string attribute);
        Task<Certificate> GetKeyInfoAsync(string realm, string clientId, string attribute);
        Task<byte[]> GetKeyStoreForClientAsync(string realm, string clientId, string attribute, KeyStoreConfig keyStoreConfig);
        Task<Certificate> UploadCertificateWithoutPrivateKeyAsync(string realm, string clientId, string attribute, string fileName);
        Task<Certificate> UploadCertificateWithPrivateKeyAsync(string realm, string clientId, string attribute, string fileName);
    }
}