using DevAssessment.DTO;
using DevAssessment.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace DevAssessmentApplication.Controllers
{
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentService departmentService;

        public DepartmentController()
        {
            departmentService = new DepartmentService();
        }
           
        //public HttpResponseMessage Get(int id)
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, departmentService.GetDepartmentByID(id));           
            
        //}
        
        [HttpGet]
        public IHttpActionResult GetAllDepartments()
        {
            var results =departmentService.GetAllDepartment();
            if (results != null)
            {
                return Ok(results);
            }

            return BadRequest("Something went wrong");

        }

      
    }
}
