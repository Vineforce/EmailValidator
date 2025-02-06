namespace Vineforce
{
    public class EmailValidator
    {
        #region IsDisposableEmail
        /// <summary>
        ///  IsDisposableEmail 
        /// </summary>
        /// <param name="Email"></param>
        /// <returns>Bool</returns>
        public bool IsDisposableEmail(string Email)
        {
            var domain = Email.Split('@')[1].ToLower();
            List<string> emailList = DisposableEmailDomains.DisposabledEmail;
            var isExist = emailList.Contains(domain);
            if (isExist) return true;
            return false;
        }
        #endregion
    }
}
