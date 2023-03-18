using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSystem
{
    public partial class FormSetVideo : Form
    {
        Button[] CameraButton = new Button[4];

        public FormSetVideo()
        {
            InitializeComponent();
            CameraButton[0] = btnCam1;
            CameraButton[1] = btnCam2;
            CameraButton[2] = btnCam3;
            CameraButton[3] = btnCam4;
        }

        private void ShowImage(Bitmap image, int pictureIndex)
        {
            if (pictureIndex == 0)
            {
                pictureBox1.Image = image;
            }
            else if (pictureIndex == 1)
            {
                pictureBox2.Image = image;
            }
            else if (pictureIndex == 2)
            {
                pictureBox3.Image = image;
            }
            else if (pictureIndex == 3)
            {
                pictureBox4.Image = image;
            }
        }

        private void CameraCallback0()
        {
            Globals.gFrame[0] = new Mat();
            Globals.gVideoList[0] = new VideoCapture(0, VideoCaptureAPIs.DSHOW);
            while (true)
            {

                Globals.gVideoList[0].Read(Globals.gFrame[0]);
                ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Globals.gFrame[0]), 0);

            }
        }
        private void CameraCallback1()
        {
            Globals.gFrame[1] = new Mat();
            Globals.gVideoList[1] = new VideoCapture(1, VideoCaptureAPIs.DSHOW);

            while (true)
            {
                Globals.gVideoList[1].Read(Globals.gFrame[1]);
                ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Globals.gFrame[1]), 1);

            }
        }

        private void CameraCallback2()
        {
            Globals.gFrame[2] = new Mat();
            Globals.gVideoList[2] = new VideoCapture(2, VideoCaptureAPIs.DSHOW);

            while (true)
            {
                Globals.gVideoList[2].Read(Globals.gFrame[2]);
                ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Globals.gFrame[2]), 2);
            }
        }

        private void CameraCallback3()
        {
            Globals.gFrame[3] = new Mat();
            Globals.gVideoList[3] = new VideoCapture(3, VideoCaptureAPIs.DSHOW);

            while (true)
            {
                Globals.gVideoList[3].Read(Globals.gFrame[3]);
                ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Globals.gFrame[3]), 3);
            }
        }

        private void btnCam1_Click(object sender, EventArgs e)
        {
            if (Globals.gVideoList[0] != null)
            {
                Globals.gThread[0].Abort();
                Globals.gVideoList[0].Release();
                Globals.gFrame[0].Release();
                return;
            }

            btnCam1.Text = "Stop1";
            Globals.gThread[0] = new Thread(new ThreadStart(CameraCallback0));
            Globals.gThread[0].Start();

        }

        private void btnCam2_Click(object sender, EventArgs e)
        {
            if (Globals.gVideoList[1] != null)
            {
                Globals.gThread[1].Abort();
                Globals.gVideoList[1].Release();
                Globals.gFrame[1].Release();
                return;
            }

            btnCam2.Text = "Stop2";
            Globals.gThread[1] = new Thread(new ThreadStart(CameraCallback1));
            Globals.gThread[1].Start();

        }

        private void btnCam3_Click(object sender, EventArgs e)
        {
            if (Globals.gVideoList[2] != null)
            {
                StopCamera(2);
                return;
            }

            StartCamera(2);
        }

        private void btnCam4_Click(object sender, EventArgs e)
        {
            if (Globals.gVideoList[3] != null)
            {
                StopCamera(3);
                return;
            }

            StartCamera(3);
        }

        private void StartCamera(int index)
        {

            if (index == 0)
                Globals.gThread[index] = new Thread(new ThreadStart(CameraCallback0));
            else if (index == 1)
                Globals.gThread[index] = new Thread(new ThreadStart(CameraCallback1));
            else if (index == 2)
                Globals.gThread[index] = new Thread(new ThreadStart(CameraCallback2));
            else if (index == 3)
                Globals.gThread[index] = new Thread(new ThreadStart(CameraCallback3));
            else
                return;

            Globals.gThread[index].Start();
            CameraButton[index].Text = "Stop";
        }

        private void StopCamera(int index)
        {
            Globals.gThread[index].Abort();
            Globals.gVideoList[index].Release();
            Globals.gFrame[index].Release();
            CameraButton[index].Text = "Start";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Globals.gCurrentIndex != (int)FORM_INDEX.NO_FORM_MAIN)
                Globals.ChangeForm((int)FORM_INDEX.NO_FORM_MAIN);
        }
    }
}
