using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_Tracker.Models
{
    public class CategoryDataAcessLayer
    {
          CategoryDBContext db = new CategoryDBContext();
        public IEnumerable<Category> GetAllExpenses()
        {
            try
            {
                return db.Category.ToList();
            }
            catch
            {
                throw;
            }
        }

        // To filter out the records based on the search string 
        public IEnumerable<Category> GetSearchResult(string searchString)
        {
            List<Category> exp = new List<Category>();
            try
            {
                exp = GetAllExpenses().ToList();
                return exp.Where(x => x.Name.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) != -1);
            }
            catch
            {
                throw;
            }
        }

        //To Add new Expense record       
        public void Category(Category expense)
        {
            try
            {
                db.Category.Add(expense);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar expense  
        public int UpdateExpense(Category expense)
        {
            try
            {
                db.Entry(expense).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the data for a particular expense  
        public Category GetExpenseData(int id)
        {
            try
            {
                Category expense = db.Category.Find(id);
                return expense;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular expense  
        public void DeleteCategory(int id)
        {
            try
            {
                Category emp = db.Category.Find(id);
                db.Category.Remove(emp);
                db.SaveChanges();

            }
            catch
            {
                throw;
            }
        }
        internal object GetAllCategory()
        {
            throw new NotImplementedException();
        }
    }
}
