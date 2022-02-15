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
    public class RowAndColumnCalculationByCoordinatesController : Controller
    {
        private readonly ChooseTriangleByAxisCoordinates ChooseTriangleByCoordinates;
        public RowAndColumnCalculationByCoordinatesController(ChooseTriangleByAxisCoordinates chooseTriangleByAxis)
        {
            ChooseTriangleByCoordinates = chooseTriangleByAxis;
        }
        // POST api/<RowAndColumnCalculationByCoordinatesController>
        [HttpPost]
        public JsonResult Post([FromBody] TriangleCoordinatesRequestData value)
        {
            CombineAxisCoordinatesForTriangle combineAxisCoordinatesForTriangle = new CombineAxisCoordinatesForTriangle()
                .AddLeftCoordinates(new Coordinates(value.LeftX, value.LeftY))
                .AddAngleCoordinates(new Coordinates(value.AngleX, value.AngleY))
                .AddRightCoordinates(new Coordinates(value.RightX, value.RightY));
            ImageGridDimensions imageGridDimensions = new ImageGridDimensions(value.Height, value.Width, value.EachColumnSize);
            return Json(ChooseTriangleByCoordinates.GetTriangle(combineAxisCoordinatesForTriangle, imageGridDimensions));
        }
    }
}
