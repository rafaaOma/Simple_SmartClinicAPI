using SmartClinicAPI.Models;
public interface IUserService //an interface for user service
{
    List<User> GetAllUsers();
    User? GetUserById(int id);
    void AddUser(User user);
    bool DeleteUser(int id);
}