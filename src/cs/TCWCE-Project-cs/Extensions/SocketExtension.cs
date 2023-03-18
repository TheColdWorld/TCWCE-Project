namespace TCWCE.Extensions
{
    namespace SocketeExtension
    {
        public static class ExtensionMain
        {
            public static System.Text.Encoding DefaultEncoding = System.Text.Encoding.UTF8;
            public static For_String.Headers Receive(this System.Net.Sockets.Socket socket, System.Net.Sockets.SocketFlags Flag = System.Net.Sockets.SocketFlags.None, long bufferlength = 1024 * 1024, System.Text.Encoding? encoding = null)
            {
                if (encoding == null) encoding = DefaultEncoding;
                //定义接收数据的缓存(默认为1MB)
                byte[] body = new byte[bufferlength];
                //第一次接收的实际数据 flag
                int flag = socket.Receive(body, 0, body.Length, Flag);
                byte[] main = new byte[flag];
                for (int i = 0; i < flag; i++)
                {
                    main[i] = body[i];
                }
                body = new byte[0];
                return new(encoding.GetString(main, 0, flag));
            }
            public async static System.Threading.Tasks.Task<For_String.Headers> ReceiveAsync(this System.Net.Sockets.Socket socket, System.Action CallBack, System.Net.Sockets.SocketFlags Flag = System.Net.Sockets.SocketFlags.None, long bufferlength = 1024 * 1024, System.Text.Encoding? encoding = null)
            {
                if (encoding == null) encoding = DefaultEncoding;
                //定义接收数据的缓存(默认为1MB)
                byte[] body = new byte[bufferlength];
                //接收的实际数据 flag
                int flag = socket.Receive(body, 0, body.Length, Flag);
                byte[] main = new byte[flag];
                for (int i = 0; i < flag; i++)
                {
                    main[i] = body[i];
                }
                body = new byte[0];
                CallBack();
                return new(encoding.GetString(main, 0, flag));
            }
            public static int Send(this System.Net.Sockets.Socket socket, For_String.Headers headers, System.Net.Sockets.SocketFlags Flag = System.Net.Sockets.SocketFlags.None, System.Text.Encoding? encoding = null)
            {
                if (encoding == null) encoding = DefaultEncoding;
                byte[] body = encoding.GetBytes(headers.SerializedString);
                return socket.Send(body, 0, body.Length, Flag);
            }
            public async static System.Threading.Tasks.Task<int> SendAsync(this System.Net.Sockets.Socket socket, For_String.Headers headers, System.Action Callback, System.Net.Sockets.SocketFlags Flag = System.Net.Sockets.SocketFlags.None, System.Text.Encoding? encoding = null)
            {
                if (encoding == null) encoding = DefaultEncoding;
                byte[] body = encoding.GetBytes(headers.SerializedString);
                Callback();
                return socket.Send(body, 0, body.Length, Flag);
            }
            public static int Send(this System.Net.Sockets.Socket socket, For_String.Header header, System.Net.Sockets.SocketFlags Flag = System.Net.Sockets.SocketFlags.None, System.Text.Encoding? encoding = null)
            {
                if (encoding == null) encoding = DefaultEncoding;
                byte[] body = encoding.GetBytes(header.SerializedString);
                return socket.Send(body, 0, body.Length, Flag);
            }
            public async static System.Threading.Tasks.Task<int> SendAsync(this System.Net.Sockets.Socket socket, For_String.Header header, System.Action Callback, System.Net.Sockets.SocketFlags Flag = System.Net.Sockets.SocketFlags.None, System.Text.Encoding? encoding = null)
            {
                if (encoding == null) encoding = DefaultEncoding;
                byte[] body = encoding.GetBytes(header.SerializedString);
                Callback();
                return socket.Send(body, 0, body.Length, Flag);
            }
        }
    }
}