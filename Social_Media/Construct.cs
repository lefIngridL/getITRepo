namespace Social_Media;

public class Construct
{
    private readonly List<string> genders = new List<string>()
    {
        "Man", "Woman", "Genderfluid", "nonbinary"
    };

    public IReadOnlyList<string> Genders => genders;
    public static Friend makeFriend()
    {
        Console.WriteLine("HELLO");
        string name = String.Empty;
        Console.WriteLine("oppgi navn på ny venn:");
        name = Console.ReadLine();
        string gender = String.Empty;
        Console.WriteLine("oppgi kjønn som et tall 1-5 fra listen under:");
        foreach (var VARIABLE in COLLECTION)
        {
            
        }
        string birthday = String.Empty;
        string email = String.Empty;
        string phone = String.Empty;
        Friend newFriend = new Friend($"{name}", $"{birthday}", $"{email}", $"{phone}",$"{gender}" );
        return newFriend;
    }
}