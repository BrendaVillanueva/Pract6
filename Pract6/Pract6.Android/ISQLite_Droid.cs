﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Pract6.Droid;
using Xamarin.Forms;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Dependency(typeof(ISQLite_Droid))]
namespace Pract6.Droid
{
    public class ISQLite_Droid :ISQLite
    {
        public string GetLocalFilePath(string Filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            return Path.Combine(path, Filename);
        }
    }
}