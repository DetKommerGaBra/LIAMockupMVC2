namespace LIAMockupMVC2.Models
{
    public class Organization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrgId { get; set; }

        [Required]
        [StringLength(100)]
        public required string OrgName { get; set; }

        [Required]
        [StringLength(100)]
        public required string Field { get; set; }

        public virtual ICollection<Group>? Groups { get; set; }
    }
}
