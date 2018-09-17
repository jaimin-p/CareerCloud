using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace CareerCloud.WebAPI.Controllers
{
    [RoutePrefix("api/careercloud/applicant/v1")]
    public class ApplicantJobApplicationController : ApiController
    {
        private ApplicantJobApplicationLogic _logic;

        public ApplicantJobApplicationController()
        {
            var repository = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            _logic = new ApplicantJobApplicationLogic(repository);
        }


        [HttpGet]
        [Route("jobapplication/{jobapplicationId}")]
        [ResponseType(typeof(ApplicantJobApplicationPoco))]
        public IHttpActionResult GetApplicantJobApplication(Guid jobapplicationId)
        {
            var getSingle = _logic.Get(jobapplicationId);
            if (getSingle == null)
            {
                return NotFound();
            }

            return Ok(getSingle);
        }

        [HttpGet]
        [Route("jobapplication")]
        [ResponseType(typeof(List<ApplicantJobApplicationPoco>))]
        public IHttpActionResult GetApplicantJobApplication()
        {
            var getAll = _logic.GetAll();
            if(getAll == null)
            {
                return NotFound();
            }

            return Ok(getAll);
        }

        [HttpPost]
        [Route("jobapplicantion")]
        public IHttpActionResult PostApplicantJobApplication([FromBody] ApplicantJobApplicationPoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }


        [HttpPut]
        [Route("jobapplicantion")]
        public IHttpActionResult PutApplicantJobApplication([FromBody] ApplicantJobApplicationPoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("jobapplicantion")]
        public IHttpActionResult DeleteApplicantJobApplication([FromBody] ApplicantJobApplicationPoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }

    }
}
