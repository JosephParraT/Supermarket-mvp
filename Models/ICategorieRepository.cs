using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ICategorieRepository
    {

        void Add(CategorieModel categorieModel);
        void Edit(CategorieModel categorieModel);
        void Delete(int id);
        IEnumerable<CategorieModel> GetAll();
        IEnumerable<CategorieModel> GetByValue(string value);
    }
}
