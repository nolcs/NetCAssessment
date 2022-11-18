using NETAssessment.Entities;

namespace NETAssessment.Services.Interface
{
    public interface IClaimService : IDisposable
    {
        /// <summary>
        /// List of all claims
        /// </summary>
        /// <returns>List<Claim></returns>
        List<Claim> GetAllClaims();

        /// <summary>
        /// Claims by Owner ID
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns>List<Claim></returns>
        List<Claim> GetClaimsByVehicleId(string vehicleId);

        /// <summary>
        /// Individual claim
        /// </summary>
        /// <param name="claimId"></param>
        /// <returns>Claim</returns>
        Claim GetClaimById(string claimId);

        /// <summary>
        /// Save claim
        /// </summary>
        /// <param name="claim"></param>
        void CreateClaim(Claim claim);

        /// <summary>
        /// Modify claim
        /// </summary>
        /// <param name="claim"></param>
        void UpdateClaim(Claim claim);

        /// <summary>
        /// Remove claim
        /// </summary>
        /// <param name="claim"></param>
        void DeleteClaim(Claim claim);
    }
}
