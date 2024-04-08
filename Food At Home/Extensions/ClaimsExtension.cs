using System.Security.Claims;

namespace Food_At_Home.Extensions
{
    public static class ClaimsExtension
    {
        public static Guid? GetId(this ClaimsPrincipal user)
        {
            return Guid.Parse(user.FindFirstValue(ClaimTypes.NameIdentifier));
        }

        public static string GetUsername(this ClaimsPrincipal user)
        {
            return (user.FindFirstValue(ClaimTypes.Name));
        }
    }
}
