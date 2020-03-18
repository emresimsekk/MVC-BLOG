using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Blog.UI.App_Classes
{
    public class Settings
    {
        public static Size ImageSmall
        {
            get
            {
                Size result = new Size();
                result.Width = Convert.ToInt32(ConfigurationManager.AppSettings["sw"]);
                result.Height = Convert.ToInt32(ConfigurationManager.AppSettings["sh"]);
                return result;
            }
        }

        public static Size ImageMiddle
        {
            get
            {
                Size result = new Size();
                result.Width = Convert.ToInt32(ConfigurationManager.AppSettings["mw"]);
                result.Height = Convert.ToInt32(ConfigurationManager.AppSettings["mh"]);
                return result;
            }
        }

        public static Size ImageLarge
        {
            get
            {
                Size result = new Size();
                result.Width = Convert.ToInt32(ConfigurationManager.AppSettings["lw"]);
                result.Height = Convert.ToInt32(ConfigurationManager.AppSettings["lh"]);
                return result;
            }
        }
    }
}