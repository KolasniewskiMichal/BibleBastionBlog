using BibleBastionBlog.Domain.Interfaces;
using BibleBastionBlog.Infrastructure.Persistence;
using BibleBastionBlog.Infrastructure.Repositores;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBastionBlog.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BibleBastionBlogDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("BibleBastion")));

            services.AddScoped<IArticleRepository, ArticleRepository>();
        }
    }
}
