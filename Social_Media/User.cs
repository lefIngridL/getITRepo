namespace Social_Media;

public class User
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Birthday { get; set;}
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Username { get; set; }
    public string Description { get; set; }


    public User(string name, string gender, int birthday, string email, string password, string phone, string username, string description)
    {
        Name = name;
        Gender = gender;
        Birthday = birthday;
        Email = email;
        Password = password;
        Phone = phone;
        Username = username;
        Description = description;
    }

    List<User> FriendList = new List<User>();

    public void AddFriend(User friend)
    {
        FriendList.Add(friend);
    }

    public void RemoveFriend()
    {

    }
}