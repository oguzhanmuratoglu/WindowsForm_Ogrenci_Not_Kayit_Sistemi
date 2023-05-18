using Microsoft.EntityFrameworkCore;
using Ogrenci_Not_Kayit_Sistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Not_Kayit_Sistemi.DataAccess
{
    public class StudentsDal
    {
        public List<Students> GetAll()
        {
            using (StudentsContext context = new StudentsContext())
            {
                return context.Students.ToList();
            }
        }

        public Students GetByNumber(int studentNumber)
        {
            using (StudentsContext context = new StudentsContext())
            {
                return context.Students.SingleOrDefault(s=>s.Numara== studentNumber);
            }
        }

        public bool IsContainsNumber(int studentNumber)
        {
            using (StudentsContext context = new StudentsContext())
            {
                var all = context.Students.ToList();
                bool varMi = false;
                foreach (var item in all)
                {
                    if (item.Numara== studentNumber)
                    {
                        varMi = true;
                        break;
                    }                   
                }
                return varMi;
            }
        }

        public void Add(Students students)
        {
            using (StudentsContext context = new StudentsContext())
            {
                //contex.Products.Add(product);
                var entity = context.Entry(students);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Students students)
        {
            using (StudentsContext context = new StudentsContext())
            {

                var entity = context.Entry(students);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int studentId)
        {
            using (StudentsContext context = new StudentsContext())
            {

                context.Students.Remove(new Students
                {
                    Id=studentId
                });
                context.SaveChanges();
            }
        }
    }
}
