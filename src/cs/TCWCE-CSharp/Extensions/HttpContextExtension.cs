namespace TCWCE.Extensions.HttpContextExtension
{
    public static class ExtensionMain
    {
        public static System.Net.Http.StringContent ToHttpContent(this For_String.IIO_allowed INF, System.Text.Encoding encoding)
        {
            return new(INF.SerializedString, encoding, "application/TheColdworldConfigEdiror");
        }
    }
}
