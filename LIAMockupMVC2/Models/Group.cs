namespace LIAMockupMVC2.Models
{
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GroupId { get; set; }

        [Required]
        [StringLength(100)]
        public required string GroupName { get; set; }

        [Required]
        [ForeignKey("Organizations")]
        public int FK_OrgId { get; set; }
        public virtual Organization? Organizations { get; set; }
    }
}
