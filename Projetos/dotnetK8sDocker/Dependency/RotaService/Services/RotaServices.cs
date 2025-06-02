using Grpc.Core;
using RotaService.Protos;
using System.Threading.Tasks;

namespace RotaService.Services
{
    public class RotaServices : Rota.RotaBase
    {
        public override Task<RotaResponse> GetRota(RotaRequest request, ServerCallContext context)
        {
            return Task.FromResult(new RotaResponse
            {
                Message = $"Hello {request.Name}"
            });
        }
    }
}