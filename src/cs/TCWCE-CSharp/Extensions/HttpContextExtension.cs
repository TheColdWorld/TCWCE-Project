namespace TCWCE.Extensions.HttpContextExtension
{
    public static class ExtensionMain
    {
        public static System.Net.Http.StringContent ToHttpContent<T>(this For_String.IList<T> item, System.Text.Encoding encoding)where T : For_String.ISerializeAble
        {
            return new(item.SerializedString, encoding, "application/TheColdworldConfigEdiror");
        }
    }
}
