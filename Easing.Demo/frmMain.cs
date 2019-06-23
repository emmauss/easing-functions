namespace Easing.Demo
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Easing;

    public partial class frmMain : Form
    {
        private Ease ease;
        private int time;
        private int duration = 1000;
        private Point start = new Point(12, 29);
        private Point end = new Point(732, 29);

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            float distance = end.X - start.X;

            // Ease instantiation
            ease = new Quintic(new Vector(duration, distance));

            lblMovingLabel.Location = start;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time += timer.Interval;

            // Ease calculation.
            int deltaDistance = (int)ease.InOut(time % duration);

            if (ShouldMoveRight())
            {
                lblMovingLabel.Location = new Point(start.X + deltaDistance, lblMovingLabel.Location.Y);
            }
            else if (ShouldMoveLeft())
            {
                lblMovingLabel.Location = new Point(end.X - deltaDistance, lblMovingLabel.Location.Y);
            }
        }

        private bool ShouldMoveRight()
        {
            return (time / duration) % 2 == 0;
        }

        private bool ShouldMoveLeft()
        {
            return (time / duration) % 2 == 1;
        }
    }
}
