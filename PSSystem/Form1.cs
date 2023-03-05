using GitHub.secile.Video;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.DirectoryServices;
using System.Windows.Forms;

namespace PSSystem
{
    enum FORM_INDEX
    {
        NO_FORM_NONE = 0,
        NO_FORM_LOGO = 0,       // Initial
        NO_FORM_MAIN = 1,       // 상시화면
        NO_FORM_MENU = 2,       // 설정화면
        NO_FORM_SET_PANEL,      // 배전반
        NO_FORM_SET_WARNING,
        NO_FORM_SET_CRITICAL,
        NO_FORM_SET_NUMSENSOR = 6,
        NO_FORM_SET_RELAY,
        NO_FORM_SET_STATE = 8,
        NO_FORM_SET_DATA,
        NO_FORM_SET_VIDEO = 10,
        NO_FORM_SET_WIFI,
        NO_FORM_EVENT,
        NO_FORM_FORMTOP_BASE = 13,
        NO_FORM_FORMTOP_1,
        NO_FORM_FORMTOP_2,
        NO_FORM_FORMBOTTOM_BASE = 16,
        NO_FORM_FORMBOTTOM_1,
        NO_FORM_FORMBOTTOM_2
    };

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Globals.gCurrentIndex = 0;
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_LOGO] = new FormLogo();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_MAIN] = new FormMain();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_MENU] = new FormMenu();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_PANEL] = new FormSetPanel();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_WARNING] = new FormSetWarning();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_CRITICAL] = new FormSetCritical();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_NUMSENSOR] = new FormSetNumSensor();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_RELAY] = new FormSetRelay();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_STATE] = new FormSetState();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_DATA] = new FormSetData();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_VIDEO] = new FormSetVideo();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_SET_WIFI] = new FormSetWifi();
            Globals.gFormList[(int)FORM_INDEX.NO_FORM_EVENT] = new FormEvent();
            Globals.gMainForm = this;

            Globals.gNumCam = Globals.gDevices.Length;

            for (int i = 0; i < Globals.MAX_COUNT; i++)
            {
                Globals.gFormList[i].TopLevel = false;
                Globals.gFormList[i].Size = new System.Drawing.Size(800, 536);
                Globals.gFormList[i].BackgroundImage = Properties.Resources.back1;
                panelMiddle.Controls.Add(Globals.gFormList[i]);
            }
            Globals.gFormList[0].Show();
            panel1.BackgroundImage = Properties.Resources.back;
            lblModelName.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            lblDate.BackColor = Color.Transparent;
            btnMenu.BackColor = Color.Transparent;
        }


        public void ShowTopMenu()
        {
            lblModelName.Visible = true;
            lblDate.Visible = true;
            label1.Visible = true;
            btnMenu.Visible = true;
        }

        static public void ShowControls()
        {
            ((Form1)Globals.gMainForm).ShowTopMenu();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (Globals.gCurrentIndex != (int)FORM_INDEX.NO_FORM_MENU)
                Globals.ChangeForm((int)FORM_INDEX.NO_FORM_MENU);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            // display Time
            if (lblDate.Visible)
            {
                lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }
        }
    }
}