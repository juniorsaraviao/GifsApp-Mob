using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GifsApp.Model
{
   public class Gif
   {
      public IList<Data> Data { get; set; }      
   }

   public class Data
   {
      public string Title { get; set; }
      public Images Images { get; set; }
      public Color MainColor 
      {
         get
         {
            var rnd = new Random();
            return Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
         }
      }
      public Color SecondColor 
      {
         get
         {
            var rnd = new Random();
            return Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
         }
      }
   }

   public class Images
   {
      public Downsized downsized { get; set; }
      public Downsized_Large downsized_large { get; set; }
      public Downsized_Medium downsized_medium { get; set; }
      public Downsized_Small downsized_small { get; set; }
      public Downsized_Still downsized_still { get; set; }
   }

   public class Downsized
   {
      public string height { get; set; }
      public string width { get; set; }
      public string size { get; set; }
      public string url { get; set; }
   }

   public class Downsized_Large
   {
      public string height { get; set; }
      public string width { get; set; }
      public string size { get; set; }
      public string url { get; set; }
   }

   public class Downsized_Medium
   {
      public string height { get; set; }
      public string width { get; set; }
      public string size { get; set; }
      public string url { get; set; }
   }

   public class Downsized_Small
   {
      public string height { get; set; }
      public string width { get; set; }
      public string mp4_size { get; set; }
      public string mp4 { get; set; }
   }

   public class Downsized_Still
   {
      public string height { get; set; }
      public string width { get; set; }
      public string size { get; set; }
      public string url { get; set; }
   }
}
