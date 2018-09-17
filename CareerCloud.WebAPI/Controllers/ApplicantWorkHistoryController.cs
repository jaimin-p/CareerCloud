﻿using CareerCloud.BusinessLogicLayer;
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
    public class ApplicantWorkHistoryController : ApiController
    {
        private ApplicantWorkHistoryLogic _logic;
        public ApplicantWorkHistoryController()
        {
            var repository = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            _logic = new ApplicantWorkHistoryLogic(repository);
        }

        [HttpGet]
        [Route("workhistory/{applicantWorkHistoryId}")]
        [ResponseType(typeof(ApplicantWorkHistoryPoco))]
        public IHttpActionResult GetApplicantWorkHistory(Guid applicantWorkHistoryId)
        {
            ApplicantWorkHistoryPoco applicantWorkHistory = _logic.Get(applicantWorkHistoryId);
            if (applicantWorkHistory == null)
            {
                return NotFound();
            }

            return Ok(applicantWorkHistory);
        }

        [HttpGet]
        [Route("workhistory")]
        [ResponseType(typeof(List<ApplicantWorkHistoryPoco>))]
        public IHttpActionResult GetApplicantWorkHistory()
        {
            List<ApplicantWorkHistoryPoco> applicantWorkHistoryData = _logic.GetAll();
            return Ok(applicantWorkHistoryData);
        }

        [HttpPost]
        [Route("workhistory")]
        public IHttpActionResult PostApplicantWorkHistory([FromBody] ApplicantWorkHistoryPoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("workhistory")]
        public IHttpActionResult PutApplicantWorkHistory([FromBody] ApplicantWorkHistoryPoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }

        [HttpDelete]
        [Route("workhistory")]
        public IHttpActionResult DeleteApplicantWorkHistory([FromBody] ApplicantWorkHistoryPoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
