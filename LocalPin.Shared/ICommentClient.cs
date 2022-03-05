using System.Threading.Tasks;
using LocalPin.Shared.Models;

namespace LocalPin.Shared
{
    public interface ICommentClient
    {
        Task ReceiveComment(Comment comment);
    }
}