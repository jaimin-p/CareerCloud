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
    [RoutePrefix("api/careercloud/security/v1")]
    public class SecurityLoginsLogController : ApiController
    {
        private SecurityLoginsLogLogic _logic;

        public SecurityLoginsLogController()
        {
            var repository = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            _logic = new SecurityLoginsLogLogic(repository);
        }

        [HttpGet]
        [Route("loginslog/{securityLoginsLogId}")]
        [ResponseType(typeof(SecurityLoginsLogPoco))]
        public IHttpActionResult GetSecurityLoginLog(Guid securityLoginsLogId)
        {
            SecurityLoginsLogPoco securityLoginsLog = _logic.Get(securityLoginsLogId);
            if (securityLoginsLog == null)
            {
                return NotFound();
            }

            return Ok(securityLoginsLog);
        }

        [HttpGet]
        [Route("loginslog")]
        [ResponseType(typeof(List<SecurityLoginsLogPoco>))]
        public IHttpActionResult GetSecurityLoginLog()
        {
            List<SecurityLoginsLogPoco> securityLoginsLogData = _logic.GetAll();
            return Ok(securityLoginsLogData);
        }

        [HttpPost]
        [Route("loginslog")]
        public IHttpActionResult PostSecurityLoginLog([FromBody] SecurityLoginsLogPoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("loginslog")]
        public IHttpActionResult PutSecurityLoginLog([FromBody] SecurityLoginsLogPoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }

        [HttpDelete]
        [Route("loginslog")]
        public IHttpActionResult DeleteSecurityLoginLog([FromBody] SecurityLoginsLogPoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }

    }
}
