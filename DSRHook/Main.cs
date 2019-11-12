using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using DSRHook.Addresses;
using DSRHook.XInput;

namespace DSRHook
{
    public partial class Main : Form
    {
        private Xbox360Controller _controller;
        public Main()
        {
            InitializeComponent();
             _controller = new Xbox360Controller();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //WorldChrBase.ToggleDraw = 64;
            WorldChrBase.TeamType = 4;
            Quelaag.TeamType = 4;

            WorldChrBase.NoDamage = 1;
            WorldChrBase.NoDead = 16;
            WorldChrBase.NoHit = 64;

            //while (true)
            //{
                //Thread.Sleep(50);
                //Quelaag.AssignHomeToCurrent();
            
                /*if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }*/
            //}
        }

        private void ChrValue_Click(object sender, EventArgs e)
        {
            ChrClassWarp.LastBonfire = 
            
            WorldChrBase.NoDamage = (int)noDamage.Value;
            WorldChrBase.NoGravity = (int)noGravity.Value; //32
            WorldChrBase.DisableMapHit = (int)noMapHit.Value; //8
        }

        private void teamType_Click(object sender, EventArgs e)
        {
            Quelaag.TeamType = (int) enemyTeam.Value;
        }

        private void teamTypePlayer_Click(object sender, EventArgs e)
        {
            WorldChrBase.TeamType = (int)playerTeam.Value;
        }

        private void backgroundWorker_Click(object sender, EventArgs e)
        {
            if(!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void cancelWorker_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void teleport_Click(object sender, EventArgs e)
        {
            var store = Quelaag.EnemyQuelaag;

            /*WorldChrBase.NoGravity = 32;

            for (int i = 0; i < 10; i++)
            {
                WorldChrBase.CurrentLocationX = Quelaag.CurrentLocationX;
                WorldChrBase.CurrentLocationY = Quelaag.CurrentLocationY+2;
                WorldChrBase.CurrentLocationZ = Quelaag.CurrentLocationZ;
            }

            WorldChrBase.NoGravity = 0;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CameraOverride.CameraDistance = (float) cameraOvr.Value;
            _controller.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CameraOverride.ShiftCameraUp = (float) cameraY.Value;
        }
    }
}
