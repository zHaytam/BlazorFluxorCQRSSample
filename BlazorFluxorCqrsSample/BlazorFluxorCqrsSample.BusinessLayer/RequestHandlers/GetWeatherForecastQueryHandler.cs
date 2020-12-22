using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator;

namespace BlazorFluxorCqrsSample.BusinessLayer.RequestHandlers
{
    public class GetWeatherForecastQueryHandler: IRequestHandler<GetWeatherForecastQuery, GetWeatherForecastQueryResponse>
    {
    }
}
