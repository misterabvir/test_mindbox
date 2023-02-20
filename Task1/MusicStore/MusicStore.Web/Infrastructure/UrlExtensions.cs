namespace MusicStore.Web.Infrastructure;

public static class UrlExtensions
{
    public static string PathAndQuerry(this HttpRequest request) => 
        request.QueryString.HasValue 
        ? $"{request.Path}{request.QueryString}" 
        : $"{request.Path}";
}
