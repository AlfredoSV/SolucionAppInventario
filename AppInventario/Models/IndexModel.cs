using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppInventario.Models
{
    public class IndexModel
    {
        public IndexModel()
        {
            if (Pg == null)
                Pg = new PaginacionModel();
        }
        public List<Producto> Productos { get; set; }

        public static PaginacionModel Pg;

    }
}
