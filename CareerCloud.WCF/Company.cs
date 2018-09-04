using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Company" in both code and config file together.
    public class Company : ICompany
    {
        #region CompanyDescription
        public void AddCompanyDescription(CompanyDescriptionPoco[] pocos)
        {

            var logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>(false));
            logic.Add(pocos);

        }

        public List<CompanyDescriptionPoco> GetAllCompanyDescription()
        {
            var logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>(false));
            return logic.GetAll();


        }

        public CompanyDescriptionPoco GetSingleCompanyDescription(string id)
        {
            var logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>(false));
            return logic.Get(Guid.Parse(id));

        }

        public void RemoveCompanyDescription(CompanyDescriptionPoco[] pocos)
        {
            var logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateCompanyDescription(CompanyDescriptionPoco[] pocos)
        {
            var logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region CompanyJobDescription
        public void AddCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {

            var logic = new CompanyJobDescriptionLogic(new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            logic.Add(pocos);

        }

        public List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription()
        {
            var logic = new CompanyJobDescriptionLogic(new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            return logic.GetAll();


        }

        public CompanyJobDescriptionPoco GetSingleCompanyJobDescription(string id)
        {
            var logic = new CompanyJobDescriptionLogic(new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            return logic.Get(Guid.Parse(id));

        }

        public void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            var logic = new CompanyJobDescriptionLogic(new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            var logic = new CompanyJobDescriptionLogic(new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region CompanyJobEducation
        public void AddCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {

            var logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>(false));
            logic.Add(pocos);

        }

        public List<CompanyJobEducationPoco> GetAllCompanyJobEducation()
        {
            var logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>(false));
            return logic.GetAll();


        }

        public CompanyJobEducationPoco GetSingleCompanyJobEducation(string id)
        {
            var logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>(false));
            return logic.Get(Guid.Parse(id));

        }

        public void RemoveCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            var logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            var logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region CompanyJob
        public void AddCompanyJob(CompanyJobPoco[] pocos)
        {

            var logic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>(false));
            logic.Add(pocos);

        }

        public List<CompanyJobPoco> GetAllCompanyJob()
        {
            var logic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>(false));
            return logic.GetAll();


        }

        public CompanyJobPoco GetSingleCompanyJob(string id)
        {
            var logic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>(false));
            return logic.Get(Guid.Parse(id));

        }

        public void RemoveCompanyJob(CompanyJobPoco[] pocos)
        {
            var logic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateCompanyJob(CompanyJobPoco[] pocos)
        {
            var logic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region CompanyJobSkill
        public void AddCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {

            var logic = new CompanyJobSkillLogic(new EFGenericRepository<CompanyJobSkillPoco>(false));
            logic.Add(pocos);

        }

        public List<CompanyJobSkillPoco> GetAllCompanyJobSkill()
        {
            var logic = new CompanyJobSkillLogic(new EFGenericRepository<CompanyJobSkillPoco>(false));
            return logic.GetAll();


        }

        public CompanyJobSkillPoco GetSingleCompanyJobSkill(string id)
        {
            var logic = new CompanyJobSkillLogic(new EFGenericRepository<CompanyJobSkillPoco>(false));
            return logic.Get(Guid.Parse(id));

        }

        public void RemoveCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            var logic = new CompanyJobSkillLogic(new EFGenericRepository<CompanyJobSkillPoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            var logic = new CompanyJobSkillLogic(new EFGenericRepository<CompanyJobSkillPoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region CompanyLocation
        public void AddCompanyLocation(CompanyLocationPoco[] pocos)
        {

            var logic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>(false));
            logic.Add(pocos);

        }

        public List<CompanyLocationPoco> GetAllCompanyLocation()
        {
            var logic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>(false));
            return logic.GetAll();


        }

        public CompanyLocationPoco GetSingleCompanyLocation(string id)
        {
            var logic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>(false));
            return logic.Get(Guid.Parse(id));

        }

        public void RemoveCompanyLocation(CompanyLocationPoco[] pocos)
        {
            var logic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateCompanyLocation(CompanyLocationPoco[] pocos)
        {
            var logic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region CompanyProfile
        public void AddCompanyProfile(CompanyProfilePoco[] pocos)
        {

            var logic = new CompanyProfileLogic(new EFGenericRepository<CompanyProfilePoco>(false));
            logic.Add(pocos);

        }

        public List<CompanyProfilePoco> GetAllCompanyProfile()
        {
            var logic = new CompanyProfileLogic(new EFGenericRepository<CompanyProfilePoco>(false));
            return logic.GetAll();


        }

        public CompanyProfilePoco GetSingleCompanyProfile(string id)
        {
            var logic = new CompanyProfileLogic(new EFGenericRepository<CompanyProfilePoco>(false));
            return logic.Get(Guid.Parse(id));

        }

        public void RemoveCompanyProfile(CompanyProfilePoco[] pocos)
        {
            var logic = new CompanyProfileLogic(new EFGenericRepository<CompanyProfilePoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateCompanyProfile(CompanyProfilePoco[] pocos)
        {
            var logic = new CompanyProfileLogic(new EFGenericRepository<CompanyProfilePoco>(false));
            logic.Update(pocos);

        }

        #endregion

    }
}
