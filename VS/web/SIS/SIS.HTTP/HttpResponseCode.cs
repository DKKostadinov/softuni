namespace SIS.HTTP
{
    public enum HttpResponseCode
    {
        OK = 200,
        MovedPermanently = 301,
        Found = 302,
        TemporaryRedirect = 307,
        Unathorized = 401,
        Forbidden = 403,
        NotFound = 404,
        NotImplemented = 501,
        InternalServerError = 500,
    }
}