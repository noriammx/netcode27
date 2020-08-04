using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAPINetCode27
{
    internal class CorsAuthorizationFilterFactory : IFilterMetadata
    {
        private string v;

        public CorsAuthorizationFilterFactory(string v)
        {
            this.v = v;
        }
    }
}