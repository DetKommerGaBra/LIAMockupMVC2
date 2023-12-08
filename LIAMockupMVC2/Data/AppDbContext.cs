using LIAMockupMVC2.Models;
using LIAMockupMVC2.Models.RelationalTables;

namespace LIAMockupMVC2.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>()
                .HasData(
                new Organization
                {
                    OrgId = 1,
                    OrgName = "Edugrade",
                    Field = "School"
                },
                new Organization
                {
                    OrgId = 2,
                    OrgName = "Interflora",
                    Field = "Store"
                },
                new Organization
                {
                    OrgId = 3,
                    OrgName = "Hexatronic",
                    Field = "Industrial"
                }
                );

            modelBuilder.Entity<Group>()
                .HasData(
                new Group
                {
                    GroupId = 1,
                    GroupName = "NET22",
                    FK_OrgId = 1
                },
                new Group
                {
                    GroupId = 2,
                    GroupName = "Kassa",
                    FK_OrgId = 2
                },
                new Group
                {
                    GroupId = 3,
                    GroupName = "Fiberavdelningen",
                    FK_OrgId = 3
                }
                );

            modelBuilder.Entity<User>()
                .HasData(
                new User
                {
                    UserId = 1,
                    UserName = "user0033",
                    Email = "user33@gmail.com",
                    Password = "heyhopp33"
                },
                new User
                {
                    UserId = 2,
                    UserName = "user0044",
                    Email = "user44@gmail.com",
                    Password = "heyhopp44"
                },
                new User
                {
                    UserId = 3,
                    UserName = "user0055",
                    Email = "user55@gmail.com",
                    Password = "heyhopp55"
                }
                );

            modelBuilder.Entity<Question>()
                .HasData(
                new Question
                {
                    QuestionId = 1,
                    QuestionText = "Hur mår du idag?"
                },
                new Question
                {
                    QuestionId = 2,
                    QuestionText = "Hur kändes lektionen idag?"
                },
                new Question
                {
                    QuestionId = 3,
                    QuestionText = "Vad önskar du ska tas upp på nästa APT-möte?"
                }
                );

            modelBuilder.Entity<Answer>()
                .HasData(
                new Answer
                {
                    AnswerId = 1,
                    AnswerText = "Inte så jättebra, jag är trött",
                    FK_QuestionId = 1,
                    FK_UserGroupId = 1
                },
                new Answer
                {
                    AnswerId = 2,
                    AnswerText = "Svår men rolig",
                    FK_QuestionId = 2,
                    FK_UserGroupId = 3
                },
                new Answer
                {
                    AnswerId = 3,
                    AnswerText = "Hur hanterar man jobbiga kunder bäst?",
                    FK_QuestionId = 3,
                    FK_UserGroupId = 2
                }
                );

            modelBuilder.Entity<UserGroup>()
                .HasData(
                new UserGroup
                {
                    UserGroupId = 1,
                    FK_UserId = 1,
                    FK_GroupId = 2
                },
                new UserGroup
                {
                    UserGroupId = 2,
                    FK_UserId = 2,
                    FK_GroupId = 3
                },
                new UserGroup
                {
                    UserGroupId = 3,
                    FK_UserId = 3,
                    FK_GroupId = 1
                }
                );
        }
    }
}
