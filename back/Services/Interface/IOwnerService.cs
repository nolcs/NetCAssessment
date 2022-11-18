using NETAssessment.Entities;

namespace NETAssessment.Services.Interface
{
    public interface IOwnerService : IDisposable
    {
        /// <summary>
        /// List of all owners
        /// </summary>
        /// <returns>List<Owner></returns>
        List<Owner> GetAllOwners();

        /// <summary>
        /// Individual owner
        /// </summary>
        /// <param name="ownerId"></param>
        /// <returns>Owner</returns>
        Owner GetOwner(string ownerId);

        /// <summary>
        /// Save owner
        /// </summary>
        /// <param name="owner"></param>
        void CreateOwner(Owner owner);

        /// <summary>
        /// Modify owner
        /// </summary>
        /// <param name="owner"></param>
        void UpdateOwner(Owner owner);

        /// <summary>
        /// Remove owner
        /// </summary>
        /// <param name="owner"></param>
        void DeleteOwner(Owner owner);
    }
}
