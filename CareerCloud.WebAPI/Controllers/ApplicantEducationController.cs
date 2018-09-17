using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CareerCloud.WebAPI.Controllers
{
    public class ApplicantEducationController : ApiController
    {
        private ApplicantEducationLogic _logic;

        public ApplicantEducationController()
        {
            var repository = new EFGenericRepository<ApplicantEducationPoco>(false);
            _logic = new ApplicantEducationLogic(repository);
        }

    }
}
