using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FluentApi.Domain.Services
{
    public static class ImageService
    {
        private static HttpClient _httpClient=new HttpClient();
        public static async Task<string> GetImagePath(string name)
        {
            //var response=await _httpClient.GetAsync($"https://www.pinterest.com/search/pins/?q={name}");
            //var str=await response.Content.ReadAsStringAsync();
            ////https://s.pinimg.com/images/facebook_share_image.png
            //var text = "https://s.pinimg.com/images/";
            //var index = str.LastIndexOf(text);

            //int lastIndex = -1;
            //for (int i = index;; i++)
            //{
            //    if (str[i]=='.' && str[i+1] == 'p' 
            //        && str[i+2] == 'n' && str[i+3] == 'g')
            //    {
            //        lastIndex = i + 4;
            //        break;
            //    }
            //}

            //var result=(str.Substring(index, lastIndex-index));

            return "";
        }
    }
}
