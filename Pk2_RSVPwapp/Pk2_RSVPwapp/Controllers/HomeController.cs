using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pk2_RSVPwapp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ?
                "Buenos dias! " : "Buenas Tardes";

        
          
           return View();
        }
        //Get /Home/RsvpForm
        //Renderea el Link de la forma de RSVP
        [HttpGet]
        public ViewResult RsvpForm()
        {

            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse GuestResponse)
        { 
        //Verificando errores de  validacion
            if (ModelState.IsValid)
            {
                //todo: envia respuesta al correo del organizador
                return View("Agradeciemientos", GuestResponse);
            }
                else
                { 
                
                return View();

                }

        }
        }

    }
}
