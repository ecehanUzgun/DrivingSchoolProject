using DAL.Configurations;
using Microsoft.EntityFrameworkCore;
using MODEL.Entities;

namespace DAL.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }

        public ProjectContext()
        {
            
        }

        //DbSets
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        //Configuration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //UseSqlserver
            if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlServer("server=.;database=SurucuKursuDB;Trusted_Connection=True;TrustServerCertificate=True;");

            base.OnConfiguring(optionsBuilder);
        }

        //ModelCreating
        protected override void OnModelCreating(ModelBuilder builder)
        {   
            builder.ApplyConfiguration(new BranchConfiguration());
            builder.ApplyConfiguration(new TeacherConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new VehicleConfiguration());
            builder.ApplyConfiguration(new ScheduleConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
