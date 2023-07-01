using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quizer.Application.Services;
using Quizer.Core.Services;
using Quizer.DataAccess;


namespace Quizer.Application
{
    public static class BussinessLogicInjection
    {
        public static IServiceCollection AddBussinessLogic(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDataAccess(configuration);

            #region Register Services

            services.AddScoped<IQuestionSetService, QuestionSetService>(); 
            services.AddScoped<IQuestionService, QuestionService>();

            #endregion

            return services;
        }
    }
}
