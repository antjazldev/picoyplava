using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace picoyplaca.Controllers
{
    public class PicoyPlacaController : Controller
    {
        // GET: PicoyPlaca
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Resultado(string date, string lastDigit, string time, string day )
        {
            string[] timeDetail= time.Split(':');
            TimeSpan input = new TimeSpan(Int32.Parse(timeDetail[0]), Int32.Parse(timeDetail[1]), 0);
            TimeSpan start = new TimeSpan(7, 0, 0); //7 o'clock
            TimeSpan end = new TimeSpan(9, 30, 0); //9:30 o'clock
            TimeSpan start2 = new TimeSpan(16,0,0);//16:00
            TimeSpan end2 = new TimeSpan(19,30,0);//19:30
           string html = "";
            
            switch (day) {
                case "1":  //Lunes
                    if (!lastDigit.Equals("1") && !lastDigit.Equals("2")) { html += "Su auto puede circular"; }
                    if ((lastDigit.Equals("1") || lastDigit.Equals("2")) && (input < start || input > end)&& (input < start2 || input > end2)) { html += "Su auto puede circular"; }
                    if ((lastDigit.Equals("1") || lastDigit.Equals("2")) && ((input > start && input < end)|| (input > start2 && input < end2))) { html += "Su auto NO puede circular"; }
                    break;
                case "2": // Martes
                    if (!lastDigit.Equals("3") && !lastDigit.Equals("4")) { html += "Su auto puede circular"; }
                    if ((lastDigit.Equals("3") || lastDigit.Equals("4")) && (input < start || input > end) && (input < start2 || input > end2)) { html += "Su auto puede circular"; }
                    if ((lastDigit.Equals("3") || lastDigit.Equals("4")) && ((input > start && input < end) || (input > start2 && input < end2))) { html += "Su auto NO puede circular"; }
                    break;
                case "3":// Miercoles
                    if (!lastDigit.Equals("5") && !lastDigit.Equals("6")) { html += "Su auto puede circular"; }
                    if ((lastDigit.Equals("5") || lastDigit.Equals("6")) && (input < start || input > end) && (input < start2 || input > end2)) { html += "Su auto puede circular"; }
                    if ((lastDigit.Equals("5") || lastDigit.Equals("6")) && ((input > start && input < end) || (input > start2 && input < end2))) { html += "Su auto NO puede circular"; }
                    break;
                case "4"://Jueves
                    if (!lastDigit.Equals("7") && !lastDigit.Equals("8")) { html += "Su auto puede circular"; }
                    if ((lastDigit.Equals("7") || lastDigit.Equals("8")) && (input < start || input > end) && (input < start2 || input > end2)) { html += "Su auto puede circular"; }
                    if ((lastDigit.Equals("7") || lastDigit.Equals("8")) && ((input > start && input < end) || (input > start2 && input < end2))) { html += "Su auto NO puede circular"; }
                    break;
                case "5"://Viernes
                    if (!lastDigit.Equals("9") && !lastDigit.Equals("0")) { html += "Su auto puede circular"; }
                    if ((lastDigit.Equals("9") || lastDigit.Equals("0")) && (input < start || input > end) && (input < start2 || input > end2)) { html += "Su auto puede circular"; }
                    if ((lastDigit.Equals("9") || lastDigit.Equals("0")) && ((input > start && input < end) || (input > start2 && input < end2))) { html += "Su auto NO puede circular"; }
                    break;

                default:
                    html += "Su auto puede circular";
                    break;
                 

            }



            return Json(new { html }, JsonRequestBehavior.AllowGet);
        }
    }
}