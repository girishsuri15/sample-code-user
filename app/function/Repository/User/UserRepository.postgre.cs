using System;
using System.Threading.Tasks;

public class UserRepositoryPostgre : IRepository<UserModel>
{
    public Task<UserModel> Create(UserModel entity)
    {
        throw new NotImplementedException();
    }

   
}