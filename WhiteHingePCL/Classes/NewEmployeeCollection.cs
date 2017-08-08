using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// A New Employee Collection
    /// </summary>
    [ComVisible(false)]
    public class NewEmployeeCollection : List<NewEmployee>
    {
        /// <summary>
        /// For finding user by their UserId
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public NewEmployee FindUserById(int employeeId)
        {
            return this.Single(x => x.PayrollId == employeeId);
        }
        /// <summary>
        /// For finding a user based on their active directory name. Case-insensitive
        /// </summary>
        /// <param name="directoryUser"></param>
        /// <returns></returns>
        public NewEmployee FindUserByActiveDirectoryName(string directoryUser)
        {
            return this.Single(x => string.Equals(x.AdUser, directoryUser, StringComparison.CurrentCultureIgnoreCase));
        }
        /// <summary>
        /// Sorts the Collection by Surname
        /// </summary>
        public void SortBySurname()
        {
            this.Sort((x,y) => string.Compare(x.Surname, y.Surname, StringComparison.Ordinal));
        }
        /// <summary>
        /// Sorts the collection by Id
        /// </summary>
        public void SortById()
        {
            this.Sort((x,y) => x.PayrollId.CompareTo(y.PayrollId));
        }
        /// <summary>
        /// Constructor for use with SelectDataDictionary
        /// </summary>
        /// <param name="sqlData"></param>
        public NewEmployeeCollection(List<Dictionary<string, object>> sqlData)
        {
            foreach (var result in sqlData)
            {
                this.Add(new NewEmployee(result));
            }
        }
        /// <summary>
        /// Json Constructor for the NewEmpColl
        /// </summary>
        [JsonConstructor]
        public NewEmployeeCollection()
        {
            
        }
    }
}
