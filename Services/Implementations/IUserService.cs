using SmartClinicAPI.Models;
public interface IUserService //----
{
    List<User> GetAllUsers();
    User? GetUserById(int id);
    void AddUser(User user);
    bool DeleteUser(int id);
}