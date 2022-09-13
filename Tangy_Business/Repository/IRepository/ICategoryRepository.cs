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
        public Task<CategoryDTO> Create(CategoryDTO objDTO); //Post request
        public Task<CategoryDTO> Update(CategoryDTO objDTO); //Put request
        public Task<int> Delete(int id); //Delete request
        public Task<CategoryDTO> Get(int id); //Get request (for 1 object)
        public Task<IEnumerable<CategoryDTO>> GetAll(); //Get request (for all)
    }
}
