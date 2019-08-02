﻿using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;
using Keycloak.Net.Models.ClientAttributeCertificate;

namespace Keycloak.Net.ClientAttributeCertificate
{
    public class ClientAttributeCertificate : KeycloakClient
    {
        public ClientAttributeCertificate(string url, string userName, string password) : base(url, userName, password)
        {
        }

        public ClientAttributeCertificate(string url, Func<string> getToken) : base(url, getToken)
        {
        }

        public async Task<Certificate> GetKeyInfoAsync(string realm, string clientId, string attribute) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/certificates/{attribute}")
            .GetJsonAsync<Certificate>()
            .ConfigureAwait(false);

        public async Task<byte[]> GetKeyStoreForClientAsync(string realm, string clientId, string attribute, KeyStoreConfig keyStoreConfig) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/certificates/{attribute}/download")
            .PostJsonAsync(keyStoreConfig)
            .ReceiveBytes()
            .ConfigureAwait(false);

        public async Task<Certificate> GenerateCertificateWithNewKeyPairAsync(string realm, string clientId, string attribute) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/certificates/{attribute}/generate")
            .PostAsync(new StringContent(""))
            .ReceiveJson<Certificate>()
            .ConfigureAwait(false);

        public async Task<byte[]> GenerateCertificateWithNewKeyPairAndGetKeyStoreAsync(string realm, string clientId, string attribute, KeyStoreConfig keyStoreConfig) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/certificates/{attribute}/generate-and-download")
            .PostJsonAsync(keyStoreConfig)
            .ReceiveBytes()
            .ConfigureAwait(false);

        public async Task<Certificate> UploadCertificateWithPrivateKeyAsync(string realm, string clientId, string attribute, string fileName) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/certificates/{attribute}/upload")
            .PostMultipartAsync(content => content.AddFile(Path.GetFileName(fileName), Path.GetDirectoryName(fileName)))
            .ReceiveJson<Certificate>()
            .ConfigureAwait(false);

        public async Task<Certificate> UploadCertificateWithoutPrivateKeyAsync(string realm, string clientId, string attribute, string fileName) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/certificates/{attribute}/upload-certificate")
            .PostMultipartAsync(content => content.AddFile(Path.GetFileName(fileName), Path.GetDirectoryName(fileName)))
            .ReceiveJson<Certificate>()
            .ConfigureAwait(false);
    }
}