using System;
using System.Text;

namespace QLCuaHangDoGo.Helpers
{
    public static class  PasswordHelper
    {
        public static string GeneratePassword(int length)
        {
            if (length < 6) length = 6;
            if (length > 20) length = 20;
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+";
            StringBuilder password = new StringBuilder();

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                password.Append(chars[index]);
            }

            return password.ToString();
        }
    }
}
