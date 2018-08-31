using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class CategoryService
    {
        private static CategoryService _Instance;
        public static CategoryService Instance
        {

            get
            {

                if (_Instance == null)
                {
                    _Instance = new CategoryService();
                }
                return (_Instance);
            }
        }

        private CategoryService()
        {
        }


    }
}
