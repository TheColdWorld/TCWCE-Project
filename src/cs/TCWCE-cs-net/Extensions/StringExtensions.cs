namespace TCWCE.Extensions
{
    internal static class StringExtensions
    {
       readonly static  char[] StringLibrary_a_z = {
                '1','2','3','4','5','6','7','8','9','0',
                'A','B','C','D','E','F','G','H','I','J','K','L' ,'M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
            };
        public static string GetRandonString(ulong StringLength, char[]? Stringlibrary = null)
        {
            if( Stringlibrary == null ) { Stringlibrary = StringLibrary_a_z; }
            if (StringLength == 0) return "";
            System.Random random = new();
            string Return = string.Empty;
            for (ulong i = 0; i < StringLength; i++)
            {
                Return += Stringlibrary[random.NextInt64(0, Stringlibrary.Length)];
            }
            return Return;
        }
    }
}
