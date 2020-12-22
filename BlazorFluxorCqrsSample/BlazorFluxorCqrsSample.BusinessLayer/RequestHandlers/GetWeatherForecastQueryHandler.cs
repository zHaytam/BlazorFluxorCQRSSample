using BlazorFluxorCqrsSample.Shared.Requests;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorFluxorCqrsSample.BusinessLayer.RequestHandlers
{
    public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQuery, GetWeatherForecastResponse>
    {
        public Task<GetWeatherForecastResponse> Handle(GetWeatherForecastQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
