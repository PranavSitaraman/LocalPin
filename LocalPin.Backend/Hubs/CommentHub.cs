using System;
using System.Threading.Tasks;
using LocalPin.Shared;
using Microsoft.AspNetCore.SignalR;

namespace LocalPin.Backend.Hubs
{
    public class CommentHub: Hub<ICommentClient>
    {
        public async Task JoinPinRoom(Guid pinId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, GetGroupName(pinId));
        }
 
        public static string GetGroupName(Guid pinId)
        {
            return $"PNG|{pinId}";
        }
        
    }
}