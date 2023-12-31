﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Biblivres.Forms;
using FontAwesome.Sharp;

namespace Biblivres
{
    // Structs
    public struct RGBColors
    {
        public static Color color1 = Color.FromArgb(172, 126, 241);
        public static Color color2 = Color.FromArgb(249, 118, 176);
        public static Color color3 = Color.FromArgb(253, 138, 114);
        public static Color color4 = Color.FromArgb(95, 77, 221);
        public static Color color5 = Color.FromArgb(249, 88, 155);
        public static Color color6 = Color.FromArgb(24, 161, 251);
    }

    public partial class FormMainMenu : Form
    {
        // Fields
        private readonly int borderSize = 4;
        private IconButton currentBtn;
        private Form currentChilfForm;
        private Size formSize;
        private readonly Panel leftBorderBtn;

        // Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 100);
            sideBar.Controls.Add(leftBorderBtn);
            //Form
            DoubleBuffered = true;
            MaximizedBounds = Screen.GetWorkingArea(this);

            Padding = new Padding(borderSize);
            BackColor = Color.FromArgb(98, 102, 244);
        }

        // Methods
        public void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        public void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form chilForm)
        {
            if (currentChilfForm != null)
                // open only form 
                currentChilfForm.Close();
            currentChilfForm = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(chilForm);
            panelMain.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();
            labelCurrentChildForm.Text = chilForm.Name;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (Padding.Top != borderSize)
                        Padding = new Padding(borderSize);
                    break;
            }
        }

        private void iconBtnRead_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormRead(RGBColors.color1, this));
        }

        private void iconBtnNew_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormNew(RGBColors.color2, this));
        }

        private void iconBtnManage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormManage(RGBColors.color3, this));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChilfForm != null) currentChilfForm.Close();
            Reset();
        }

        public void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            labelCurrentChildForm.Text = "Home";
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083; //Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int
                WM_NCHITTEST =
                    0x0084; //Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize

            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10; //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12; //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13; //Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14; //Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16; //Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17; //Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            {
                //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (WindowState == FormWindowState.Normal) //Resize the form if it is in normal state
                    if ((int)m.Result ==
                        HTCLIENT) //If the result of the m (mouse pointer) is in the client area of the window
                    {
                        var screenPoint =
                            new Point(m.LParam
                                .ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        var clientPoint =
                            PointToClient(
                                screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <=
                            resizeAreaSize) //If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <=
                                resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if
                                (clientPoint.X <
                                 Size.Width -
                                 resizeAreaSize) //If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if
                            (clientPoint.Y <=
                             Size.Height -
                             resizeAreaSize) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize) //Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > Width - resizeAreaSize) //Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize) //Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < Size.Width - resizeAreaSize) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }

                return;
            }

            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1) return;

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                var wParam = m.WParam.ToInt32() & 0xFFF0;

                if (wParam == SC_MINIMIZE) //Before
                    formSize = ClientSize;
                if (wParam == SC_RESTORE) // Restored form(Before)
                    Size = formSize;
            }

            base.WndProc(ref m);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            formSize = ClientSize;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}