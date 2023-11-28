public class ServiceObject
{
    UserService _userService;
    private ServiceObject(){
        _userService = new UserService();
    }

    public static ServiceObject ServiceFactory(UserClaimsDTO userclaims){
        return new ServiceObject();

    }
}