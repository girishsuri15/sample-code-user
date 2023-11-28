using System;

public class UserRepositoryCreator
{

    public static IRepository<UserModel> UserRepositoryfactory(string country)
    {
        DataBaseInformation dbInfo = DataBaseConfiguration.GetDataBaseInformation(country);
        switch (dbInfo.DATABASE_TYPE)
        {
            case DATABASE_TYPE.SQL:
                return new UserRepositorySQL(dbInfo.ConnectionString);
            case DATABASE_TYPE.Postgre:
                throw new NotImplementedException();
            default:
                throw new Exception("Invaild DataBAse Type");

        }
    }

}