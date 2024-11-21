using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ArticleManager : IArticleService
	{
		private readonly IArticalDal _articalDal;

		public ArticleManager(IArticalDal articalDal)
		{
			_articalDal = articalDal;
		}

        public List<Article> TArticlelistWithCategory()
        {
            return _articalDal.ArticlelistWithCategory();
        }

        public List<Article> TArticleListWithCategoryAndAppUser()
        {
            return _articalDal.ArticleListWithCategoryAndAppUser();
        }

        public void TDelete(int id)
		{
			_articalDal.Delete(id);
		}

		public List<Article> TGetAll()
		{
			return _articalDal.GetAll();
		}

		public Article TGetById(int id)
		{
			return _articalDal.GetById(id);
		}

		public void TInsert(Article entity)
		{
			_articalDal.Insert(entity);
		}

		public void TUpdate(Article entity)
		{
			if (entity.Description!="" && entity.Title.Length>=5 && entity.Title.Length<=100)
			{
				_articalDal.Update(entity);
			}
			else
			{
				//hata mesajı
			}
		}
	}
}
