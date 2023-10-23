using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IProductView
    {
        string ProductId { get; set; }
        string ProductName { get; set; }
        string ProductObservation { get; set; }
        string ProductPrice { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccesful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductListBildingSource(BindingSource productList);
        void Show();
    }
}
