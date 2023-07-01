using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quizer.Core.Repositories.Special;
using Quizer.DataAccess.Persistance;
using Quizer.DataAccess.Repositories;

namespace Quizer.DataAccess
{
    public static class DataAccessInjection
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<DbContext, QuizerDbContext>();

            #region Register All Repositories
            services.AddScoped<IAnswerRepository, AnswerRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IQuestionSetRepository, QuestionSetRepository>();
            services.AddScoped<ISessionContentRepository, SessionContentRepository>();
            services.AddScoped<ISessionRepository, SessionRepository>();
            services.AddScoped<ISubscriberRepository, SubscriberRepository>();
            #endregion


            return services;
        }
    }
}
