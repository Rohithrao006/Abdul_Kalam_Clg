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
        void UpdateStudent(ApplicationForm appForm);
        void SaveImages(ApplicationViewModel appForm);
        void SaveImages(int appNo,ApplicationViewModel appForm);
        ApplicationForm getStudent(int AppNo);
    }

}