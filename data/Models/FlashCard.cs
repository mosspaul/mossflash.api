using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace data.Models;

public class FlashCard
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set; }
    public int QuizId {get; set;}
    public Quiz? Quiz {get; set; }
    public string? Question {get; set;}
    public string? Answer {get; set;}
}
