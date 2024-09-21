namespace LabControls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class RGB : UserControl
    {
        private Color _currentColor;

        private NumberTB.Mode _currentType;

        public event EventHandler ChangeColorEvent;

        public RGB()
        {
            InitializeComponent();
            _currentType = NumberTB.Mode.Dec;
            ntbRed.Text = @"0";
            ntbGreen.Text = @"0";
            ntbBlue.Text = @"0";
            CurColor = Color.Black;
            rbtnDec.Checked = true;
            DrawRectangle();
        }

        public Color CurColor
        {
            get => _currentColor;
            set
            {
                _currentColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (DesignMode)
            {
                e.Graphics.DrawRectangle(new Pen(_currentColor, 2), 140, 10, 100, 120);
                ntbRed.Text = _currentColor.R.ToString();
                ntbGreen.Text = _currentColor.G.ToString();
                ntbBlue.Text = _currentColor.B.ToString();
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(_currentColor), 140, 10, 100, 120);
            }
        }

        private void RbutDecCheckedChanged(object sender, EventArgs e)
        {
            if (_currentType != NumberTB.Mode.Hex)
            {
                return;
            }

            _currentType = NumberTB.Mode.Dec;
            ntbRed.TextMode = _currentType;
            ntbGreen.TextMode = _currentType;
            ntbBlue.TextMode = _currentType;
        }

        private void RbutHexCheckedChanged(object sender, EventArgs e)
        {
            if (_currentType != NumberTB.Mode.Dec)
            {
                return;
            }

            _currentType = NumberTB.Mode.Hex;
            ntbRed.TextMode = _currentType;
            ntbGreen.TextMode = _currentType;
            ntbBlue.TextMode = _currentType;
        }

        private void DrawRectangle()
        {
            var graphics = CreateGraphics();
            var rectangle = new Rectangle(150, 20, 100, 120);
            OnPaint(new PaintEventArgs(graphics, rectangle));
        }

        private void ChangeColor()
        {
            if (!ntbRed.Focused && !ntbGreen.Focused && !ntbBlue.Focused)
            {
                return;
            }

            if (ntbRed.Text == string.Empty || ntbGreen.Text == string.Empty || ntbBlue.Text == string.Empty
                || ntbRed.TextMode != ntbGreen.TextMode || ntbGreen.TextMode != ntbBlue.TextMode)
            {
                return;
            }

            CurColor = _currentType == NumberTB.Mode.Dec
                           ? Color.FromArgb(int.Parse(ntbRed.Text), int.Parse(ntbGreen.Text), int.Parse(ntbBlue.Text))
                           : Color.FromArgb(
                               Convert.ToInt32(ntbRed.Text, 16),
                               Convert.ToInt32(ntbGreen.Text, 16),
                               Convert.ToInt32(ntbBlue.Text, 16));
            ChangeColorEvent?.Invoke(this, null);
        }

        private void NtbRedTextChanged(object sender, EventArgs e)
        {
            ChangeColor();
            DrawRectangle();
        }

        private void NtbGreenTextChanged(object sender, EventArgs e)
        {
            ChangeColor();
            DrawRectangle();
        }

        private void NtbBlueTextChanged(object sender, EventArgs e)
        {
            ChangeColor();
            DrawRectangle();
        }
    }
}
