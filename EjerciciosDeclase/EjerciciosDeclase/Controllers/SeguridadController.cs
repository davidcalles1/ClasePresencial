using EjerciciosDeclase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjerciciosDeclase.Controllers
{
    public class SeguridadController : Controller
    {
        // GET: Seguridad
       
        [HttpPost]
        public ActionResult login(string usuario, int dui )
            
        {
            
            using (EMPLEADOEntities emp = new EMPLEADOEntities())
            {
               

                Tbl_empleado empleao = new Tbl_empleado();
                if (usuario.Equals(empleao.Empl_nombre) && dui.Equals(empleao.Empl_DUI))
                {
                    return RedirectToAction("/Seguridad/menu");

                }
               
            }

                return View("/Seguridad/Inicio");
        }

        public ActionResult Inicio()
        {
            return View();
        }








        public ActionResult menu()
        {
            return View();
        }

    }
}