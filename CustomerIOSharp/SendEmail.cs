namespace CustomerIOSharp
{
  using System;

  internal class SendEmail
  {
    public string TransactionalMessageId { get; set; }
    public string To { get; set; }
    public object Identifiers { get; set; }
    public object MessageData { get; set; }
    public string Bcc { get; set; }
  }
}