public class DataBaseInformation
{
    public DataBaseInformation(DATABASE_TYPE DATABASE_TYPE, string ConnectionString)
    {
        this.DATABASE_TYPE = DATABASE_TYPE;
        this.ConnectionString = ConnectionString;
    }
    public DATABASE_TYPE DATABASE_TYPE { get; }
    public string ConnectionString { get; }

}

