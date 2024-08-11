using Microsoft.AspNetCore.Authorization;

public class CustomAuthorizeAttribute : AuthorizeAttribute
{
    public CustomAuthorizeAttribute(Constants.Role roleEnum)
    {
        Roles = roleEnum.ToString().Replace(" ", string.Empty);
    }
}

public static class Constants
{
    [Flags]
    public enum Role
    {
        User = 1,
        SuperUser = 2,
        Admin = 4,
        SuperAdmin = 8
    }
}