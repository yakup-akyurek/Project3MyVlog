using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;

using Microsoft.Extensions.DependencyInjection;


namespace BusinessLayer.Container
{
	public static class Extensions
	{
		public static void ContainerDependencies(this IServiceCollection services)
		{

            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<IArticalDal, EfArticleDal>();
            services.AddScoped<IArticleService, ArticleManager>();

            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<ICommentService, CommentManager>();

            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IContactService, ContactManager>();

            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IAppUserService, AppUserManager>();

        }
    }
}
