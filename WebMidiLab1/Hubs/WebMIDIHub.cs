using Microsoft.AspNet.SignalR;

namespace WebMidiLab1.Hubs
{
    public class WebMIDIHub : Hub
    {
        public void WebMIDIOutput(byte status, byte msg1, byte msg2)
        {
            Clients.All.WebMIDIInput(status, msg1, msg2);
        }
    }
}
