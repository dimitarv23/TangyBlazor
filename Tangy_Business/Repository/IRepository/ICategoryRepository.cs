using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Tangy_Models;

namespace Tangy_Business.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public CategoryDTO Create(CategoryDTO objDTO); //Post request
        public CategoryDTO Update(CategoryDTO objDTO); //Put request
        public int Delete(int id); //Delete request
        public CategoryDTO Get(int id); //Get request (for 1 object)
        public IEnumerable<CategoryDTO> GetAll(); //Get request (for all)
    }
}
