
namespace Claims_Application.Structures
{
   //Structure to Represent records in the Account Table
   public struct Account
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
    }
}