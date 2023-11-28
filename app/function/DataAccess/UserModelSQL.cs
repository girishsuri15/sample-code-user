using System;
using System.ComponentModel.DataAnnotations.Schema;

public class UserModelSQL : UserModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public  int UserID { get; set; }
    
}