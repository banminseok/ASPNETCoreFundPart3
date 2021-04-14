//[!] 개체 형식을 세션에 저장하고 읽어오기
//https://docs.microsoft.com/ko-kr/aspnet/core/fundamentals/app-state
using Microsoft.AspNetCore.Http;
using System.Text.Json;

public static class SessionExtensions
{
    public static void Set<T>(this ISession session, string key, T value)
    {
        session.SetString(key, JsonSerializer.Serialize(value));
    }

    public static T Get<T>(this ISession session, string key)
    {
        var value = session.GetString(key);
        return value == null ? default : JsonSerializer.Deserialize<T>(value);
    }
}