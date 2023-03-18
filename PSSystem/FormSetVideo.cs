using OpenCvSharp;
using OpenCvSharp.Flann;
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
        int CurrentCam = -1;

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
            int ix = 0;
            Globals.gFrame[ix] = new Mat();
            Globals.gVideoList[ix] = new VideoCapture(ix, VideoCaptureAPIs.DSHOW);

            if (!Globals.gVideoList[ix].IsOpened())
            {
                MessageBox.Show("첫번째 카메라를 열 수 없습니다. 연결 확인해 주세요");
                return;
            }

            Globals.gIsAlive[ix] = 1;
            while (Globals.gIsAlive[ix] == 1)
            {
                Globals.gVideoList[ix].Read(Globals.gFrame[ix]);
                ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Globals.gFrame[ix]), ix);
            }
            Globals.gVideoList[ix].Release();
            Globals.gFrame[ix].Release();

            Globals.gVideoList[ix] = null;
        }

        private void CameraCallback1()
        {
            int ix = 1;
            Globals.gFrame[ix] = new Mat();
            Globals.gVideoList[ix] = new VideoCapture(ix, VideoCaptureAPIs.DSHOW);

            if (!Globals.gVideoList[ix].IsOpened())
            {
                MessageBox.Show("두번째 카메라를 열 수 없습니다. 연결 확인해 주세요");
                return;
            }

            Globals.gIsAlive[ix] = 1;
            while (Globals.gIsAlive[ix] == 1)
            {
                Globals.gVideoList[ix].Read(Globals.gFrame[ix]);
                ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Globals.gFrame[ix]), ix);
            }
            Globals.gVideoList[ix].Release();
            Globals.gFrame[ix].Release();

            Globals.gVideoList[ix] = null;
        }

        private void CameraCallback2()
        {
            int ix = 2;
            Globals.gFrame[ix] = new Mat();
            Globals.gVideoList[ix] = new VideoCapture(ix, VideoCaptureAPIs.DSHOW);

            if (!Globals.gVideoList[ix].IsOpened())
            {
                MessageBox.Show("세번째 카메라를 열 수 없습니다. 연결 확인해 주세요");
                return;
            }

            Globals.gIsAlive[ix] = 1;
            while (Globals.gIsAlive[ix] == 1)
            {
                Globals.gVideoList[ix].Read(Globals.gFrame[ix]);
                ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Globals.gFrame[ix]), ix);
            }
            Globals.gVideoList[ix].Release();
            Globals.gFrame[ix].Release();

            Globals.gVideoList[ix] = null;
        }

        private void CameraCallback3()
        {
            int ix = 3;
            Globals.gFrame[ix] = new Mat();
            Globals.gVideoList[ix] = new VideoCapture(ix, VideoCaptureAPIs.DSHOW);

            if (!Globals.gVideoList[ix].IsOpened())
            {
                MessageBox.Show("네번째 카메라를 열 수 없습니다. 연결 확인해 주세요");
                return;
            }

            Globals.gIsAlive[ix] = 1;
            while (Globals.gIsAlive[ix] == 1)
            {
                Globals.gVideoList[ix].Read(Globals.gFrame[ix]);
                ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Globals.gFrame[ix]), ix);
            }
            Globals.gVideoList[ix].Release();
            Globals.gFrame[ix].Release();

            Globals.gVideoList[ix] = null;
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
            if (Globals.gIsAlive[index] == 0)
                return;
            Globals.gIsAlive[index] = 0;
            Globals.gThread[index].Join();
            CameraButton[index].Text = "Start";
        }

        private void btnCam1_Click(object sender, EventArgs e)
        {
            if (Globals.gVideoList[0] != null)
            {
                StopCamera(0);
                return;
            }

            StartCamera(0);
        }

        private void btnCam2_Click(object sender, EventArgs e)
        {
            if (Globals.gVideoList[1] != null)
            {
                StopCamera(1);
                return;
            }

            StartCamera(1);
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Globals.gCurrentIndex != (int)FORM_INDEX.NO_FORM_MAIN)
                Globals.ChangeForm((int)FORM_INDEX.NO_FORM_MAIN);
        }

        private void FormSetVideo_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < Globals.MAX_CAMERA; i++)
                StopCamera(i);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentCam = (CurrentCam + 1) % Globals.gNumCam;
            StopCamera((CurrentCam + Globals.gNumCam - 1) % Globals.gNumCam);
            StartCamera(CurrentCam);
        }
    }
}
