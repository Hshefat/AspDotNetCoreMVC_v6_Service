using CRUD_v6_1.Models;

namespace CRUD_v6_1.Services
{
    public interface ISubjectServices
    {
        public IEnumerable<Subject> GetAllSubjects();
        public void DeleteASubject(int id);
    }
}
