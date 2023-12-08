namespace LIAMockupMVC2.Models.RelationalTables
{
    public class UserGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserGroupId { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int FK_UserId { get; set; }
        public virtual User? Users { get; set; }

        [Required]
        [ForeignKey("Groups")]
        public int FK_GroupId { get; set; }
        public virtual Group? Groups { get; set; }
    }
}
