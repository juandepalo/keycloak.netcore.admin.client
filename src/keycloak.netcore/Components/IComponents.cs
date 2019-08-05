using System.Collections.Generic;
using System.Threading.Tasks;
using Keycloak.Net.Models.Components;

namespace Keycloak.Net.Components
{
    public interface IComponents
    {
        Task<bool> CreateComponentAsync(string realm, Component componentRepresentation);
        Task<bool> DeleteComponentAsync(string realm, string componentId);
        Task<Component> GetComponentAsync(string realm, string componentId);
        Task<IEnumerable<Component>> GetComponentsAsync(string realm, string name = null, string parent = null, string type = null);
        Task<IEnumerable<ComponentType>> GetSubcomponentTypesAsync(string realm, string componentId, string type = null);
        Task<bool> UpdateComponentAsync(string realm, string componentId, Component componentRepresentation);
    }
}