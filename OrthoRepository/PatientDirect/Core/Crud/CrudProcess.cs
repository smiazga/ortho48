using System.Collections.Generic;
using System.Linq;

namespace ortho48.OrthoRepository.PatientDirect.Core.Crud
{
    public class CrudProcess
    {
        private static readonly List<Crud> AllCruds = new List<Crud>()
        {
            new Crud { Id = 1, Text = "Text1", UserId = 1},
            new Crud { Id = 2, Text = "Text2", UserId = 1},
            new Crud { Id = 3, Text = "Text3", UserId = 2}
        };

        public Crud GetCrud(int id)
        {
            return AllCruds.FirstOrDefault(x => x.Id == id);
        }

        public List<Crud> GetCrudsByUserId(int userId)
        {
            return AllCruds.Where(x => x.UserId == userId).ToList();
        }
        public List<Crud> GetAllCruds()
        {
            return AllCruds;
        }

        public void CreateCrud(Crud item)
        {
            item.Id = AllCruds.Max(x => x.Id) + 1;
            AllCruds.Add(item);
        }

        public void UpdateCrud(int id, Crud item)
        {
            var crud = AllCruds.FirstOrDefault(x => x.Id == id);
            if (crud != null)
            {
                crud.Text = item.Text;
                crud.UserId = item.UserId;
            }
        }

        public void DeleteCrud(int id)
        {
            var crud = AllCruds.FirstOrDefault(x => x.Id == id);
            if (crud != null)
            {
                AllCruds.Remove(crud);
            }
        }
    }
}