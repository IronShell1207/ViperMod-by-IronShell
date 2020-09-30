﻿// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.UIControls.TwoSelector
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ViPER4WindowsBin.UIControls
{
    public class TwoSelector : UserControl
    {
        private object m_objLeftObj;
        private object m_objRightObj;
        private TwoSelector.SelectorPosition m_spCurrentPosition;
        private readonly IContainer components;

        private event TwoSelector.SelectorChangeEventDelegate SelectorChanged;

        public event TwoSelector.SelectorChangeEventDelegate SelectorChangeNotify
        {
            add
            {
                SelectorChanged += value;
            }
            remove
            {
                SelectorChanged -= value;
            }
        }

        public TwoSelector()
        {
            InitializeComponent();
            m_objLeftObj = null;
            m_objRightObj = null;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.StandardClick, true);
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;
        }

        public object LeftObject
        {
            get => m_objLeftObj;
            set => m_objLeftObj = value;
        }

        public object RightObject
        {
            get => m_objRightObj;
            set => m_objRightObj = value;
        }

        public object CurrentObject
        {
            get => m_spCurrentPosition == TwoSelector.SelectorPosition.SELECTOR_ON_LEFT ? m_objLeftObj : m_objRightObj;
            set
            {
                if (m_objLeftObj == m_objRightObj)
                {
                    return;
                }

                if (value == m_objLeftObj)
                {
                    m_spCurrentPosition = TwoSelector.SelectorPosition.SELECTOR_ON_LEFT;
                    if (SelectorChanged != null)
                    {
                        SelectorChanged(m_spCurrentPosition, m_objLeftObj, this);
                    }

                    Invalidate();
                }
                else
                {
                    if (value != m_objRightObj)
                    {
                        return;
                    }

                    m_spCurrentPosition = TwoSelector.SelectorPosition.SELECTOR_ON_RIGHT;
                    if (SelectorChanged != null)
                    {
                        SelectorChanged(m_spCurrentPosition, m_objRightObj, this);
                    }

                    Invalidate();
                }
            }
        }

        public TwoSelector.SelectorPosition Selector
        {
            get => m_spCurrentPosition;
            set
            {
                m_spCurrentPosition = value;
                if (SelectorChanged != null)
                {
                    if (m_spCurrentPosition == TwoSelector.SelectorPosition.SELECTOR_ON_LEFT)
                    {
                        SelectorChanged(m_spCurrentPosition, m_objLeftObj, this);
                    }
                    else
                    {
                        SelectorChanged(m_spCurrentPosition, m_objRightObj, this);
                    }
                }
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.Clear(Color.White);
            graphics.DrawRectangle(new Pen(Color.Gray, 1f), 0, 0, Width, Height);
            if (m_spCurrentPosition == TwoSelector.SelectorPosition.SELECTOR_ON_LEFT)
            {
                graphics.FillEllipse(Brushes.SteelBlue, new RectangleF()
                {
                    X = 2f,
                    Y = 2f,
                    Width = ClientRectangle.Height - 4f,
                    Height = ClientRectangle.Height - 4f
                });
            }
            else
            {
                graphics.FillEllipse(Brushes.SteelBlue, new RectangleF()
                {
                    X = (float)(ClientRectangle.Width - 2.0 - (ClientRectangle.Height - 4.0)),
                    Y = 2f,
                    Width = ClientRectangle.Height - 4f,
                    Height = ClientRectangle.Height - 4f
                });
            }
        }

        private void TwoSelector_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            if (m_spCurrentPosition == TwoSelector.SelectorPosition.SELECTOR_ON_LEFT)
            {
                Selector = TwoSelector.SelectorPosition.SELECTOR_ON_RIGHT;
            }
            else
            {
                Selector = TwoSelector.SelectorPosition.SELECTOR_ON_LEFT;
            }
        }

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
            BackColor = Color.Transparent;
            DoubleBuffered = true;
          //  Name = nameof(TwoSelector);
            Size = new Size(107, 28);
            MouseUp += new MouseEventHandler(TwoSelector_MouseUp);
            ResumeLayout(false);
        }

        public enum SelectorPosition
        {
            SELECTOR_ON_LEFT,
            SELECTOR_ON_RIGHT,
        }

        public delegate void SelectorChangeEventDelegate(
          TwoSelector.SelectorPosition spCurrentPosition,
          object objSelected,
          TwoSelector objSender);
    }
}
