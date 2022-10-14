using Microsoft.AspNetCore.Mvc;

namespace CGSICAMM.Controllers
{
    public class PruebaCargaController : Controller
    {
        public IActionResult CargaExcel()
        {
            int procesoId = 1;
            string ciclo = "2022-2023";

            switch (procesoId)
            {
                case 1:
                    ViewBag.nombreProceso = "Admisión";
                    break;
                case 2:
                    ViewBag.nombreProceso = "Promoción vertical";
                    break;
                case 3:
                    ViewBag.nombreProceso = "Promoción horizontal";
                    break;
                case 4:
                    ViewBag.nombreProceso = "Horas adicionales";
                    break;
            }
                
            ViewBag.ciclo = ciclo;

            return View();
        }
    }
}
