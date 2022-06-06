namespace DiplomTsvetkova.services.AuthenticationService
{
    public class AuthenticationService : IAuthenticationService
    {
        public string UserName {get;set;}
        public string Password {get;set;}

        public bool AuthentiocationState()
        {
            if(string.IsNullOrWhiteSpace(UserName) && string.IsNullOrWhiteSpace(Password))
            {
                return false;
            }
            return true;
        }
    }
}
