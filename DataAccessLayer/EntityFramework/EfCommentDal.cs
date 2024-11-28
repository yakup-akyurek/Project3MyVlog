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
	public class EfCommentDal : GenericRepository<Comment>, ICommentDal
	{
		public EfCommentDal(SensiveContext context) : base(context)
		{
		}

        public List<Comment> GetCommentsByArticle(int id)
        {
            var context = new SensiveContext();
            var values=context.Comments.Where(x=>x.ArticleId==id).Include(y=>y.Article).Include(z=>z.AppUser).ToList();
            return values;
        }
    }
}
