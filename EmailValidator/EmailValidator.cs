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
            var domain = Email.Split('@')[1].ToLower();
            var isExist = DisposableEmailDomains.DisposabledEmail.Contains(domain);
            if (isExist) return true;
            return false;
        }
        #endregion
    }
}
