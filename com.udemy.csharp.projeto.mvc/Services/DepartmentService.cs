using com.udemy.csharp.projeto.mvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace com.udemy.csharp.projeto.mvc.Services
{
    public class DepartmentService
    {
        private readonly csharpprojetomvcContext _context;

        public DepartmentService(csharpprojetomvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Nome).ToList();
        }
    }
}
