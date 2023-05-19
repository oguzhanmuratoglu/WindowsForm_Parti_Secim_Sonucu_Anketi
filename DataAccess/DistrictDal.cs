using Microsoft.EntityFrameworkCore;
using Parti_Secim_Anketi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parti_Secim_Anketi.DataAccess
{
    public class DistrictDal
    {
        public List<District> GetAll()
        {
            using (DistrictContext context = new DistrictContext())
            {
                return context.Districts.ToList();
            }
        }

        public District GetByDistrict(string districtName)
        {
            using (DistrictContext context = new DistrictContext())
            {
                return context.Districts.SingleOrDefault(s => s.Ilce == districtName);
            }
        }

        public void Add(District district)
        {
            using (DistrictContext context = new DistrictContext())
            {
                //contex.Products.Add(product);
                var entity = context.Entry(district);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(District students)
        {
            using (DistrictContext context = new DistrictContext())
            {

                var entity = context.Entry(students);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int districtId)
        {
            using (DistrictContext context = new DistrictContext())
            {

                context.Districts.Remove(new District
                {
                    Id = districtId
                });
                context.SaveChanges();
            }
        }
    }
}
