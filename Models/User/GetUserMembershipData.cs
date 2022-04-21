using System.Text.Json.Serialization;

namespace bulkybook.Models;

public class GetUserMembershipData
{
    [JsonPropertyName("Response")]
    public UserMembershipData Response {get;set;}
    [JsonPropertyName("ErrorCode")]
    public Int32 ErrorCode {get;set;}
    [JsonPropertyName("ThrottleSeconds")]
    public Int32 ThrottleSeconds {get;set;}
     [JsonPropertyName("ErrorStatus")]
    public string ErrorStatus {get;set;}
    [JsonPropertyName("Message")]
    public string Message {get;set;}
    [JsonPropertyName("MessageData")]
    public Dictionary<string,string> MessageData {get;set;}
    [JsonPropertyName("DetailedErrorTrace")]
    public string DetailedErrorTrace {get;set;}
}