using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class ProductService
    {
        private static ProductService _Instance;
        public static ProductService Instance
        {

            get
            {

                if (_Instance == null)
                {
                    _Instance = new ProductService();
                }
                return (_Instance);
            }
        }

        private ProductService()
        {
        }


    }

}
