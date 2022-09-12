using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tangy_Business.Repository.IRepository;
using Tangy_DataAccess;
using Tangy_DataAccess.Data;
using Tangy_Models;

namespace Tangy_Business.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public CategoryRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public CategoryDTO Create(CategoryDTO objDTO)
        {
            var obj = _mapper.Map<CategoryDTO, Category>(objDTO);
            obj.CreateDate = DateTime.Now;

            _db.Categories.Add(obj);
            _db.SaveChanges();

            return _mapper.Map<Category, CategoryDTO>(obj);
        }

        public CategoryDTO Get(int id)
        {
            var obj = _db.Categories.FirstOrDefault(u => u.ID == id);

            if (obj != null)
            {
                return _mapper.Map<Category, CategoryDTO>(obj);
            }

            return new CategoryDTO();
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>(_db.Categories);
        }

        public CategoryDTO Update(CategoryDTO objDTO)
        {
            var objFromDB = _db.Categories.FirstOrDefault(u => u.ID == objDTO.ID);

            if (objFromDB != null)
            {
                objFromDB.Name = objDTO.Name;
                _db.Categories.Update(objFromDB);
                _db.SaveChanges();

                return _mapper.Map<Category, CategoryDTO>(objFromDB);
            }

            return objDTO;
        }

        public int Delete(int id)
        {
            var obj = _db.Categories.FirstOrDefault(u => u.ID == id);

            if (obj != null)
            {
                _db.Categories.Remove(obj);
                return _db.SaveChanges();
            }

            return 0;
        }
    }
}
