using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GifsApp.ViewModel
{
   public class MainPageViewModel : BaseViewModel
   {
      private string _searchText;

      public string SearchText
      {
         get => _searchText;
         set
         {
            _searchText = value;
            OnPropertyChanged();
         }
      }

      public ICommand SearchCommand => new Command<string>( async ( search ) => await SearchMethod( search ) );

      private async Task SearchMethod( string value)
      {
         if ( !string.IsNullOrEmpty( value ) )
         {
            SearchText = string.Empty;
         }


      }

   }
}
