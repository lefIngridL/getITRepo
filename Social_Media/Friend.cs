namespace Social_Media;

public class Friend
{
    public string Name { get; set; }
    public string Birthday { get; set; }
    
    public string Email { get; set; }
    public string Phone { get; set; }

    public string Gender { get; set; }

    public Friend(string name, string birthday, string email, string phone, string gender)
    {
        Name = name;
        Birthday = birthday;
        Email = email;
        Phone = phone;
        Gender = gender;
    }
}