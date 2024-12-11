using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IArticleService:IGenericService<Article>
	{
        List<Article> TArticlelistWithCategory();
        List<Article> TArticleListWithCategoryAndAppUser();
        public Article TGetLastArticle();
        public List<Article> TGetArticlesByAppUserId(int id);
    }
}
