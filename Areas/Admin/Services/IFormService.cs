using System.Threading.Tasks;
using System.Collections.Generic;
using WebApplication.Areas.Admin.Models;
namespace WebApplication.Areas.Admin.Services
{
    public interface IAdmission
    {
        void AddStudent(ApplicationForm appForm);
        
        List<ApplicationForm> ListStudents();
        int AppNo();

<<<<<<< HEAD
        void UpdateStudent(ApplicationForm appForm);
=======
        void UpdateStudent();
>>>>>>> 8659823ff32e4274a6e03abdac2a58eee59106d2
        void SaveImages(ApplicationViewModel appForm);

        ApplicationForm getStudent(int AppNo);
    }

}