using StudentGrading.Models;
using StudentGrading.Models.Dtos;

namespace DAL
{
    public class UserRepository
    {
        Context context = new();

        //public int AddUser(UserDto user)
        //{
        //    var role = GetUserRole(2); //получаем Ид роли
        //    user.Role = role;          //добавляем рольИд в юзер 
        //    context.Users.Add(user);
        //    context.SaveChanges();
        //    return user.Id;
        //}


        //public UserDto GetInfoForAuthorise(string email)
        //{
        //    var authorizeUser = context.Users.Where(s => s.Email == email).
        //       Include(b => b.Role).FirstOrDefault();

        //    return authorizeUser;
        //}

        //public UserRoleDto GetUserRole(Guid id) 
        //{
        //    var role = context.UserRoles.Where(s => s.Id == id).FirstOrDefault();
        //    return role;
        //}

        //public bool GetInfoForRegistration(string email)
        //{
        //    try
        //    {
        //        return context.Users.Any(a => a.Email == email);
        //    }
        //    catch
        //    {
        //        return true;
        //    }
        //}

    }
}
