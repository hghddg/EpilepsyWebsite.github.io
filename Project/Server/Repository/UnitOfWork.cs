using Project.Server.Data;
using Project.Server.IRepository;
using Project.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Project.Shared.Domains;

namespace Project.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Attraction> _attractions;
        private IGenericRepository<Country> _countries;
        private IGenericRepository<Hotel> _hotels;
        private IGenericRepository<ItenaryItem> _itenaryitems;
        private IGenericRepository<Location> _locations;
        private IGenericRepository<Payment> _payments;


    private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Attraction> Attractions
            => _attractions ??= new GenericRepository<Attraction>(_context);
        public IGenericRepository<Country> Countries
            => _countries ??= new GenericRepository<Country>(_context);      
        public IGenericRepository<Hotel> Hotels
            => _hotels ??= new GenericRepository<Hotel>(_context);
        public IGenericRepository<ItenaryItem> ItenaryItems
            => _itenaryitems ??= new GenericRepository<ItenaryItem>(_context);
        public IGenericRepository<Location> Locations
            => _locations ??= new GenericRepository<Location>(_context);
        public IGenericRepository<Payment> Payments
            => _payments ??= new GenericRepository<Payment>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {

            var userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);
            //To be implemented
            //string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user.UserName;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user.UserName;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}