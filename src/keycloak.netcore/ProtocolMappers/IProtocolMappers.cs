using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.ProtocolMappers;

namespace Keycloak.Net.ProtocolMappers
{
    public interface IProtocolMappers
    {
        Task<bool> CreateMultipleProtocolMappersAsync(string realm, string clientScopeId, IEnumerable<ProtocolMapper> protocolMapperRepresentations);
        Task<bool> CreateProtocolMapperAsync(string realm, string clientScopeId, ProtocolMapper protocolMapperRepresentation);
        Task<bool> DeleteProtocolMapperAsync(string realm, string clientScopeId, string protocolMapperId);
        Task<ProtocolMapper> GetProtocolMapperAsync(string realm, string clientScopeId, string protocolMapperId);
        Task<IEnumerable<ProtocolMapper>> GetProtocolMappersAsync(string realm, string clientScopeId);
        Task<IEnumerable<ProtocolMapper>> GetProtocolMappersByNameAsync(string realm, string clientScopeId, string protocol);
        Task<bool> UpdateProtocolMapperAsync(string realm, string clientScopeId, string protocolMapperId, ProtocolMapper protocolMapperRepresentation);
    }
}