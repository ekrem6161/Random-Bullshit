using System;
using System.Drawing;
using System.Windows.Forms;

namespace EkranButonu;

public sealed class MainForm : Form
{
    private const int WS_EX_NOACTIVATE = 0x08000000;
    private const int WS_EX_TOOLWINDOW = 0x00000080;

    private readonly Button _button;
    private readonly NotifyIcon _notifyIcon;
    private readonly ContextMenuStrip _menu;
    private readonly System.Windows.Forms.Timer _capsTimer;
    private readonly ToolTip _toolTip;

    private bool _rightButtonDown;
    private bool _rightDragMoved;
    private Point _dragStartCursor;
    private Point _dragStartLocation;

    public MainForm()
    {
        Text = "A Butonu";
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.Manual;
        TopMost = true;
        ShowInTaskbar = false;
        ClientSize = new Size(64, 64);
        BackColor = Color.FromArgb(21, 101, 192);
        Padding = new Padding(1);
        DoubleBuffered = true;

        var area = Screen.PrimaryScreen?.WorkingArea ?? new Rectangle(0, 0, 800, 600);
        Location = new Point(area.Right - Width - 24, area.Top + 80);

        _button = new Button
        {
            Text = "A",
            Dock = DockStyle.Fill,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 24f, FontStyle.Bold, GraphicsUnit.Point),
            ForeColor = Color.White,
            BackColor = Color.FromArgb(33, 150, 243),
            TabStop = false,
            Cursor = Cursors.Hand,
            UseVisualStyleBackColor = false,
        };
        _button.FlatAppearance.BorderSize = 0;
        _button.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 165, 245);
        _button.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 101, 192);
        _button.MouseDown += Button_MouseDown;
        _button.MouseMove += Button_MouseMove;
        _button.MouseUp += Button_MouseUp;
        _button.MouseEnter += (_, _) => UpdateCapsLockVisual();
        Controls.Add(_button);

        _menu = new ContextMenuStrip();
        _menu.Items.Add("Göster/Gizle", null, (_, _) => ToggleVisibility());
        _menu.Items.Add("Konumu sıfırla", null, (_, _) => ResetPosition());
        _menu.Items.Add(new ToolStripSeparator());
        _menu.Items.Add("Kapat", null, (_, _) => Close());
        _menu.Opening += (_, _) => UpdateMenuText();

        _notifyIcon = new NotifyIcon
        {
            Icon = SystemIcons.Application,
            Text = "A Butonu",
            Visible = true,
            ContextMenuStrip = _menu,
        };
        _notifyIcon.DoubleClick += (_, _) => ToggleVisibility();

        _toolTip = new ToolTip
        {
            AutoPopDelay = 5000,
            InitialDelay = 400,
            ReshowDelay = 200,
            ShowAlways = true,
        };
        _toolTip.SetToolTip(
            _button,
            "Sol tık: A yazar (Caps Lock'a göre)\nSağ tık: menü\nSağ tuşla sürükle: taşı");

        _capsTimer = new System.Windows.Forms.Timer { Interval = 150 };
        _capsTimer.Tick += (_, _) => UpdateCapsLockVisual();
        _capsTimer.Start();

        UpdateCapsLockVisual();
    }

    protected override CreateParams CreateParams
    {
        get
        {
            var cp = base.CreateParams;
            cp.ExStyle |= WS_EX_NOACTIVATE | WS_EX_TOOLWINDOW;
            return cp;
        }
    }

    protected override bool ShowWithoutActivation => true;

    private void Button_MouseDown(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            UpdateCapsLockVisual();
            SendA();
        }
        else if (e.Button == MouseButtons.Right)
        {
            _rightButtonDown = true;
            _rightDragMoved = false;
            _dragStartCursor = Cursor.Position;
            _dragStartLocation = Location;
            _button.Capture = true;
        }
    }

    private void Button_MouseMove(object? sender, MouseEventArgs e)
    {
        if (!_rightButtonDown)
            return;

        int dx = Cursor.Position.X - _dragStartCursor.X;
        int dy = Cursor.Position.Y - _dragStartCursor.Y;

        if (!_rightDragMoved && (Math.Abs(dx) > 3 || Math.Abs(dy) > 3))
            _rightDragMoved = true;

        if (_rightDragMoved)
            Location = new Point(_dragStartLocation.X + dx, _dragStartLocation.Y + dy);
    }

    private void Button_MouseUp(object? sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
            return;

        _rightButtonDown = false;
        _button.Capture = false;

        if (!_rightDragMoved)
            _menu.Show(Cursor.Position);
    }

    private static void SendA()
    {
        // Shift göndermiyoruz. Caps Lock açıksa Windows "A", kapalıysa "a" üretir.
        SendKeys.Send("a");
    }

    private void UpdateCapsLockVisual()
    {
        bool capsOn = Control.IsKeyLocked(Keys.CapsLock);
        string text = capsOn ? "A" : "a";

        if (_button.Text != text)
            _button.Text = text;
    }

    private void ToggleVisibility()
    {
        if (Visible)
            Hide();
        else
            Show();

        UpdateMenuText();
    }

    private void UpdateMenuText()
    {
        if (_menu.Items.Count > 0)
            _menu.Items[0].Text = Visible ? "Gizle" : "Göster";
    }

    private void ResetPosition()
    {
        var area = Screen.PrimaryScreen?.WorkingArea ?? new Rectangle(0, 0, 800, 600);
        Location = new Point(area.Right - Width - 24, area.Top + 80);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _capsTimer.Stop();
            _capsTimer.Dispose();
            _notifyIcon.Visible = false;
            _notifyIcon.Dispose();
            _toolTip.Dispose();
            _menu.Dispose();
        }

        base.Dispose(disposing);
    }
}
