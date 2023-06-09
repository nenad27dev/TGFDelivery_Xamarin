﻿using System.Collections.ObjectModel;
using TGFDelivery.Models;
using TGFDelivery.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WinPizzaData;
using System.Linq;
using TGFDelivery.Views;

namespace TGFDelivery.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToppingsPage : ContentPage
    {
        public static readonly BindableProperty ProductsProperty = BindableProperty.Create(
               "Products",        // the name of the bindable property
               typeof(ObservableCollection<ToppingsModel>),     // the bindable property type
               typeof(ToppingsPage),   // the parent object type
               null, propertyChanged: OnEventNameChanged);

        static void OnEventNameChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            ((ToppingsPage)bindable).Products = (ObservableCollection<ToppingsModel>)newValue;
        }

        public ObservableCollection<ToppingsModel> Products
        {
            get { return (ObservableCollection<ToppingsModel>)GetValue(ProductsProperty); }
            set { SetValue(ProductsProperty, value); }
        }

        public ToppingsModel PreviousItem { set; get; }

        public ToppingsPage()
        {
            InitializeComponent();    
        }

        private void ItemSelectionEvent(object sender, SelectedItemChangedEventArgs e)
        {
            var currentItem = e.SelectedItem as ToppingsModel;
            if (PreviousItem != null)
            {
                PreviousItem.IsSelected = false;
            }
            if (currentItem != null)
            {
                currentItem.IsSelected = true;
                PreviousItem = currentItem;
            }
           var hh = (ToppingData)BindingContext;
            ToppingListCtr.ItemsSource = hh.Toppings.OrderByDescending(p => p.Order);
        }

        private void BtnReset_Clicked(object sender, System.EventArgs e)
        {
            ToppingListCtr.SelectedItem = null;
            foreach (var item in Products)
            {
                item.Order = 0;
                item.IsSelected = false;
            }
        }

        private void BtnSave_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}