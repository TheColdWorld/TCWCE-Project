namespace TCWCE.Extensions
{
    namespace HttpContextExtension
    {
        public static class ExtensionMain
        {
            public static System.Text.Encoding DefaultEncoding = System.Text.Encoding.UTF8;
            public static System.Net.Http.StringContent ToHttpContent(this For_String.Header Header ,System.Text.Encoding? encoding= null)
            {
                return new(Header.SerializedString, encoding, "application/TheColdworldConfigEdiror");
            }
        }
    }
}
