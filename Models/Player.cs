
using System.ComponentModel.DataAnnotations;

public class Player {
    [Key]
    public int Id {get;set;}
    public string subClass {get;set;}
}