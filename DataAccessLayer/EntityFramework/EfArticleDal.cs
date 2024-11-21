using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfArticleDal : GenericRepository<Article>, IArticalDal
	{
		public EfArticleDal(SensiveContext context) : base(context)
		{
		}

        public List<Article> ArticlelistWithCategory()
        {
            var context = new SensiveContext();
            var values = context.Articles.Include(x => x.Category).ToList();
            return values;
        }

        public List<Article> ArticleListWithCategoryAndAppUser()
        {
            var context = new SensiveContext();
            var values =context.Articles.Include(x=>x.Category).Include(y=>y.AppUser).ToList();
            return values;
        }
    }
}
