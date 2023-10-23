using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;
using System.Drawing;


namespace Supermarket_mvp.Presenters
{
    internal class ProviderPresenter
    {
        private IProviderView view;
        private IProviderRepository repository;
        private BindingSource providerBindingSource;
        private IEnumerable<ProviderModel> providerList;

        public ProviderPresenter(IProviderView view, IProviderRepository repository)
        {
            this.providerBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProvider;
            this.view.AddNewEvent += AddNewProvider;
            this.view.EditEvent += LoadSelectProviderToEdit;
            this.view.DeleteEvent += DeleteSelectedProvider;
            this.view.SaveEvent += SaveProvider;
            this.view.CancelEvent += CancelAction;

            this.view.SetProviderListBildingSource(providerBindingSource);

            LoadAllProviderList();

            this.view.Show();

        }

        private void LoadAllProviderList()
        {
            providerList = repository.GetAll();
            providerBindingSource.DataSource = providerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProvider(object? sender, EventArgs e)
        {
            var provider = new ProviderModel();
            provider.Id = Convert.ToInt32(view.ProviderId);
            provider.Name = view.ProviderName;
            provider.Observation = view.ProviderObservation;

            try
            {
                new Common.ModelDataValidation().Validate(provider);
                if (view.IsEdit)
                {
                    repository.Edit(provider);
                    view.Message = "Provider edited successfuly";
                }
                else
                {
                    repository.Add(provider);
                    view.Message = "Provider added successfuly";
                }
                view.IsSuccesful = true;
                LoadAllProviderList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProviderId = "0";
            view.ProviderName = "";
            view.ProviderObservation = "";
        }

        private void DeleteSelectedProvider(object? sender, EventArgs e)
        {
            try
            {
                var provider = (ProviderModel)providerBindingSource.Current;

                repository.Delete(provider.Id);
                view.IsSuccesful = true;
                view.Message = "Provider deleted successfully";
                LoadAllProviderList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could ot delete provider";
            }
        }

        private void LoadSelectProviderToEdit(object? sender, EventArgs e)
        {
            var provider = (ProviderModel)providerBindingSource.Current;

            view.ProviderId = provider.Id.ToString();
            view.ProviderName = provider.Name;
            view.ProviderObservation = provider.Observation;

            view.IsEdit = true;
        }

        private void AddNewProvider(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProvider(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providerList = repository.GetAll();
            }
            providerBindingSource.DataSource = providerList;
        }
    }
}
