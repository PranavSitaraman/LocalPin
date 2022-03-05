using LocalPin.Shared.UserManagement;
using SamuelLihn.UserManagement.Models;

namespace LocalPin.Backend.UserManagement.Models
{
    public static class LoginModelExt
    {
        public static EmailPassCredential GetCredential(this LoginModel model)
        {
            return new EmailPassCredential(null!, model.Email, model.Password);
        }
    }
}