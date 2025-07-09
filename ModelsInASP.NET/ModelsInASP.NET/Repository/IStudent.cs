using ModelsInASP.NET.Models;

namespace ModelsInASP.NET.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);
            
    }
}
