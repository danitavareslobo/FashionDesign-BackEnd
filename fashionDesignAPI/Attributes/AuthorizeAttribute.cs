using fashionDesignAPI.Dto.Users.Response;
using fashionDesignAPI.Exceptions;
using fashionDesignAPI.Models.Enums;
using Microsoft.AspNetCore.Mvc.Filters;

namespace fashionDesignAPI.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public RoleEnum[]? Roles;
        private const string UnauthorizedErrorMessage = "Você não possui autorização para esta solicitação";

        public AuthorizeAttribute(params RoleEnum[] roles)
        {
            Roles = roles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata
                .OfType<AllowAnonymousAttribute>()
                .Any();
            if (allowAnonymous)
                return;

            var account = (UsersResponse)context.HttpContext.Items["User"];
            if (account == null)
            {
                throw new UnauthorizedException(UnauthorizedErrorMessage);
            }

            if (context.ActionDescriptor.EndpointMetadata
                    .OfType<AuthorizeAttribute>()
                    .Any(r => r.Roles != null && r.Roles.Any(role => role.Equals(account.RoleEnum)))
            )
                return;

            throw new UnauthorizedException(UnauthorizedErrorMessage);
        }
    }
}
