namespace QuizGame
{
    public class CustomProgressBar : ProgressBar
    {
        public int Red { get; set; } = 90;  // Default red value
        public int Green { get; set; } = 191;   // Default green value
        public int Blue { get; set; } = 173;    // Default blue value

        public CustomProgressBar()
    {
        // Enable custom painting
        this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        // Draw the border
        Rectangle borderRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
        e.Graphics.DrawRectangle(Pens.Black, borderRectangle);

        // Calculate the area for the filled portion
        Rectangle rec = new Rectangle(2, 2, this.Width - 4, this.Height - 4);
        int fillWidth = (int)(rec.Width * ((double)Value / Maximum));

        // Create the color from the RGB properties
        Color fillColor = Color.FromArgb(Red, Green, Blue);
        using (SolidBrush brush = new SolidBrush(fillColor))
        {
            // Draw the progress bar fill with the specified color
            if (fillWidth > 0)
            {
                e.Graphics.FillRectangle(brush, new Rectangle(2, 2, fillWidth, rec.Height));
            }
        }
    }
    }
}
