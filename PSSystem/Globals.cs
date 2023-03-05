using GitHub.secile.Video;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSystem
{
    public static class Globals
    {
        public const int MAX_COUNT = 13;
        public static int gCurrentIndex = 0;
        public static int gCurrentCam = 0;
        public static Form  gMainForm;
        public static Form[] gFormList = new Form[MAX_COUNT];
        public static Mat[] gFrame = new Mat[MAX_COUNT];
        public static VideoCapture[] gVideoList = new VideoCapture[MAX_COUNT];
        public static Thread[] gThread = new Thread[MAX_COUNT];
        public static string[] gDevices = UsbCamera.FindDevices();
        public static int gNumCam = 0;

        public static void ChangeForm(int index)
        {
            Globals.gFormList[index].Show();
            Globals.gFormList[Globals.gCurrentIndex].Hide();
            Globals.gCurrentIndex = index;
        }


    }
}
