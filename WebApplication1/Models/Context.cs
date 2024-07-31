using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Models.models;

namespace WebApplication1.Models
{
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-2V10NBB; Database=QuizSystemDB; Trusted_Connection = True;MultipleActiveResultSets=true;TrustServerCertificate=True")
                .LogTo(log => Debug.WriteLine(log), LogLevel.Information)
                .EnableSensitiveDataLogging(); 
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuizQuestion>()
                .HasKey(q => new { q.QuizId, q.QuestionId });

            modelBuilder.Entity<QuizQuestion>()
                .HasOne(q => q.Quiz)
                .WithMany(q => q.QuizQuestions)
                .HasForeignKey(q => q.QuizId);

            modelBuilder.Entity<QuizQuestion>()
                .HasOne(q => q.Question)
                .WithMany(q => q.QuizQuestions)
                .HasForeignKey(q => q.QuestionId);

   
        }
    }
 }






/*
    Instructor has many Courses.

    Student has many CourseEnrollments.

    Course has one Instructor and many Quizzes.

    CourseEnrollment has one Course and one Student.

    Quiz has many Questions (via QuizQuestion) and belongs to one Course.

    Question has many Choices and many Quizzes (via QuizQuestion).

    Choice belongs to one Question.

    QuizQuestion establishes a many-to-many relationship between Quiz and Question.

    ExamResult belongs to one Student and one Quiz.

*/