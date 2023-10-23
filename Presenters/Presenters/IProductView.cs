namespace Supermarket_mvp.Presenters.Presenters
{
    internal interface IProductView
    {
        Action<object?, EventArgs> SearchEvent { get; set; }
        Action<object?, EventArgs> AddNewEvent { get; set; }
        Action<object?, EventArgs> EditEvent { get; set; }
        Action<object?, EventArgs> DeleteEvent { get; set; }
        Action<object?, EventArgs> SaveEvent { get; set; }
        Action<object?, EventArgs> CancelEvent { get; set; }

        void SetProductListBildingSource(BindingSource productBindingSource);
        void Show();
    }
}