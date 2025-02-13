using System.Text.RegularExpressions;

namespace Vineforce
{
    public class EmailValidator
    {
        #region IsDisposableEmail
        /// <summary>
        ///  Validate whether the domain of your email address is disposable or not. 
        /// </summary>
        /// <param name="Email">Enter your email address</param>
        /// <returns>Bool</returns>
        public bool IsDisposableEmail(string Email)
        {
            try
            {
                if (!IsValidEmail(Email))
                {
                    throw new ArgumentException("The provided email address is invalid.");
                }
                var domain = Email.Split('@')[1].ToLower();
                var isExist = DisposableEmailDomains.DisposabledEmail.Contains(domain);
                if (isExist) return true;
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        ///  Validate the email enter by user
        /// </summary>
        /// <param name="email">Enter your email address </param>
        /// <returns>Bool</returns>
        private static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        #endregion
    }
}
