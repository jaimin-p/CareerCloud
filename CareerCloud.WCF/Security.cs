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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Security" in both code and config file together.
    public class Security : ISecurity
    {
        #region SecurityLogin
        public void AddSecurityLogin(SecurityLoginPoco[] pocos)
        {

            var logic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>(false));
            logic.Add(pocos);

        }

        public List<SecurityLoginPoco> GetAllSecurityLogin()
        {
            var logic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>(false));
            return logic.GetAll();


        }

        public SecurityLoginPoco GetSingleSecurityLogin(string id)
        {
            var logic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>(false));
            return logic.Get(Guid.Parse(id));

        }

        public void RemoveSecurityLogin(SecurityLoginPoco[] pocos)
        {
            var logic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateSecurityLogin(SecurityLoginPoco[] pocos)
        {
            var logic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region SecurityLoginsLog
        public void AddSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {

            var logic = new SecurityLoginsLogLogic(new EFGenericRepository<SecurityLoginsLogPoco>(false));
            logic.Add(pocos);

        }

        public List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog()
        {
            var logic = new SecurityLoginsLogLogic(new EFGenericRepository<SecurityLoginsLogPoco>(false));
            return logic.GetAll();


        }

        public SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string id)
        {
            var logic = new SecurityLoginsLogLogic(new EFGenericRepository<SecurityLoginsLogPoco>(false));
            return logic.Get(Guid.Parse(id));

        }

        public void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            var logic = new SecurityLoginsLogLogic(new EFGenericRepository<SecurityLoginsLogPoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            var logic = new SecurityLoginsLogLogic(new EFGenericRepository<SecurityLoginsLogPoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region SecurityLoginsRole
        public void AddSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {

            var logic = new SecurityLoginsRoleLogic(new EFGenericRepository<SecurityLoginsRolePoco>(false));
            logic.Add(pocos);

        }

        public List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole()
        {
            var logic = new SecurityLoginsRoleLogic(new EFGenericRepository<SecurityLoginsRolePoco>(false));
            return logic.GetAll();


        }

        public SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string id)
        {
            var logic = new SecurityLoginsRoleLogic(new EFGenericRepository<SecurityLoginsRolePoco>(false));
            return logic.Get(Guid.Parse(id));

        }

        public void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            var logic = new SecurityLoginsRoleLogic(new EFGenericRepository<SecurityLoginsRolePoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            var logic = new SecurityLoginsRoleLogic(new EFGenericRepository<SecurityLoginsRolePoco>(false));
            logic.Update(pocos);

        }

        #endregion

        #region SecurityRole
        public void AddSecurityRole(SecurityRolePoco[] pocos)
        {

            var logic = new SecurityRoleLogic(new EFGenericRepository<SecurityRolePoco>(false));
            logic.Add(pocos);

        }

        public List<SecurityRolePoco> GetAllSecurityRole()
        {
            var logic = new SecurityRoleLogic(new EFGenericRepository<SecurityRolePoco>(false));
            return logic.GetAll();


        }

        public SecurityRolePoco GetSingleSecurityRole(string id)
        {
            var logic = new SecurityRoleLogic(new EFGenericRepository<SecurityRolePoco>(false));
            return logic.Get(Guid.Parse(id));

        }

        public void RemoveSecurityRole(SecurityRolePoco[] pocos)
        {
            var logic = new SecurityRoleLogic(new EFGenericRepository<SecurityRolePoco>(false));
            logic.Delete(pocos);

        }

        public void UpdateSecurityRole(SecurityRolePoco[] pocos)
        {
            var logic = new SecurityRoleLogic(new EFGenericRepository<SecurityRolePoco>(false));
            logic.Update(pocos);

        }

        #endregion
    }
}
