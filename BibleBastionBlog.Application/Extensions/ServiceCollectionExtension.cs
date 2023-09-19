using BibleBastionBlog.Application.Mappings;
using BibleBastionBlog.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BibleBastionBlog.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            services.AddAutoMapper(typeof(BibleBastionBlogMappingProfile));

        }
    }
}
