using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T,ID>
    {
        //if the repository is product type then the T=> Product Or
        //if the repository is customer type then the T=> Customer that means data type is dynamic
        void ADD(T entity);

        //when we need proudct, it will pass Product 
        //when we need customer, it will pass Customer.. that means dynamic
        List<T> GetAll();

        //fetching a particular things through id
        T Get(ID id);

        void Edit(T entity);

        void Delete(ID id);

        List<T> Gets(ID id);

        List<T> Getorder(ID id);


        //ikoltgjwseriogjerilotughywioer5algjwer5uiotygb ne45t89uw4589otgy ihj35

       // void Add(T e);

        //List<T> GetAll();

        //T Get(ID id);

     /*   void Edit(T e);
        void Delete(ID id);

        List<T> Gets(ID id);

        List<T> Getorder(ID id);*/
    }
}
