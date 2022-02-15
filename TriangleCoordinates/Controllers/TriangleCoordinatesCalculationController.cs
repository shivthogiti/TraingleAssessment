using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculation.BusinessLogic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TriangleCoordinates.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class TriangleCoordinatesCalculationController : Controller
    {
        private readonly CalculateCoordinatesByTriangleSelected TriangleCalculator;

        public TriangleCoordinatesCalculationController(CalculateCoordinatesByTriangleSelected calculateCoordinatesByTriangleSelected)
        {
            TriangleCalculator = calculateCoordinatesByTriangleSelected ;
        }

        //// POST api/<TriangleCoordinatesCalculationController>
        [HttpPost]
        public JsonResult Post([FromBody] ImageGridRequestForTriangleCalculation value)
        {
            char Row = value.TriangleSelected.ToCharArray().First();
            int Column = int.Parse(value.TriangleSelected.Substring(1));
            SelectedTriangleColumnAndRow triangleColumnAndRow = new SelectedTriangleColumnAndRow(Row, Column);
            ImageGridDimensions imageGridDimensions = new ImageGridDimensions(value.Height, value.Width, value.EachColumnSize);
            return Json(TriangleCalculator.Calculate(triangleColumnAndRow, imageGridDimensions).CoordinatesList);
        }
    }
}
