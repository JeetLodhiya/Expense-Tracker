using Expense_Tracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Controllers
{
    public class IActionResult : Controller
    {
        ExpensesDataAcessLayer objexpense = new ExpensesDataAcessLayer();

        public ExpensesDataAcessLayer GetObjexpense()
        {
            return objexpense;
        }

        public Microsoft.AspNetCore.Mvc.IActionResult Index(string searchString, ExpensesDataAcessLayer objexpense)
        {
            List<Category> lstCategory = new List<Category>();
            //lstCategory = objexpense.GetAllCategories().ToList("Category");

            if (!String.IsNullOrEmpty(searchString))
            {
              //  lstCategory = objexpense.GetSearchResult(searchString).ToList();
            }
            return View(lstCategory);
        }
        public IActionResult(int itemId)
        {
            Category model = new Category();
            if (itemId > 0)
            {
               // model = objexpense.GetExpenseData(itemId);
            }
           // return PartialView("_expenseForm", model);
        }

        [HttpPost]
        public ActionResult Create(Category newExpense)
        {
            if (ModelState.IsValid)
            {
                if (newExpense.Id > 0)
                {
                    objexpense.UpdateCategory(newExpense);
                }
                else
                {
                    objexpense.AddCategory(newExpense);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public Microsoft.AspNetCore.Mvc.IActionResult Delete(int id)
        {
            objexpense.DeleteCategory(id);
            return RedirectToAction("Index");
        }
    }
}
