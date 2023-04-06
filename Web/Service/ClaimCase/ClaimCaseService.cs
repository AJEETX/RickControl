using app.Domain;
using app.Model.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace app.Service.ClaimCase
{
    public class ClaimCaseService : IClaimCaseService
    {
        public Task<ServiceResult> AddAsync(ClaimCaseDTO model)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResult<IEnumerable<ClaimCaseDTO>>> Find(ClaimCaseDTO criteria)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResult<int>> FindCount(ClaimCaseDTO criteria)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResult<IEnumerable<ClaimCaseDTO>>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResult<ClaimCaseDTO>> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResult> RemoveById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResult> Update(ClaimCaseDTO model)
        {
            throw new System.NotImplementedException();
        }
    }
}
