using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PassmarProject.Models
{
    public class Usuario
    {
        public int usu_id { get; set; }

        public String usu_nom { get; set; }
        public String usu_mail { get; set; }
        public String usu_tel { get; set; }
        public String usu_is_rol { get; set; }
        public String usu_pass { get; set; }
         
    }
}