using System.Threading.Tasks;
using Keycloak.Net.Models.Key;

namespace Keycloak.Net.Key
{
    public interface IKey
    {
        Task<KeysMetadata> GetKeysAsync(string realm);
    }
}