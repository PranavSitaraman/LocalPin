using System.Threading.Tasks;
using LocalPin.Shared.Models;

namespace LocalPin.Shared
{
    public interface IPinClient
    {
        Task ReceivePin(PinPreview pin);
    }
}