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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "System" in both code and config file together.
    public class System : ISystem
    {

        #region SystemCountryCode
        public void AddSystemCountryCode(SystemCountryCodePoco[] pocos)
        {

            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));
            logic.Add(pocos);

        }

        public List<SystemCountryCodePoco> GetAllSystemCountryCode()
        {
            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));
            return logic.GetAll();


        }

        public SystemCountryCodePoco GetSingleSystemCountryCode(string id)
        {
            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));
            return logic.Get(id);

        }

        public void RemoveSystemCountryCode(SystemCountryCodePoco[] pocos)
        {
            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateSystemCountryCode(SystemCountryCodePoco[] pocos)
        {
            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region SystemLanguageCode
        public void AddSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {

            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));
            logic.Add(pocos);

        }

        public List<SystemLanguageCodePoco> GetAllSystemLanguageCode()
        {
            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));
            return logic.GetAll();


        }

        public SystemLanguageCodePoco GetSingleSystemLanguageCode(string id)
        {
            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));
            return logic.Get(id);

        }

        public void RemoveSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));
            logic.Update(pocos);

        }

        #endregion

    }
}
