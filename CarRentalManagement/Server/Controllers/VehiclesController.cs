﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VehiclesController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: api/Vehicles
        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {

            var include = new List<string>() { "Make", "Model", "Color" };
            var vehicle = await _unitOfWork.Vehicles.GetAll(includes: x => x.Include(q => q.Make).Include(q => q.Model).Include(q => q.Color));
            return Ok(vehicle);
        }

        // GET: api/Vehicles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicle(int id)
        {
            var vehicle = await _unitOfWork.Vehicles.Get(x => x.Id == id, includes: x => x.Include(q => q.Make).Include(q => q.Model).Include(q => q.Color));

            if (vehicle == null)
            {
                return NotFound();
            }

            return Ok(vehicle);
        }
        // GET: api/Vehicles/5/details
        [HttpGet("{id}/details")]
        public async Task<IActionResult> GetVehicleDetails(int id)
        {
            
            var vehicle = await _unitOfWork.Vehicles.Get(x => x.Id == id, includes: x => x.Include(q => q.Make).Include(q => q.Model).Include(q => q.Color));

            if (vehicle == null)
            {
                return NotFound();
            }

            return Ok(vehicle);
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return BadRequest();
            }
            if (vehicle.Image != null)
            {
                vehicle.ImageName = await CreateFilePath(vehicle.Image, vehicle.ImageName);
            }
            await _unitOfWork.Vehicles.Update(vehicle);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {
            if (vehicle.Image != null)
            {
                vehicle.ImageName = await CreateFilePath(vehicle.Image, vehicle.ImageName);
            }
            await _unitOfWork.Vehicles.Insert(vehicle);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetVehicle", new { id = vehicle.Id }, vehicle);
        }

        // DELETE: api/Vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }
            await _unitOfWork.Vehicles.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> VehicleExists(int id)
        {
            var vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id);
            return vehicle != null;
        }
        private async Task<string> CreateFilePath(byte[] image, string name)
        {

            var url = _httpContextAccessor.HttpContext.Request.Host.Value;
            var path = $"{_webHostEnvironment.WebRootPath}\\uploads\\{name}";
            var stream = System.IO.File.Create(path);
            stream.Write(image, 0, image.Length);
            stream.Close();
            name = $"https://{url}/uploads/{name}";
            return name;
        }

    }
}
