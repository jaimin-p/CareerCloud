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
    public class ApplicantProfileController : ApiController
    {
        private ApplicantProfileLogic _logic;

        public ApplicantProfileController()
        {
            var repository = new EFGenericRepository<ApplicantProfilePoco>(false);
            _logic = new ApplicantProfileLogic(repository);
        }

        [HttpGet]
        [Route("profile/{applicantProfileId}")]
        [ResponseType(typeof(ApplicantProfilePoco))]
        public IHttpActionResult GetApplicantProfile(Guid applicantProfileId)
        {
            var getSingle = _logic.Get(applicantProfileId);
            if (getSingle == null)
            {
                return NotFound();
            }

            return Ok(getSingle);
        }

        [HttpGet]
        [Route("profile")]
        [ResponseType(typeof(List<ApplicantProfilePoco>))]
        public IHttpActionResult GetApplicantProfile()
        {
            var getAll = _logic.GetAll();
            if (getAll == null)
            {
                return NotFound();
            }

            return Ok(getAll);
        }



        [HttpPost]
        [Route("profile")]
        public IHttpActionResult PostApplicantProfile([FromBody] ApplicantProfilePoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("profile")]
        public IHttpActionResult PutApplicantProfile([FromBody] ApplicantProfilePoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();

        }

        [HttpDelete]
        [Route("profile")]
        public IHttpActionResult DeleteApplicantProfile([FromBody] ApplicantProfilePoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();

        }





    }
}
