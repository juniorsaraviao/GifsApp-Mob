using Acr.UserDialogs;
using GifsApp.Model;
using GifsApp.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GifsApp.ViewModel
{
   public class MainPageViewModel : BaseViewModel
   {
      private string      _searchText;
      private GifsService _gifsService;

      public string SearchText
      {
         get => _searchText;
         set
         {
            _searchText = value;
            OnPropertyChanged();
         }
      }

      private IList<Data> _gifList;

      public IList<Data> GifList
      {
         get => _gifList;
         set 
         { 
            _gifList = value;
            OnPropertyChanged();
            OnPropertyChanged( "DisplayList" );
         }
      }

      public bool DisplayList => GifList != null && GifList.Count > 0;

      public ICommand SearchCommand => new Command<string>( async ( search ) => await SearchMethod( search ) );

      public MainPageViewModel()
      {
         GifList      = new List<Data>();
         _gifsService = new GifsService();
      }

      private async Task SearchMethod( string value)
      {
         if ( !string.IsNullOrEmpty( value ) )
         {            
            GifList.Clear();
            using (UserDialogs.Instance.Loading())
            {
               try
               {
                  SearchText  = string.Empty;
                  var data    = await _gifsService.GetGifs(value);
                  GifList     = data.Data;
               }
               catch (Exception ex)
               {
                  Console.WriteLine("This" + ex);
               }
            }            
         }
         else
         {
            return;
         }
      }

   }
}
