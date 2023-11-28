public static class Mapper
{
    public static UserClaimsDTO RequestBodyToUserClaimDTO(dynamic requestdata)
    {
        return new UserClaimsDTO()
        {
            UserName = requestdata?.name,
            Country = requestdata?.Country

        };

    }
    public static UserModel GetUserModel(UserClaimsDTO userClaimsDTO)
    {
        return new UserModel()
        {
            UserName = userClaimsDTO.UserName,
            Country = userClaimsDTO.Country

        };
    }
}