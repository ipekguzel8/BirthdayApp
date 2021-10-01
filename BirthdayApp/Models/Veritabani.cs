using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, DavetiyeModel> _liste;
        static Veritabani()
        {
            _liste = new Dictionary<string, DavetiyeModel>();
            _liste.Add("Hasan", new DavetiyeModel
            {
                Ad = "Hasan",
                Eposta = "hasan@gmail.com",
                KatilmaDurumu = true
            });
            _liste.Add("Mehmet", new DavetiyeModel
            {
                Ad = "Mehmet",
                Eposta = "mehmet@gmail.com",
                KatilmaDurumu = false
            });
            _liste.Add("Berrin", new DavetiyeModel
            {
                Ad = "Berrin",
                Eposta = "berrin@gmail.com",
                KatilmaDurumu = true
            });
        }

        internal static IEnumerable<DavetiyeModel> Liste(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        public static void Add(DavetiyeModel davetiyeModel)
        {
            string key = davetiyeModel.Ad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = davetiyeModel;
            }
            else
            {
                _liste.Add(key, davetiyeModel);
            }
        }
        public static IEnumerable<DavetiyeModel> Liste()
        {
             return _liste.Values; 
        }
    }
}