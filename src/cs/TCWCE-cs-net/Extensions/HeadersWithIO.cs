namespace TCWCE.Extensions
{
    namespace HeadersWithIO
    {
        public static class ExtensionMain
        {
            public static System.Text.Encoding DefaultEncoding = System.Text.Encoding.UTF8;
            public static void ReWriteToFile(this For_String.Header header ,string FilePath, System.Text.Encoding ? encoding)
            {
                IO.ReWriteToFile(FilePath, header, encoding);
            }
            public static void ReWriteToFile(this For_String.Headers header, string FilePath, System.Text.Encoding? encoding)
            {
                IO.ReWriteToFile(FilePath, header, encoding);
            }
            public static async void ReWriteToFileAsync(this For_String.Header header, string FilePath, System.Text.Encoding? encoding, System.Action CallBack)
            {
               await IO.ReWriteToFileAsync(FilePath, header, encoding, CallBack);
            }
            public static async void ReWriteToFileAsync(this For_String.Headers header, string FilePath, System.Text.Encoding? encoding,System.Action CallBack)
            {
              await  IO.ReWriteToFileAsync(FilePath, header, encoding, CallBack);
            }
        }
    }
}
