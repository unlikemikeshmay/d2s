
namespace bulkybook.Models;
  public enum CharacterClass : Int32
    {
    Titan,
    Hunter,
    Warlock,
    Unknown

 
    }
public class PlayerViewModel
{
    public Player? Player {get;set;}
    public OAuthResponse? OAuthResponse {get;set;}
    public DestinyProfileResponse? destinyProfileResponse {get;set;}
    public CharacterClass? characterClass {get;set;}
   
}