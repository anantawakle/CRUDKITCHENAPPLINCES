using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CRUDKITCHENAPPLINCES
{
    public class Kitchenapplinces
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Company { get; set; }

    }
    public class KitchenapplincesCRUD
    {
        private List<Kitchenapplinces> kitchenapplinceslist;
        public KitchenapplincesCRUD()
        {
            kitchenapplinceslist = new List<Kitchenapplinces>()
            {
                new Kitchenapplinces { Id = 1, Name = "Waterpurifier", Price = 18000, Company = "Pureit" },
                new Kitchenapplinces { Id = 2, Name = "Refrigerator", Price = 28000, Company = "haier" }
            };
        }
        public List<Kitchenapplinces> GetKitchenapplinces()
        {
            return kitchenapplinceslist;
        }
        // get single kitchenapplinces//
        public Kitchenapplinces GetKitchenapplincesById(int id)
        {
            // search for id in the collection//
            Kitchenapplinces kitchenapplinces = new Kitchenapplinces();
            foreach (Kitchenapplinces k in kitchenapplinceslist)
            {
                if (k.Id == id)
                {
                    kitchenapplinces = k;
                    break;
                }
            }
            return kitchenapplinces;
        }
        // add new kitchenapplinces//
        public void AddKitchenapplinces(Kitchenapplinces k)
        {
            kitchenapplinceslist.Add(k);
        }
        // modify the kitchenapplinces//
        public void UpdateKitchenapplinces(Kitchenapplinces k)
        {
            foreach (Kitchenapplinces item in kitchenapplinceslist)
            {
                if (item.Id == k.Id)
                {
                    item.Id = k.Id;
                    item.Name = k.Name;
                    item.Price = k.Price;
                    item.Company = k.Company;
                    break;
                }
            }
        }
        // remove kitchenapplinces//
        public void DeletKichenapllinces(int id)
        {
            foreach (Kitchenapplinces item in kitchenapplinceslist)
            {
                if (item.Id == id)
                {
                    kitchenapplinceslist.Remove(item);
                    break;
                }
            }
        }
    }
}

