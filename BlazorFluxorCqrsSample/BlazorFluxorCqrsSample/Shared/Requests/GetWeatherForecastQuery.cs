using MediatR;

namespace BlazorFluxorCqrsSample.Shared.Requests
{
	public record GetWeatherForecastQuery(int NumberOfItems) : IRequest<GetWeatherForecastResponse>;
}
