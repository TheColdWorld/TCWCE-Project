namespace TCWCE.Extensions
{
    namespace HttpContextExtension
    {
        public static class ExtensionMain
        {
            public static System.Text.Encoding DefaultEncoding = System.Text.Encoding.UTF8;
            public static void StringContent(this System.Net.Http.StringContent content,For_String.Header RequestHeader,System.Text.Encoding encoding)
            {
                if (encoding == null) encoding = DefaultEncoding;
                content=new(RequestHeader.SerializedString, encoding);
                content.Headers.Add("Content-Type", "application/TheColdWorldConfigEditer");
            }
        }
    }
}
