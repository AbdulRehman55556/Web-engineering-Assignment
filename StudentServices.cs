
using Microsoft.EntityFrameworkCore;
using Assignment_2.Model;
namespace Assignment_2.Context;
    

    public class StudentServices
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public StudentServices(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //List of Student
        public async Task<List<Student>> GetAllStudents()
        {
            return await _applicationDbContext.Students.ToListAsync();
        }

        //Add Student
        public async Task<bool> InsertStudent(Student student)
        {
            await _applicationDbContext.Students.AddAsync(student);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get Students By Id 
        public async Task<Student> GetStudentById(int sid)
        {
            Student student = await _applicationDbContext.Students.FirstOrDefaultAsync(c => c.sid.Equals(sid));
            return student;
        }
    }

