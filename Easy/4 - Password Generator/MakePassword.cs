namespace PasswordGenerator
{
    using System;

    class MakePassword
    {
        public static string MakePassword(int length)
        {
            var password = "";

            var ran = new Random();
            for (var i = 0; i < length; i++)
            {
                var num = ran.Next(0, 26);
                var let = (char)('a' + num);
                password += @let;
            }


            return password;
        }
    }
}