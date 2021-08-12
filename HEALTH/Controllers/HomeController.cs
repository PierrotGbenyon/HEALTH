
using iText.Html2pdf;
using iText.Kernel.Pdf;
using iText.Layout;
//using iText.Layout.Element;
using iText.Layout.Element;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //EditPdf();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        private IActionResult EditPdf()
        {
            string myPath = Path.Combine(Environment.CurrentDirectory, "wwwroot", "datastock", "hellovi.pdf");            
            PdfDocument pdf = new PdfDocument(new PdfWriter(myPath));
            Document document = new Document(pdf);
            string line = "Bonjour! Ceci n'est qu'un autre pas vers le savoir";
            document.Add(new Paragraph(line));
            document.Close();
            return File(myPath,"application/octet-stream");
        }

        public FileStreamResult pdf()
        {
            var workStream = new MemoryStream();
            string html = "";
            using (var pdfWriter = new PdfWriter(workStream))
            {
                pdfWriter.SetCloseStream(false);
                using (var document = HtmlConverter.ConvertToDocument(html, pdfWriter) )
                {
                }
            }

            workStream.Position = 0;
            return new FileStreamResult(workStream, "application/pdf");
        }

    }
}
