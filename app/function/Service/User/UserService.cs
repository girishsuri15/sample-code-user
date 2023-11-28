public class UserService
{
    private IRepository<UserModel> userRepo;
    public UserService(string Country="default"){
        userRepo = UserRepositoryCreator.UserRepositoryfactory(Country);
    }

    public async Task<UserModel> createUser(UserClaimsDTO userclaims)
    {
        // get the repo on the bases of the claims
        UserModel = Mapper.GetUserModel(userclaims)
        UserDTO userDTO= await userRepo.Create(userclaims);
        
        return userDTO;
    
    }
}