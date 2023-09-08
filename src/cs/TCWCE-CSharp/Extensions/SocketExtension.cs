namespace TCWCE.Extensions.SocketExtension
{
    public static class ExtensionMain
    {
        public static For_String.Headers Receive(this System.Net.Sockets.Socket socket, System.Text.Encoding encoding, System.Net.Sockets.SocketFlags Flag = System.Net.Sockets.SocketFlags.None, long bufferlength = 1024 * 1024)
        {
            byte[] body = new byte[bufferlength];
            int flag = socket.Receive(body, 0, body.Length, Flag);
            byte[] main = new byte[flag];
            for (int i = 0; i < flag; i++)
            {
                main[i] = body[i];
            }
            body = System.Array.Empty<byte>();
            return new(encoding.GetString(main, 0, flag));
        }
        public async static System.Threading.Tasks.Task<For_String.Headers> ReceiveAsync(this System.Net.Sockets.Socket socket, System.Action? CallBack, System.Text.Encoding encoding, System.Net.Sockets.SocketFlags Flag = System.Net.Sockets.SocketFlags.None, long bufferlength = 1024 * 1024, System.Threading.CancellationToken token = default)
        {
            byte[] body = new byte[bufferlength];
            int flag = await socket.ReceiveAsync(body, Flag, token);
            byte[] main = new byte[flag];
            System.Threading.Tasks.Task[] tasks=new System.Threading.Tasks.Task[flag];
            for(int i = 0; i < flag; i++)
            {
                tasks[i]=System.Threading.Tasks.Task.Run(() => main[i] = body[i]);
            }
            System.Threading.Tasks.Task.WaitAll(tasks);
            body = System.Array.Empty<byte>();
            For_String.Headers retu = new(encoding.GetString(main, 0, flag));
            CallBack?.Invoke();
            return retu;
        }
        public static int Send<T>(this System.Net.Sockets.Socket socket, For_String.IList<T> item, System.Text.Encoding encoding, System.Net.Sockets.SocketFlags Flag = System.Net.Sockets.SocketFlags.None) where T : For_String.ISerializeAble
        {
            byte[] body = encoding.GetBytes(item.SerializedString);
            return socket.Send(body, 0, body.Length, Flag);
        }
    }
}
