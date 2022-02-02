using CRUD_v6_1.Context;
using CRUD_v6_1.Models;

namespace CRUD_v6_1.Services
{
    public class SubjectServices : ISubjectServices
    {

        MVCContext db;

        public SubjectServices(MVCContext _db)
        {
            db = _db;
        }


        void ISubjectServices.DeleteASubject(int id)
        {
            Subject subject = db.Subjects.FirstOrDefault(s => s.SubjectId == id);
            if (subject != null)
            {
                db.Remove(subject); 
                db.SaveChanges();
            }
        }

        IEnumerable<Subject> ISubjectServices.GetAllSubjects()
        {
            return (db.Subjects.Select(s => s).ToList());
        }
    }
}
