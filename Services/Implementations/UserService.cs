using SmartClinicAPI.Models;


public class UserService : IUserService
{ //user service interface implementation
    private static List<User> users = new() //list of users
    {
        new User { Id = 1, Name = "Rafaa", Role = "Admin" },
        new User { Id = 2, Name = "Dr. Salem", Role = "Doctor" },
        new User { Id = 3, Name = "Layla", Role = "Patient" }
    };
    public List<User> GetAllUsers()
    {
        return users;//returns users list
    }
    public User? GetUserById(int id)
    {
        return users.FirstOrDefault(u => u.Id == id);//returns user by ID
    }
    public void AddUser(User user)
    {
        users.Add(user); //adds new user to the list
    }
    public bool DeleteUser(int id)
    {
        var user = GetUserById(id);//deletes user returned by GetUserById
        if (user != null)
        {
            users.Remove(user);
            return true;
        }
        return false;
    }
}