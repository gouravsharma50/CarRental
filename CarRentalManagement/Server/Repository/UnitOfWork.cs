using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Server.Models;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using System.Security.Claims;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _makes;
        private IGenericRepository<Model> _models;
        private IGenericRepository<Color> _colors;
        private IGenericRepository<Vehicle> _vehicles;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Booking> _bookings;
        private UserManager<ApplicationUser> _userManager;
        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IGenericRepository<Make> Makes => _makes ??= new GenericRepository<Make>(_context);
        public IGenericRepository<Model> Models => _models ??= new GenericRepository<Model>(_context);
        public IGenericRepository<Color> Colors => _colors ??= new GenericRepository<Color>(_context);
        public IGenericRepository<Vehicle> Vehicles => _vehicles ??= new GenericRepository<Vehicle>(_context);
        public IGenericRepository<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Booking> Bookings => _bookings ??= new GenericRepository<Booking>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        public async Task Save(HttpContext httpContext)
        {
            //var user = "system";// httpContext.User.Identity.Name;

            var userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);

            var entries = _context.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Modified || x.State == EntityState.Added);

            foreach (var item in entries)
            {
                ((BaseDomainModel)item.Entity).DateUpdate = DateTime.Now;
                ((BaseDomainModel)item.Entity).UpdatedBy = user.UserName;
                if (item.State == EntityState.Added)
                {
                    ((BaseDomainModel)item.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)item.Entity).CreatedBy = user.UserName;
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
