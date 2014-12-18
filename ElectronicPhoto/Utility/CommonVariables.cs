using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ElectronicPhoto.Utility
{
    static class CommonVariables
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ElectronicPhoto.Properties.Settings.ElectronicPhotoConnectionString"].ConnectionString;

        public static string[] ImageExtensions = { ".jpg", ".png", ".gif" };
    }
}
