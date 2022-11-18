using NETAssessment.Entities;

namespace NETAssessment.Services.Interface
{
    public interface IVehicleService : IDisposable
    {
        /// <summary>
        /// List of all vehicles
        /// </summary>
        /// <returns>List<Vehicle></returns>
        List<Vehicle> GetAllVehicles();

        /// <summary>
        /// Vehicles by Owner ID
        /// </summary>
        /// <param name="OwnerId"></param>
        /// <returns>List<Vehicle></returns>
        List<Vehicle> GetVehiclesByOwnerId(string ownerId);

        /// <summary>
        /// Individual vehicle
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns>Vehicle</returns>
        Vehicle GetVehicleById(string vehicleId);

        /// <summary>
        /// Save vehicle
        /// </summary>
        /// <param name="vehicle"></param>
        void CreateVehicle(Vehicle vehicle);

        /// <summary>
        /// Modify vehicle
        /// </summary>
        /// <param name="vehicle"></param>
        void UpdateVehicle(Vehicle vehicle);

        /// <summary>
        /// Remove vehicle
        /// </summary>
        /// <param name="vehicle"></param>
        void DeleteVehicle(Vehicle vehicle);
    }
}
