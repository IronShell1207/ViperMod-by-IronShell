// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.Utils.Win32GDI.GDIRender
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ViPER4WindowsBin.Utils.Win32GDI
{
    internal class GDIRender
    {
        private const int SRCCOPY = 13369376;
        private Panel backgroundGraph;
        private Graphics backgroundGraphic;
        private Graphics backgroundRenderGraphic;
        private Graphics backgroundMemoryGraphic;
        private Graphics backgroundDrawGraphic;
        private Bitmap backgroundMemoryBitmap;
        private BufferedGraphics graphicsBuffer;
        private IntPtr memoryGraphicHdc;
        private IntPtr memoryBitmapHdc;
        private readonly GDIMutex RenderLock;
        private DRAW_QUALITY DrawQuality;

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateCompatibleDC(IntPtr __pHDC);

        [DllImport("gdi32.dll")]
        private static extern IntPtr SelectObject(IntPtr __pHDC, IntPtr __pObject);

        [DllImport("gdi32.dll")]
        private static extern int BitBlt(
          IntPtr __pHdcDest,
          int __nXDest,
          int __nYDest,
          int __nWidth,
          int __nHeight,
          IntPtr __pHdcSrc,
          int __nXSrc,
          int __nYSrc,
          int __dwRop);

        [DllImport("gdi32.dll")]
        private static extern bool DeleteObject(IntPtr __pObject);

        public GDIRender()
        {
            backgroundGraphic = null;
            backgroundRenderGraphic = null;
            backgroundMemoryGraphic = null;
            backgroundDrawGraphic = null;
            backgroundMemoryBitmap = null;
            graphicsBuffer = null;
            DrawQuality = DRAW_QUALITY.QUALITY_SUPER_HIGH;
            RenderLock = new GDIMutex(false);
        }

        ~GDIRender()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (backgroundGraphic != null)
            {
                backgroundGraphic.Dispose();
            }

            backgroundGraphic = null;
            if (graphicsBuffer != null)
            {
                graphicsBuffer.Dispose();
            }

            graphicsBuffer = null;
            if (backgroundRenderGraphic != null)
            {
                backgroundRenderGraphic.Dispose();
            }

            backgroundRenderGraphic = null;
            if (backgroundMemoryBitmap != null)
            {
                GDIRender.DeleteObject(memoryBitmapHdc);
                backgroundMemoryBitmap.Dispose();
            }
            backgroundMemoryBitmap = null;
            if (backgroundMemoryGraphic != null)
            {
                GDIRender.DeleteObject(memoryGraphicHdc);
                backgroundMemoryGraphic.Dispose();
            }
            backgroundMemoryGraphic = null;
            if (backgroundDrawGraphic != null)
            {
                backgroundDrawGraphic.Dispose();
            }

            backgroundDrawGraphic = null;
        }

        public int ResetDraw(Panel GraphOle, Color BackColor)
        {
            if (GraphOle == null || GraphOle.GetType() != typeof(Panel) || GraphOle.ClientRectangle.Width < 1 || GraphOle.ClientRectangle.Height < 1)
            {
                return -1;
            }

            RenderLock.WaitLock();
            backgroundGraph = GraphOle;
            lock (backgroundGraph)
            {
                if (backgroundGraphic != null)
                {
                    backgroundGraphic.Dispose();
                }

                if (graphicsBuffer != null)
                {
                    graphicsBuffer.Dispose();
                }

                if (backgroundRenderGraphic != null)
                {
                    backgroundRenderGraphic.Dispose();
                }

                if (backgroundMemoryBitmap != null)
                {
                    GDIRender.DeleteObject(memoryBitmapHdc);
                    backgroundMemoryBitmap.Dispose();
                }
                if (backgroundMemoryGraphic != null)
                {
                    GDIRender.DeleteObject(memoryGraphicHdc);
                    backgroundMemoryGraphic.Dispose();
                }
                if (backgroundDrawGraphic != null)
                {
                    backgroundDrawGraphic.Dispose();
                }

                backgroundGraphic = backgroundGraph.CreateGraphics();
                graphicsBuffer = BufferedGraphicsManager.Current.Allocate(backgroundGraphic, backgroundGraph.ClientRectangle);
                backgroundRenderGraphic = graphicsBuffer.Graphics;
                backgroundRenderGraphic.Clear(BackColor);
                backgroundRenderGraphic.SetClip(backgroundGraph.ClientRectangle);
                backgroundMemoryBitmap = new Bitmap(backgroundGraph.ClientRectangle.Width, backgroundGraph.ClientRectangle.Height, backgroundRenderGraphic);
                backgroundMemoryGraphic = Graphics.FromImage(backgroundMemoryBitmap);
                backgroundMemoryGraphic.Clear(BackColor);
                memoryGraphicHdc = GDIRender.CreateCompatibleDC(backgroundMemoryGraphic.GetHdc());
                memoryBitmapHdc = backgroundMemoryBitmap.GetHbitmap();
                GDIRender.SelectObject(memoryGraphicHdc, memoryBitmapHdc);
                backgroundDrawGraphic = Graphics.FromHdc(memoryGraphicHdc);
                switch (DrawQuality)
                {
                    case DRAW_QUALITY.QUALITY_SUPER_HIGH:
                        backgroundDrawGraphic.SmoothingMode = SmoothingMode.HighQuality;
                        backgroundDrawGraphic.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                        backgroundDrawGraphic.InterpolationMode = InterpolationMode.HighQualityBilinear;
                        backgroundDrawGraphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        break;
                    case DRAW_QUALITY.QUALITY_HIGH:
                        backgroundDrawGraphic.SmoothingMode = SmoothingMode.AntiAlias;
                        backgroundDrawGraphic.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                        backgroundDrawGraphic.InterpolationMode = InterpolationMode.Bilinear;
                        backgroundDrawGraphic.PixelOffsetMode = PixelOffsetMode.Half;
                        break;
                    case DRAW_QUALITY.QUALITY_MIDDLE:
                        backgroundDrawGraphic.SmoothingMode = SmoothingMode.HighSpeed;
                        backgroundDrawGraphic.TextRenderingHint = TextRenderingHint.AntiAlias;
                        backgroundDrawGraphic.InterpolationMode = InterpolationMode.NearestNeighbor;
                        backgroundDrawGraphic.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                        break;
                    case DRAW_QUALITY.QUALITY_LOW:
                        backgroundDrawGraphic.SmoothingMode = SmoothingMode.None;
                        backgroundDrawGraphic.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
                        backgroundDrawGraphic.InterpolationMode = InterpolationMode.Low;
                        backgroundDrawGraphic.PixelOffsetMode = PixelOffsetMode.None;
                        break;
                }
            }
            RenderLock.Unlock();
            return 0;
        }

        public void SetDrawQuality(DRAW_QUALITY NewQuality)
        {
            DrawQuality = NewQuality;
        }

        public void BeginRender()
        {
            RenderLock.WaitLock();
        }

        public void EndRender()
        {
            RenderLock.Unlock();
        }

        public Graphics GetGraphicHandle()
        {
            return backgroundDrawGraphic;
        }

        public IntPtr BeginUnmanaged()
        {
            return backgroundDrawGraphic.GetHdc();
        }

        public void EndUnmanaged()
        {
            backgroundDrawGraphic.ReleaseHdc();
        }

        public void BltToFront()
        {
            RenderLock.WaitLock();
            try
            {
                GDIRender.BitBlt(backgroundRenderGraphic.GetHdc(), 0, 0, backgroundGraph.ClientRectangle.Width, backgroundGraph.ClientRectangle.Height, backgroundDrawGraphic.GetHdc(), 0, 0, 13369376);
                backgroundDrawGraphic.ReleaseHdc();
                backgroundRenderGraphic.ReleaseHdc();
                graphicsBuffer.Render(backgroundGraphic);
            }
            finally
            {
                RenderLock.Unlock();
            }
        }

        public void BltToFront(int srcX, int srcY, int dstX, int dstY, int Width, int Height)
        {
            RenderLock.WaitLock();
            try
            {
                IntPtr hdc = backgroundDrawGraphic.GetHdc();
                GDIRender.BitBlt(backgroundRenderGraphic.GetHdc(), dstX, dstY, Width, Height, hdc, srcX, srcY, 13369376);
                backgroundDrawGraphic.ReleaseHdc();
                backgroundRenderGraphic.ReleaseHdc();
                graphicsBuffer.Render(backgroundGraphic);
            }
            finally
            {
                RenderLock.Unlock();
            }
        }
    }
}
