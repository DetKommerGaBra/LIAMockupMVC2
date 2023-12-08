namespace LIAMockupMVC2.Models
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionId { get; set; }

        [StringLength(300)]
        public string? QuestionText { get; set; }

        [MaxLength(10)]
        public int? QuestionNum { get; set; }
        //Test igen igen last chance
    }
}
