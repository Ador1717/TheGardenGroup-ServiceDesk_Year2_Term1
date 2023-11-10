using DAL;
using Model;
using MongoDB.Bson;

namespace Services;

public class UserService
{
    private readonly UserDAO _userDAO;

    public UserService()
    {
        _userDAO = new UserDAO();
    }

    public User GetUserByEmail(string email)
    {
        // additional business logic if needed
        return _userDAO.GetUserByEmail(email);
    }

    public User GetUserByUsername(string username)
    {
        return _userDAO.GetByUsername(username);
    }


    public void AddUser(string email, string userName, string name, string password,
        UserType userType, string phoneNumber, string location)
    {
        BsonDocument? user = _userDAO.AddUser(email, name, userType, phoneNumber, location);
        //if (user != null) UserDAO.userCollection.InsertOne(user);
    }

    public bool UserExists(string email)
    {
        return _userDAO.UserExists(email);
    }

    public bool UpdateUserPassword(string email, string hashedPassword)
    {
        return _userDAO.HashedPassword(email, hashedPassword);
    }
}