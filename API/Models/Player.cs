using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Player
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id{get;set;}
  public string UserName{get;set;}
  public int Score {get;set;}

  public string Email{get;set;}

  public int? GameStateId{get;set;}

  public string GameName{get;set;}

  public bool Incorrect{get;set;}
  public bool Ready {get;set;}

  public bool NextQuestion{get;set;}
  public string GamesJoined{get;set;}


}

    }
