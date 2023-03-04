using GitHub.secile.Video;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.DirectoryServices;
using System.Windows.Forms;

namespace PSSystem
{
    enum FORM_INDEX {
        NO_FORM_NONE = 0,
        NO_FORM_LOGO = 0,
        NO_FORM_MAIN = 1,
        NO_FORM_MENU = 2,
        NO_FORM_FORMA,
        NO_FORM_FORMA1,
        NO_FORM_FORMA2,
        NO_FORM_FORMB = 6,
        NO_FORM_FORMB1,
        NO_FORM_FORMC=8,
        NO_FORM_FORMC1,
        NO_FORM_FORMD = 10,
        NO_FORM_FORMD1,
        NO_FORM_FORMD2,
        NO_FORM_FORMTOP_BASE=13,
        NO_FORM_FORMTOP_1,
        NO_FORM_FORMTOP_2,
        NO_FORM_FORMBOTTOM_BASE=16,
        NO_FORM_FORMBOTTOM_1,
        NO_FORM_FORMBOTTOM_2
    };
    public partial class Form1 : Form
    {
        const int MAX_COUNT = 13;
        int gCurrentIndex = 0;
        int gCurrentCam = 0;
        Form[] gFormList = new Form[MAX_COUNT];
        Mat[] gFrame = new Mat[MAX_COUNT];
        VideoCapture[] gVideoList = new VideoCapture[MAX_COUNT];
        Thread[] gThread = new Thread[MAX_COUNT];

        string[] gDevices = UsbCamera.FindDevices();
        int gNumCam = 0;

        public Form1()
        {
            InitializeComponent();
            gFormList[0] = new FormLogo();
            gFormList[1] = new FormMain();
            gFormList[2] = new FormMenu();
            gFormList[3] = new FormA();
            gFormList[4] = new FormA1();
            gFormList[5] = new FormA2();
            gFormList[6] = new FormB();
            gFormList[7] = new FormB1();
            gFormList[8] = new FormC();
            gFormList[9] = new FormC1();
            gFormList[10] = new FormD();
            gFormList[11] = new FormD1();
            gFormList[12] = new FormD2();


            gNumCam = gDevices.Length;

            for (int i = 0;i < MAX_COUNT; i++)
            {
                gFormList[i].TopLevel = false;
                gFormList[i].Size = new System.Drawing.Size(800, 536);
                gFormList[i].BackgroundImage = Properties.Resources.back;
                panelMiddle.Controls.Add(gFormList[i]);
            }
            gFormList[0].Show();    
            panel1.BackgroundImage = Properties.Resources.back;
        }

        private void ChangeForm(int index)
        {
            gFormList[index].Show();
            gFormList[gCurrentIndex].Hide();
            //panelMiddle.Controls.Clear();
            //panelMiddle.Controls.Add(gFormList[index]);
            gCurrentIndex = index;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            ChangeForm((int) FORM_INDEX.NO_FORM_FORMA);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            ChangeForm((int)FORM_INDEX.NO_FORM_FORMB);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            ChangeForm((int)FORM_INDEX.NO_FORM_MAIN);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (gCurrentIndex == 0)
                ChangeForm(MAX_COUNT - 1);
            else
                ChangeForm(gCurrentIndex - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (gCurrentIndex == (MAX_COUNT-1))
                ChangeForm(0);
            else
                ChangeForm(gCurrentIndex + 1); ;
        }

        private void btnCam1_Click(object sender, EventArgs e)
        {
            gVideoList[0] = new VideoCapture(0);
            gFrame[0] = new Mat();
            
            FormLogo f1 = (FormLogo)gFormList[0];

            while (Cv2.WaitKey(33) != 'q')
            {
                gVideoList[0].Read(gFrame[0]);
                f1.ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(gFrame[0]), 0);
                //Cv2.ImShow("frame", frame);
            }

            gFrame[0].Dispose();
            gVideoList[0].Release();
            Cv2.DestroyAllWindows();
        }

        private void btnCam2_Click(object sender, EventArgs e)
        {
            if (gNumCam < 2)
                return;

            gVideoList[1] = new VideoCapture(1);
            gFrame[1] = new Mat();

            FormLogo f2 = (FormLogo)gFormList[0];
            while (Cv2.WaitKey(33) != 'q')
            {
                gVideoList[1].Read(gFrame[1]);
                f2.ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(gFrame[1]), 1);
                //Cv2.ImShow("frame", frame);
            }

            gFrame[1].Dispose();
            gVideoList[1].Release();
            Cv2.DestroyAllWindows();
            gVideoList[1] = null;
        }

        private void btnCam3_Click(object sender, EventArgs e)
        {
            if (gVideoList[0] != null)
            {
                gThread[0].Abort();
                gVideoList[0].Release();
                gFrame[0].Release();
                return;
            }

            gThread[0] = new Thread(new ThreadStart(CameraCallback));
            gThread[0].Start();
            btnCam3.Text = "Stop3";

        }

        private void CameraCallback()
        {
            gFrame[0] = new Mat();
            gVideoList[0] = new VideoCapture(0, VideoCaptureAPIs.DSHOW);
            while (true)
            {
                gVideoList[0].Read(gFrame[0]);
                ((FormLogo)gFormList[0]).ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(gFrame[0]), 0);
                ((FormLogo)gFormList[0]).ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(gFrame[0]), 2);

            }
        }
        private void CameraCallback1()
        {
            FrameSource frameSource;
            gFrame[1] = new Mat();
            gVideoList[1] = new VideoCapture(1,VideoCaptureAPIs.DSHOW);
            //frameSource = Cv2.CreateFrameSource_Camera(1);
            while (true)
            {
                //frameSource.NextFrame(gFrame[1]);
                gVideoList[1].Read(gFrame[1]);
                ((FormLogo)gFormList[0]).ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(gFrame[1]), 1);
                ((FormLogo)gFormList[0]).ShowImage(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(gFrame[1]), 3);

            }
        }

        private void btnCam4_Click(object sender, EventArgs e)
        {
            if (gVideoList[1] != null)
            {
                gThread[1].Abort();
                gVideoList[1].Release();
                gFrame[1].Release();
                return;
            }

            gThread[1] = new Thread(new ThreadStart(CameraCallback1));
            gThread[1].Start();
            btnCam4.Text = "Stop4";
        }
    }
}