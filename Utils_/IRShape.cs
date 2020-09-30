// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.UIControls.IRShape
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ViPER4WindowsBin.UIControls
{
    public class IRShape : UserControl
    {
        private Color m_clBackColor = Color.FromArgb(45, 45, 48);
        private Color m_clForeColor = Color.White;
        private readonly float[] m_fIRSamples = new float[256];
        private readonly IContainer components;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            AutoScaleDimensions = new SizeF(6f, 12f);
            AutoScaleMode = AutoScaleMode.Font;
            DoubleBuffered = true;
          //  Name = nameof(IRShape);
            Size = new Size(190, 63);
            ResumeLayout(false);
        }

        public IRShape()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);
        }

        public Color ShapeBackColor
        {
            get => m_clBackColor;
            set
            {
                m_clBackColor = value;
                Invalidate();
            }
        }

        public Color ShapeForeColor
        {
            get => m_clForeColor;
            set
            {
                m_clForeColor = value;
                Invalidate();
            }
        }

        public void SetImpulseResponse(float[] fIRSamples, int nChannels)
        {
            ZeroArray();
            if (fIRSamples == null || nChannels <= 0)
            {
                Invalidate();
            }
            else
            {
                int length = fIRSamples.Length / nChannels;
                if (length <= 0)
                {
                    Invalidate();
                }
                else
                {
                    float[] fArray = new float[length];
                    int num1 = 0;
                    int index1 = 0;
                    while (num1 < length * nChannels)
                    {
                        double num2 = 0.0;
                        for (int index2 = 0; index2 < nChannels; ++index2)
                        {
                            num2 += fIRSamples[num1 + index2];
                        }

                        double num3 = num2 / nChannels;
                        fArray[index1] = (float)num3;
                        num1 += nChannels;
                        ++index1;
                    }
                    ScaleArray(fArray);
                    Invalidate();
                }
            }
        }

        private void ZeroArray()
        {
            for (int index = 0; index < m_fIRSamples.Length; ++index)
            {
                m_fIRSamples[index] = 0.0f;
            }
        }

        private void ScaleArray(float[] fArray)
        {
            int num1 = fArray.Length / (m_fIRSamples.Length + 1);
            float num2 = 0.0f;
            int index1 = 0;
            for (int index2 = 0; index1 < fArray.Length && index2 < m_fIRSamples.Length; ++index2)
            {
                m_fIRSamples[index2] = fArray[index1];
                if (Math.Abs(m_fIRSamples[index2]) > (double)num2)
                {
                    num2 = Math.Abs(m_fIRSamples[index2]);
                }

                index1 += num1;
            }
            if (num2 <= 9.99999997475243E-07)
            {
                return;
            }

            float num3 = (float)(1.0 / (num2 + 9.99999997475243E-07));
            for (int index2 = 0; index2 < m_fIRSamples.Length; ++index2)
            {
                m_fIRSamples[index2] *= num3;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.Clear(Color.FromArgb(45, 45, 48));
            graphics.DrawRectangle(new Pen(Color.Gray, 1f), ClientRectangle);
            double num1 = (Width - 2.0) / (m_fIRSamples.Length + 1);
            PointF pt1 = new PointF(2f, Height / 2f);
            for (int index = 0; index < m_fIRSamples.Length; ++index)
            {
                float x = index * (float)num1 + 2f;
                if (x > Width - 1.0)
                {
                    break;
                }

                float num2 = Height / 2f + m_fIRSamples[index] * ((Height - 2) / 2f);
                if (num2 < 2.0)
                {
                    num2 = 2f;
                }

                if (num2 > Height - 2.0)
                {
                    num2 = Height - 2f;
                }

                float y = Height - num2;
                graphics.DrawLine(new Pen(m_clForeColor, 1f), pt1, new PointF(x, y));
                pt1.X = x;
                pt1.Y = y;
            }
        }
    }
}
