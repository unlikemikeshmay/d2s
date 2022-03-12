
using Microsoft.AspNetCore.Identity;

namespace bulkybook.Models;

public class User : IdentityUser
{
    public int Id {get;set;}
    public string UserName {get;set;}
}