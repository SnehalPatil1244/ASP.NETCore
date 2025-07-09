using ModelsInASP.NET.Models;

namespace ModelsInASP.NET.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return Datasource();
            
        }

        public StudentModel getStudentById(int id)
        {
            return Datasource().Where(x => x.RollNo == id).FirstOrDefault();
            
        }
        private List<StudentModel> Datasource()
        {
            return new List<StudentModel>
            {
                new StudentModel()  { RollNo = 1 , Name = "Snehal" ,Gender = "Female", Standard = 11},
                new StudentModel()  { RollNo = 2 , Name = "Rohit" ,Gender = "male", Standard = 12},
               new StudentModel()  { RollNo = 3 , Name = "Teju" ,Gender = "Female", Standard = 10},

            };

        }
    }
}
