using BasicFBGraphApi.Models;

namespace BasicFBGraphApi.GraphService
{
    public interface IGraphApi
    {
        FacebookData GetProperties(string token);
    }
}
