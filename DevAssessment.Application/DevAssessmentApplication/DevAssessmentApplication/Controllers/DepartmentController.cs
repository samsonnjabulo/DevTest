using DevAssessment.Service;
using System.Web.Http;

namespace DevAssessmentApplication.Controllers
{
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController()
        {
            _departmentService = new DepartmentService();
        }
      
        [HttpGet]
        public IHttpActionResult GetAllDepartments()
        {
            var results =_departmentService.GetAllDepartment();
            if (results != null)
            {
                return Ok(results);
            }

            return BadRequest("Something went wrong");

        }

        //[HttpGet]
        //public IHttpActionResult GetDepartment(int id)
        //{
        //    return Ok(_departmentService.GetDepartmentByID(id));
        //}


    }
}
