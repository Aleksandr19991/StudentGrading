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

    }
}
