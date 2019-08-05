using System.Threading.Tasks;
using Keycloak.Net.Models.AttackDetection;

namespace Keycloak.Net.AttackDetection
{
    public interface IAttackDetection
    {
        Task<bool> ClearUserLoginFailuresAsync(string realm);
        Task<bool> ClearUserLoginFailuresAsync(string realm, string userId);
        Task<UserNameStatus> GetUserNameStatusInBruteForceDetectionAsync(string realm, string userId);
    }
}