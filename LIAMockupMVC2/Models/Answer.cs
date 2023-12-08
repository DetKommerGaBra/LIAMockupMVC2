using LIAMockupMVC2.Models.RelationalTables;

namespace LIAMockupMVC2.Models
{
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnswerId { get; set; }

        [StringLength(300)]
        public string? AnswerText { get; set; }

        [MaxLength(10)]
        public int? AnswerNum { get; set; }

        [Required]
        [ForeignKey("Questions")]
        public required int FK_QuestionId { get; set; }
        public virtual Question? Questions { get; set; }

        [Required]
        [ForeignKey("UserGroups")]
        public required int FK_UserGroupId { get; set; }
        public virtual UserGroup? UserGroups { get; set; }
    }
}
