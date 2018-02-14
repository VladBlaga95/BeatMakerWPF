using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Media;
using System.IO;
using System.Windows;

namespace BeatMakerWPF
{
    public static class Engine
    {
        public static System.Windows.Media.LinearGradientBrush MyGradient = new System.Windows.Media.LinearGradientBrush();
        public static System.Windows.Media.LinearGradientBrush MyGradient2 = new System.Windows.Media.LinearGradientBrush();
        public static System.Windows.Media.LinearGradientBrush MyGradient3 = new System.Windows.Media.LinearGradientBrush();
        public static System.Windows.Media.LinearGradientBrush MyGradient4 = new System.Windows.Media.LinearGradientBrush();
        public static System.Windows.Media.LinearGradientBrush MyGradient5 = new System.Windows.Media.LinearGradientBrush();
        public static  Button[,] but = new Button[5, 5];
        public static SoundPlayer[,] player = new SoundPlayer[5, 5];
        public static string[] x = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" };
        public static  void GenerateGradientOrange()
        {
            MyGradient.StartPoint = new Point(0, 0);
            MyGradient.EndPoint = new Point(0, 1);
            System.Windows.Media.GradientStop blueGS = new System.Windows.Media.GradientStop();
            blueGS.Color = System.Windows.Media.Color.FromRgb(255, 183, 5);
            blueGS.Offset = 1.0;
            MyGradient.GradientStops.Add(blueGS);

            System.Windows.Media.GradientStop orangeGS = new System.Windows.Media.GradientStop();
            orangeGS.Color = System.Windows.Media.Color.FromRgb(235, 169, 5);
            orangeGS.Offset = 0.50;
            MyGradient.GradientStops.Add(orangeGS);

            System.Windows.Media.GradientStop yellowGS = new System.Windows.Media.GradientStop();
            yellowGS.Color = System.Windows.Media.Color.FromRgb(235, 182, 51);
            yellowGS.Offset = 0.49;
            MyGradient.GradientStops.Add(yellowGS);

            System.Windows.Media.GradientStop greenGS = new System.Windows.Media.GradientStop();
            greenGS.Color = System.Windows.Media.Color.FromRgb(235, 209, 143);
            greenGS.Offset = 0.0;
            MyGradient.GradientStops.Add(greenGS);
        }
        public static void GenerateGradientBlue()
        {
            MyGradient2.StartPoint = new Point(0, 0);
            MyGradient2.EndPoint = new Point(0, 1);
            System.Windows.Media.GradientStop blue = new System.Windows.Media.GradientStop();
            blue.Color = System.Windows.Media.Color.FromRgb(35, 86, 193);
            blue.Offset = 1.0;
            MyGradient2.GradientStops.Add(blue);

            System.Windows.Media.GradientStop blue2 = new System.Windows.Media.GradientStop();
            blue2.Color = System.Windows.Media.Color.FromRgb(25, 61, 137);
            blue2.Offset = 0.50;
            MyGradient2.GradientStops.Add(blue2);

            System.Windows.Media.GradientStop blue3 = new System.Windows.Media.GradientStop();
            blue3.Color = System.Windows.Media.Color.FromRgb(47, 76, 137);
            blue3.Offset = 0.49;
            MyGradient2.GradientStops.Add(blue3);

            System.Windows.Media.GradientStop blue4 = new System.Windows.Media.GradientStop();
            blue4.Color = System.Windows.Media.Color.FromRgb(92, 106, 137);
            blue4.Offset = 0.0;
            MyGradient2.GradientStops.Add(blue4);
        }
        public static void GenerateGradientViolet()
        {
            MyGradient3.StartPoint = new Point(0, 0);
            MyGradient3.EndPoint = new Point(0, 1);
            System.Windows.Media.GradientStop blue = new System.Windows.Media.GradientStop();
            blue.Color = System.Windows.Media.Color.FromRgb(140, 56, 255);
            blue.Offset = 1.0;
            MyGradient3.GradientStops.Add(blue);

            System.Windows.Media.GradientStop blue2 = new System.Windows.Media.GradientStop();
            blue2.Color = System.Windows.Media.Color.FromRgb(140, 56, 255);
            blue2.Offset = 0.50;
            MyGradient3.GradientStops.Add(blue2);

            System.Windows.Media.GradientStop blue3 = new System.Windows.Media.GradientStop();
            blue3.Color = System.Windows.Media.Color.FromRgb(163, 96, 255);
            blue3.Offset = 0.49;
            MyGradient3.GradientStops.Add(blue3);

            System.Windows.Media.GradientStop blue4 = new System.Windows.Media.GradientStop();
            blue4.Color = System.Windows.Media.Color.FromRgb(209, 176, 255);
            blue4.Offset = 0.0;
            MyGradient3.GradientStops.Add(blue4);
        }
        public static void GenerateGradientGreen()
        {
            MyGradient4.StartPoint = new Point(0, 0);
            MyGradient4.EndPoint = new Point(0, 1);
            System.Windows.Media.GradientStop blue = new System.Windows.Media.GradientStop();
            blue.Color = System.Windows.Media.Color.FromRgb(101, 182, 3);
            blue.Offset = 1.0;
            MyGradient4.GradientStops.Add(blue);

            System.Windows.Media.GradientStop blue2 = new System.Windows.Media.GradientStop();
            blue2.Color = System.Windows.Media.Color.FromRgb(70, 126, 2);
            blue2.Offset = 0.50;
            MyGradient4.GradientStops.Add(blue2);

            System.Windows.Media.GradientStop blue3 = new System.Windows.Media.GradientStop();
            blue3.Color = System.Windows.Media.Color.FromRgb(81, 126, 27);
            blue3.Offset = 0.49;
            MyGradient4.GradientStops.Add(blue3);

            System.Windows.Media.GradientStop blue4 = new System.Windows.Media.GradientStop();
            blue4.Color = System.Windows.Media.Color.FromRgb(103, 126, 77);
            blue4.Offset = 0.0;
            MyGradient4.GradientStops.Add(blue4);
        }
        public static void GenerateGradientRed()
        {
            MyGradient5.StartPoint = new Point(0, 0);
            MyGradient5.EndPoint = new Point(0, 1);
            System.Windows.Media.GradientStop blue = new System.Windows.Media.GradientStop();
            blue.Color = System.Windows.Media.Color.FromRgb(255, 74, 72);
            blue.Offset = 1.0;
            MyGradient5.GradientStops.Add(blue);

            System.Windows.Media.GradientStop blue2 = new System.Windows.Media.GradientStop();
            blue2.Color = System.Windows.Media.Color.FromRgb(233, 68, 65);
            blue2.Offset = 0.50;
            MyGradient5.GradientStops.Add(blue2);

            System.Windows.Media.GradientStop blue3 = new System.Windows.Media.GradientStop();
            blue3.Color = System.Windows.Media.Color.FromRgb(233, 101, 99);
            blue3.Offset = 0.49;
            MyGradient5.GradientStops.Add(blue3);

            System.Windows.Media.GradientStop blue4 = new System.Windows.Media.GradientStop();
            blue4.Color = System.Windows.Media.Color.FromRgb(233, 167, 166);
            blue4.Offset = 0.0;
            MyGradient5.GradientStops.Add(blue4);
        }
    }
}
