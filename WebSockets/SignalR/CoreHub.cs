using Microsoft.AspNetCore.SignalR;

namespace SelfSignalR.WebSockets.SignalR
{
    public class CoreHub : Hub
    {
        //Server will receive a message and trigger ServerClientReceiver method on UI Side
        public async Task HenSendData(string data)
        {
            string modifiedData = $"Incoming Data Is: {data}";
            string uiSideMethodName = "ServerClientReceiver";
            await Clients.All.SendAsync(uiSideMethodName, modifiedData);
        }

        //Server just listens and console the incoming message
        public async Task ServerListens(string data)
        {
            string modifiedData = $"Incoming Data Is: {data}";
            Console.WriteLine(modifiedData);
            //string uiSideMethodName = "ServerClientReceiver";
            //await Clients.All.SendAsync(uiSideMethodName, modifiedData);
        }
    }
}