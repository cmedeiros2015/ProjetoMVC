using com.udemy.csharp.projeto.mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.udemy.csharp.projeto.mvc.Services
{
    public class SellerService
    {
        private readonly csharpprojetomvcContext _context;

        public SellerService(csharpprojetomvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
