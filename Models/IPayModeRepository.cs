using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IPayModeRepository
    {
        void Add(PayModeModel payModeModel);
        void Edit(PayModeModel payModeModel);
        void Delete(int id);
        IEnumerable<PayModeModel> GetAll();
        IEnumerable<PayModeModel> Get(string value);
    }
}
