using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магазин
{
    public partial class products
    {
        public string categ
        {
            get
            {
                var a = "";
                var pr = App.DB.products.ToList();
                var ca = App.DB.categories.ToList();
                var v = App.DB.products.Where(p => p.id_category == categories.id).ToList();
                {
                    return categories.name;
                };
                //foreach (var i in pr)
                //{
                //    foreach (var j in ca)
                //    {
                //        //if(j.id_category == 4)
                //        //{
                //            if (i.id_category == j.id)
                //            {
                //                a += id_category.ToString();
                //                return a;
                //            }
                //        //}
                //    }
                //}
                //return v.ToString();
            }
        }
    }
}
