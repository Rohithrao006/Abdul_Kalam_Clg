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

        void UpdateStudent();
        void SaveImages(ApplicationViewModel appForm);

        ApplicationForm getStudent(int AppNo);
    }

}