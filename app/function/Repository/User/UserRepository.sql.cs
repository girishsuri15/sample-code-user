using System;
using System.Data.Common;
using System.Threading.Tasks;

public class UserRepositorySQL :  IRepository<UserModel>
{
    private DataAccessSQL _context; 
    public UserRepositorySQL(string connectionString){

        this._context = new DataAccessSQL(connectionString);
    }

    public async Task<UserModel> Create(UserModel entity)
    {
         await this._context.Users.AddAsync(new UserModelSQL(){
            UserName =entity.UserName,
            Country=entity.Country

        });
        int rows = await this._context.SaveChangesAsync();
        if(rows==1){
            return entity;
        } 
        else{
            throw new Exception();
        }
    }
}