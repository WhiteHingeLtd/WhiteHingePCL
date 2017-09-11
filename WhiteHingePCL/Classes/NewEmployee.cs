using System;
using System.Collections.Generic;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class NewEmployee
    {
        /// <summary>
        /// The user's ID, as displayed in the User's card
        /// </summary>
        public int UserId;
        /// <summary>
        /// User's First Name
        /// </summary>
        public string FirstName;
        /// <summary>
        /// User's Surname
        /// </summary>
        public string Surname;
        /// <summary>
        /// The MD5 Hashed pin of the user 
        /// </summary>
        public string HashedPin; 
        /// <summary>
        /// Timeout in seconds
        /// </summary>
        public int Timeout; //Timeout in seconds

        /// <summary>
        /// The Active Directory user account for this user
        /// </summary>
        public string AdUser;
        /// <summary>
        /// 
        /// </summary>
        public bool IsSupervisor;
        /// <summary>
        /// 
        /// </summary>
        public int PayrollId => UserId;
        /// <summary>
        /// The user's full name
        /// </summary>
        public string Fullname => FirstName + " " + Surname;
        /// <summary>
        /// Constructor for use with SelectDataDictionary
        /// </summary>
        /// <param name="sqlData"></param>
        public NewEmployee(Dictionary<string, object> sqlData)
        {
            UserId = Convert.ToInt32(sqlData["PayrollNo"]);
            FirstName = sqlData["FirstName"].ToString();
            Surname = sqlData["Surname"].ToString();
            Visible = Convert.ToInt32(sqlData["NotShowOnTable"]) != 1;
            HashedPin = sqlData["HashedPin"].ToString();
            AdUser = sqlData["ActiveDirectoryUser"].ToString();
            IsSupervisor = Convert.ToBoolean(sqlData["IsSupervisor"]);
            try
            {
                Timeout = Convert.ToInt32(sqlData["LoginTimeout"]);
            }
            catch (Exception )
            {
                Timeout = 300;
            }
        }
        /// <summary>
        /// Paramless constructor for future EF use
        /// </summary>
        public NewEmployee()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        public bool Visible;

    }

}
