using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace RestApisWithAspNet.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnricher(ResultExecutingContext context);

        Task Enrich(ResultExecutingContext context);
    }
}