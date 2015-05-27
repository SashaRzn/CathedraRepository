using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraUniversity.Forms.Classes
{
    public class Repository
    {
        private DatabaseDataContext context = new DatabaseDataContext();

        public List<Employee> GetFilterEmployee()
        {

            List<Employee> employees = (from e in context.Employee
                                        where e.NonActive == false
                                        orderby e.Fio
                                        select e).ToList();
            return employees;
        }

        public List<Employee> GetFilterEmployee(int sortLoadId)
        {
            List<int?> deniedPost = (from p in context.PostAcessDenied
                                     where p.SortLoadID == sortLoadId
                                     select p.PostID).ToList();

            List<Employee> employees = (from e in context.Employee
                                        where e.NonActive == false && !deniedPost.Contains(e.PostID)
                                        orderby e.Fio
                                        select e).ToList();
            return employees;

        }
    }
}
