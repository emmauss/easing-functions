namespace EaseDemonstration
{
    using System;
    using System.Windows.Forms;
    using Easing;

    public partial class frmMain : Form
    {
        private Ease ease;
        private EaseType easeType;
        private int ticks;

        // X will map the length of Time
        // Y will map our distance to travel.
        private Point origin;
        private Point destination;

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            origin = new Point(0, 5);
            destination = new Point((float)numDuration.Value / timer.Interval, 821);

            comboEaseSelection.SelectedIndex = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ticks >= ease.Destination.X)
            {
                timer.Stop();
            }
            else
            {
                ticks += timer.Interval;

                if (easeType == EaseType.In)
                {
                    MoveEaseInLabel();
                }
                else if (easeType == EaseType.Out)
                {
                    MoveEaseOutLabel();
                }
                else if (easeType == EaseType.InOut)
                {
                    MoveEaseInOutLabel();
                }
                else
                {
                    MoveEaseInLabel();
                    MoveEaseOutLabel();
                    MoveEaseInOutLabel();
                }
            }
        }

        private void MoveEaseInLabel()
        {
            //int newDistance = (int)ease.In(ticks).Y;

            //inLabel.Location = new System.Drawing.Point(newDistance, inLabel.Location.Y);
        }

        private void MoveEaseOutLabel()
        {
            //int newDistance = (int)ease.Out(ticks).Y;

            //outLabel.Location = new System.Drawing.Point(newDistance, inLabel.Location.Y);
        }

        private void MoveEaseInOutLabel()
        {
            //int newDistance = (int)ease.InOut(ticks).Y;

            //inOutLabel.Location = new System.Drawing.Point(newDistance, inLabel.Location.Y);
        }

        private void BtnPerformAll_Click(object sender, EventArgs e)
        {
            ResetAndStartTimer();
            easeType = EaseType.All;
        }

        private void BtnEaseIn_Click(object sender, EventArgs e)
        {
            ResetAndStartTimer();
            easeType = EaseType.In;
        }

        private void BtnEaseOut_Click(object sender, EventArgs e)
        {
            ResetAndStartTimer();
            easeType = EaseType.Out;
        }

        private void BtnEaseInOut_Click(object sender, EventArgs e)
        {
            ResetAndStartTimer();
            easeType = EaseType.InOut;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ComboEaseSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            origin = new Point(0, 5);
            destination = new Point((float)numDuration.Value / timer.Interval, 821);

            switch (comboEaseSelection.SelectedText)
            {
                case "Linear":
                    ease = new Linear(origin, destination);
                    break;

                case "Sine":
                    ease = new Sine(origin, destination);
                    break;

                case "Quadratic":
                    ease = new Quadratic(origin, destination);
                    break;

                case "Cubic":
                    ease = new Cubic(origin, destination);
                    break;

                case "Quartic":
                    ease = new Quartic(origin, destination);
                    break;

                case "Quintic":
                    ease = new Quintic(origin, destination);
                    break;

                default:
                    ease = new Linear(origin, destination);
                    break;
            }
        }

        private void NumDuration_ValueChanged(object sender, EventArgs e)
        {
            origin = new Point(0, 5);
            destination = new Point((float)numDuration.Value / timer.Interval, 821);
        }

        private void ResetAndStartTimer()
        {
            Reset();

            timer.Start();
        }

        private void Reset()
        {
            timer.Stop();

            ticks = 0;
            inLabel.Location = new System.Drawing.Point(5, inLabel.Location.Y);
            outLabel.Location = new System.Drawing.Point(5, inLabel.Location.Y);
            inOutLabel.Location = new System.Drawing.Point(5, inLabel.Location.Y);
        }

        private enum EaseType
        {
            In,
            Out,
            InOut,
            All
        }
    }
}
