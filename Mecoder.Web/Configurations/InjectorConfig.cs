using Mecoder.Application.IServices;
using Mecoder.Application.Services;
using Mecoder.Infrastructure.IRepositories;
using Mecoder.Infrastructure.Repositories;

namespace Mecoder.Web.Configurations
{
    public static class InjectorConfig
    {
        public static void InjectInfrastructureLayer(this IServiceCollection services)
        {
            services.AddScoped<IQuizRepository, QuizRepository>();
        }

        public static void InjectApplicationLayer(this IServiceCollection services)
        {
            services.AddScoped<IQuizService, QuizService>();
        }
    }
}
