using SmartClinicAPI.Models;


public class UserService : IUserService
{
    private static List<User> users = new() 
    {
        new User { Id = 1, Name = "Rafaa", Role = "Admin" },
        new User { Id = 2, Name = "Dr. Salem", Role = "Doctor" },
        new User { Id = 3, Name = "Layla", Role = "Patient" }
    };
    public List<User> GetAllUsers()
    {
        return users;
    }
    public User? GetUserById(int id)
    {
        return users.FirstOrDefault(u => u.Id == id);
    }
    public void AddUser(User user)
    {
        users.Add(user);
    }
    public bool DeleteUser(int id)
    {
        var user = GetUserById(id);
        if (user != null)
        {
            users.Remove(user);
            return true;
        }
        return false;
    }
}