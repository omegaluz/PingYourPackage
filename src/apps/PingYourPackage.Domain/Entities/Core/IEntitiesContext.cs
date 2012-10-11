using System;
using System.Data.Entity;

namespace PingYourPackage.Domain.Entities {

    public interface IEntitiesContext : IDisposable {

        public IDbSet<ShipmentType> PackageTypes { get; set; }
        public IDbSet<Affiliate> PackageSenders { get; set; }
        public IDbSet<Shipment> Shipments { get; set; }
        public IDbSet<ShipmentState> ShipmentStates { get; set; }

        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<UserInRole> UserInRoles { get; set; }

        int SaveChanges();
        new IDbSet<T> Set<T>();
    }
}