namespace bulkybook.Models;

public class GetUserMembershipData
{
    public UserMembershipData Response {get;set;}
    public Int32 ErrorCode {get;set;}
    public Int32 ThrottleSeconds {get;set;}
    public string ErrorStatus {get;set;}
    public string Message {get;set;}
    public Dictionary<string,string> MessageData {get;set;}
    public string DetailedErrorTrace {get;set;}
}