namespace AmigosDeLaWeb.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static AmigosDeLaWeb.Models.Lista;
  public enum TypeList
        {
            Dominguez,
            Lara,
            Soria,
            Terceros,
            Zamora,
        }
    public class Lista
    {
         [Key]
    public int FriendId {get;set; }
    [Required]
    [Range(5,50)]
    public string Name { get; set; }
    [Required]
    public TypeList List { get; set; }
    public string Email { get; set; }
    }
 
}