using System.Windows.Threading;
namespace _3dAppTest;
public partial class MainWindow : Window
{
    private readonly DispatcherTimer _timer = new();
    private readonly WriteableBitmap _bitmap;
    private readonly Random _rng = new();
    private int _f;
    public MainWindow()
    {
        InitializeComponent();
        _timer.Interval = TimeSpan.FromSeconds(0.000001);
        _bitmap = new WriteableBitmap(1000, 1000, 96, 96, PixelFormats.Bgr32, null);
        image.Source = _bitmap;
        _timer.Tick += Tick;
        _timer.Start();
    }
    public void Tick(object? sender, EventArgs args)
    {
        var ptr = _bitmap.BackBuffer;
        var sptr = ptr;
        _bitmap.Lock();
        for (int y = 0; y < _bitmap.PixelWidth; y++)
        {
            for (int x = 0; x < _bitmap.PixelHeight; x++)
            {
                var r = x ^ y;
                var g = 0;
                var b = 0;
                ptr += 4;
                unsafe
                {
                    *((int*)ptr) = ((r << 16) | (g << 8) | b);
                }
            }
            ptr = sptr + _bitmap.BackBufferStride;
            sptr = ptr;
        }
        _bitmap.AddDirtyRect(new(0, 0, _bitmap.PixelWidth, _bitmap.PixelHeight));
        _bitmap.Unlock();
        _f++;
    }
}