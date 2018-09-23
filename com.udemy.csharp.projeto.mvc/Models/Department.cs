using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

namespace com.udemy.csharp.projeto.mvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        public Department()
        {

        }
        public Department(string nome)
        {
            Nome = nome;
        }
        public void AddSeller(Seller seller) {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final) {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
