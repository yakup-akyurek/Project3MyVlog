using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IArticalDal:IGenericDal<Article>
    {
        List<Article> ArticlelistWithCategory();
        List<Article> ArticleListWithCategoryAndAppUser();
        Article GetLastArticle();
        List<Article> GetArticlesByAppUserId(int id);
    }

}
