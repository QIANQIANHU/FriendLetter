namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }
  }
}
