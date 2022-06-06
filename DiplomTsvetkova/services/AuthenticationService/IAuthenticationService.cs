namespace DiplomTsvetkova.services.AuthenticationService
{
    public interface IAuthenticationService 
    {
        string UserName{get;set;}
        string Password{get;set;}
        bool AuthentiocationState();
    }
}
