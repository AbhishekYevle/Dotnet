// Abstract Method
public class MailService
{
  public void sendMail()
  {
    connect();
    authneticate();
    disconnect();


  }

  private void connect()
  {
    System.Console.WriteLine("Connect");
  }

  private void disconnect()
  {
    System.Console.WriteLine("Disconnect");
  }

  private void authneticate()
  {
    System.Console.WriteLine("Authenticate");
  }
}
