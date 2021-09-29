using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishingHelper.Models;
using FishingHelper.Services;

namespace FishApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishController : ControllerBase
    { 
        private readonly FishService _fishService;

            public FishController(FishService fishService)
            {
                _fishService = fishService;
            }

            [HttpGet]
            public ActionResult<List<Fish>> Get() =>
                _fishService.Get();

            [HttpGet("{id:length(24)}", Name = "GetFish")]
            public ActionResult<Fish> Get(string id)
            {
                var fish = _fishService.Get(id);

                if (fish == null)
                {
                    return NotFound();
                }

                return fish;
            }

            [HttpPost]
            public ActionResult<Fish> Create(Fish fish)
            {
                _fishService.Create(fish);

                return CreatedAtRoute("GetFish", new { id = fish.Id.ToString() }, fish);
            }

            [HttpPut("{id:length(24)}")]
            public IActionResult Update(string id, Fish fishIn)
            {
                var fish = _fishService.Get(id);

                if (fish == null)
                {
                    return NotFound();
                }

                _fishService.Update(id, fishIn);

                return NoContent();
            }

            [HttpDelete("{id:length(24)}")]
            public IActionResult Delete(string id)
            {
                var fish = _fishService.Get(id);

                if (fish == null)
                {
                    return NotFound();
                }

                _fishService.Remove(fish.Id);

                return NoContent();
            }
        }
    }

