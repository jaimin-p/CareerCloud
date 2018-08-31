using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CareerCloud.Pocos;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.BusinessLogicLayer;

namespace CareerCloud.WCF
{
   
    public class Applicant : IApplicant
    {
        #region ApplicantEducation
        public void AddApplicantEducation(ApplicantEducationPoco[] pocos)
        {

            var logic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>(false));
            logic.Add(pocos);

        }

        public List<ApplicantEducationPoco> GetAllApplicantEducation()
        {
            var logic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>(false));
            return logic.GetAll();


        }

        public ApplicantEducationPoco GetSingleApplicantEducation(Guid id)
        {
            var logic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>(false));
            return logic.Get(id);

        }

        public void RemoveApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            var logic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            var logic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region ApplicantJobApplication
        public void AddApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {

            var logic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            logic.Add(pocos);

        }

        public List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication()
        {
            var logic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            return logic.GetAll();


        }

        public ApplicantJobApplicationPoco GetSingleApplicantJobApplication(Guid id)
        {
            var logic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            return logic.Get(id);

        }

        public void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            var logic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            var logic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region ApplicantProfile
        public void AddApplicantProfile(ApplicantProfilePoco[] pocos)
        {

            var logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>(false));
            logic.Add(pocos);

        }

        public List<ApplicantProfilePoco> GetAllApplicantProfile()
        {
            var logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>(false));
            return logic.GetAll();


        }

        public ApplicantProfilePoco GetSingleApplicantProfile(Guid id)
        {
            var logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>(false));
            return logic.Get(id);

        }

        public void RemoveApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            var logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            var logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region ApplicantResume
        public void AddApplicantResume(ApplicantResumePoco[] pocos)
        {

            var logic = new ApplicantResumeLogic(new EFGenericRepository<ApplicantResumePoco>(false));
            logic.Add(pocos);

        }

        public List<ApplicantResumePoco> GetAllApplicantResume()
        {
            var logic = new ApplicantResumeLogic(new EFGenericRepository<ApplicantResumePoco>(false));
            return logic.GetAll();


        }

        public ApplicantResumePoco GetSingleApplicantResume(Guid id)
        {
            var logic = new ApplicantResumeLogic(new EFGenericRepository<ApplicantResumePoco>(false));
            return logic.Get(id);

        }

        public void RemoveApplicantResume(ApplicantResumePoco[] pocos)
        {
            var logic = new ApplicantResumeLogic(new EFGenericRepository<ApplicantResumePoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateApplicantResume(ApplicantResumePoco[] pocos)
        {
            var logic = new ApplicantResumeLogic(new EFGenericRepository<ApplicantResumePoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region ApplicantSkill
        public void AddApplicantSkill(ApplicantSkillPoco[] pocos)
        {

            var logic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>(false));
            logic.Add(pocos);

        }

        public List<ApplicantSkillPoco> GetAllApplicantSkill()
        {
            var logic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>(false));
            return logic.GetAll();


        }

        public ApplicantSkillPoco GetSingleApplicantSkill(Guid id)
        {
            var logic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>(false));
            return logic.Get(id);

        }

        public void RemoveApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            var logic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            var logic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region ApplicantWorkHistory
        public void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {

            var logic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            logic.Add(pocos);

        }

        public List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory()
        {
            var logic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            return logic.GetAll();


        }

        public ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(Guid id)
        {
            var logic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            return logic.Get(id);

        }

        public void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            var logic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            var logic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            logic.Update(pocos);

        }

        #endregion


    }
}
