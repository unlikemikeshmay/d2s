
using System.Text.Json.Serialization;

namespace bulkybook.Models;

public class OAuthResponse{
    [JsonPropertyName("access_token")]
    public string? access_token {get;set;}

    [JsonPropertyName("token_type")]
    public string? token_type {get;set;}

    [JsonPropertyName("expires_in")]
    public long? expires_in {get;set;}

    [JsonPropertyName("refresh_token")]
    public string? refresh_token {get;set;}

    [JsonPropertyName("refresh_expires_in")]
    public int? refresh_expires_in {get;set;}

    [JsonPropertyName("membership_id")]
    public string? membership_id {get;set;}


}