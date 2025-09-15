class Graphics
{
    public Graphics(WriteableBitmap bitmap)
    {
        Bitmap = bitmap;
    }
    public WriteableBitmap Bitmap { get; }
    public void Clean()
    {
        unsafe
        {
            var ptr = Bitmap.BackBuffer;
            var sptr = ptr;
            Bitmap.Lock();
            for (int y = 0; y < Bitmap.PixelWidth; y++)
            {
                for (int x = 0; x < Bitmap.PixelHeight; x++)
                {
                    ptr += 4;
                    unsafe
                    {
                        *((int*)ptr) = 0;
                    }
                }
                ptr = sptr + Bitmap.BackBufferStride;
                sptr = ptr;
            }
            Bitmap.AddDirtyRect(new(0, 0, Bitmap.PixelWidth, Bitmap.PixelHeight));
            Bitmap.Unlock();
        }
    }
    public void FillWith(Color color)
    {
        var n = (color.R << 16) | (color.G << 8) | color.B;
        unsafe
        {
            var ptr = Bitmap.BackBuffer;
            var sptr = ptr;
            Bitmap.Lock();
            for (int y = 0; y < Bitmap.PixelWidth; y++)
            {
                for (int x = 0; x < Bitmap.PixelHeight; x++)
                {
                    ptr += 4;
                    unsafe
                    {
                        *((int*)ptr) = n;
                    }
                }
                ptr = sptr + Bitmap.BackBufferStride;
                sptr = ptr;
            }
            Bitmap.AddDirtyRect(new(0, 0, Bitmap.PixelWidth, Bitmap.PixelHeight));
            Bitmap.Unlock();
        }
    }
}