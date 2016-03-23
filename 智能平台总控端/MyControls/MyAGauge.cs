using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGaugeApp;

namespace 智能平台总控端.MyControls
{
    [Serializable]
    class MyAGauge
    {
        public string Name { get; set; }
        public bool ForeColor { get; set; }
        public Color BackColor { get; set; }
        public string Text { get; set; }
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Font Font { get; set; }
        public Color BaseArcColor { get; set; }
        public int BaseArcRadius { get; set; }
        public int BaseArcStart { get; set; }
        public int BaseArcSweep { get; set; }
        public int BaseArcWidth { get; set; }
        public Color[] CapColors { get; set; }
        public string CapText { get; set; }
        public Point Center { get; set; }
        public float MaxValue { get; set; }
        public float MinValue { get; set; }
        public AGauge.NeedleColorEnum NeedleColor1 { get; set; }
        public Color NeedleColor2 { get; set; }
        public int NeedleRadius { get; set; }
        public int NeedleType { get; set; }
        public int NeedleWidth { get; set; }
        public byte Range_Idx { get; set; }
        public Color RangeColor { get; set; }
        public bool RangeEnabled { get; set; }
        public float RangeEndValue { get; set; }
        public int RangeInnerRadius { get; set; }
        public float[] RangesStartValue { get; set; }
        public float RangeStartValue { get; set; }
        public Color ScaleLinesInterColor { get; set; }
        public int ScaleLinesInterInnerRadius { get; set; }
        public int ScaleLinesInterOuterRadius { get; set; }
        public int ScaleLinesInterWidth { get; set; }
        public Color ScaleLinesMajorColor { get; set; }
        public int ScaleLinesMajorInnerRadius { get; set; }
        public int ScaleLinesMajorOuterRadius { get; set; }
        public float ScaleLinesMajorStepValue { get; set; }
        public int ScaleLinesMajorWidth { get; set; }
        public Color ScaleLinesMinorColor { get; set; }
        public int ScaleLinesMinorInnerRadius { get; set; }
        public int ScaleLinesMinorNumOf { get; set; }
        public int ScaleLinesMinorOuterRadius { get; set; }
        public int ScaleLinesMinorWidth { get; set; }
        public Color ScaleNumbersColor { get; set; }
        public string ScaleNumbersFormat { get; set; }
        public int ScaleNumbersRadius { get; set; }
        public int ScaleNumbersRotation { get; set; }
        public int ScaleNumbersStartScaleLine { get; set; }
        public int ScaleNumbersStepScaleLines { get; set; }
        public float Value { get; set; }

        public AGauge Control
        {
            get
            {
                AGauge lb = new AGauge();
                lb.Name = Name;
                lb.ForeColor = ForeColor;
                lb.BackColor = BackColor;
                lb.Text = Text;
                lb.Location = Location;
                lb.Size = Size;
                lb.Font = Font;
                lb.BaseArcColor = BaseArcColor;
                lb.BaseArcRadius = BaseArcRadius;
                lb.BaseArcStart = BaseArcStart;
                lb.BaseArcSweep = BaseArcSweep;
                lb.CapColors = CapColors;
                lb.CapText = CapText;
                lb.Center = Center;
                lb.MaxValue = MaxValue;
                lb.MinValue = MinValue;
                lb.NeedleColor1 = NeedleColor1;
                lb.NeedleColor2 = NeedleColor2;
                lb.NeedleRadius = NeedleRadius;
                lb.NeedleType = NeedleType;
                lb.NeedleWidth = NeedleWidth;
                lb.Value = Value;
                lb.Range_Idx = Range_Idx;
                lb.RangeColor = RangeColor;
                lb.RangeEnabled = RangeEnabled;
                lb.RangeEndValue = RangeEndValue;
                lb.RangeInnerRadius = RangeInnerRadius;
                lb.RangesStartValue = RangesStartValue;
                lb.ScaleLinesInterColor = ScaleLinesInterColor;
                lb.ScaleLinesInterInnerRadius = ScaleLinesInterInnerRadius;
                lb.ScaleLinesInterOuterRadius = ScaleLinesInterOuterRadius;
                lb.ScaleLinesInterWidth = ScaleLinesInterWidth;
                lb.ScaleLinesMajorColor = ScaleLinesMajorColor;
                lb.ScaleLinesMajorInnerRadius = ScaleLinesInterInnerRadius;
                lb.ScaleLinesMajorOuterRadius = ScaleLinesInterOuterRadius;
                lb.ScaleLinesMajorStepValue = ScaleLinesMajorStepValue;
                lb.ScaleLinesMajorWidth = ScaleLinesMajorWidth;
                lb.ScaleLinesMinorColor = ScaleLinesMinorColor;
                lb.ScaleLinesMinorInnerRadius = ScaleLinesMinorInnerRadius;
                lb.ScaleLinesMinorNumOf = ScaleLinesMinorNumOf;
                lb.ScaleLinesMinorOuterRadius = ScaleLinesMinorOuterRadius;
                lb.ScaleLinesMinorWidth = ScaleLinesMinorWidth;
                lb.ScaleNumbersColor = ScaleNumbersColor;
                lb.ScaleNumbersFormat = ScaleNumbersFormat;
                lb.ScaleNumbersRadius = ScaleNumbersRadius;
                lb.ScaleNumbersRotation = ScaleNumbersRotation;
                lb.ScaleNumbersStartScaleLine = ScaleNumbersStartScaleLine;
                lb.ScaleNumbersStepScaleLines = ScaleNumbersStepScaleLines;
               // lb.BaseArcWidth = BaseArcWidth;
                return lb;
            }
            set
            {
                Name = value.Name;
                ForeColor = value.ForeColor;
                BackColor = value.BackColor;
                Text = value.Text;
                Location = value.Location;
                Size = value.Size;
                Font = value.Font;
                BaseArcColor = value.BaseArcColor;
                BaseArcRadius = value.BaseArcRadius;
                BaseArcStart = value.BaseArcStart;
                BaseArcSweep = value.BaseArcSweep;
                BaseArcWidth = value.BaseArcSweep;
                CapColors = value.CapColors;
                CapText = value.CapText;
                Center = value.Center;
                MaxValue = value.MaxValue;
                MinValue = value.MinValue;
                NeedleColor1 = value.NeedleColor1;
                NeedleColor2 = value.NeedleColor2;
                NeedleRadius = value.NeedleRadius;
                NeedleType = value.NeedleType;
                NeedleWidth = value.NeedleWidth;
                Value = value.Value;
                Range_Idx = value.Range_Idx;
                RangeColor = value.RangeColor;
                RangeEnabled = value.RangeEnabled;
                RangeEndValue = value.RangeEndValue;
                RangeInnerRadius = value.RangeInnerRadius;
                RangesStartValue = value.RangesStartValue;
                ScaleLinesInterColor = value.ScaleLinesInterColor;
                ScaleLinesInterInnerRadius = value.ScaleLinesInterInnerRadius;
                ScaleLinesInterOuterRadius = value.ScaleLinesInterOuterRadius;
                ScaleLinesInterWidth = value.ScaleLinesInterWidth;
                ScaleLinesMajorColor = value.ScaleLinesMajorColor;
                ScaleLinesMajorInnerRadius = value.ScaleLinesInterInnerRadius;
                ScaleLinesMajorOuterRadius = value.ScaleLinesInterOuterRadius;
                ScaleLinesMajorStepValue = value.ScaleLinesMajorStepValue;
                ScaleLinesMajorWidth = value.ScaleLinesMajorWidth;
                ScaleLinesMinorColor = value.ScaleLinesMinorColor;
                ScaleLinesMinorInnerRadius = value.ScaleLinesMinorInnerRadius;
                ScaleLinesMinorNumOf = value.ScaleLinesMinorNumOf;
                ScaleLinesMinorOuterRadius = value.ScaleLinesMinorOuterRadius;
                ScaleLinesMinorWidth = value.ScaleLinesMinorWidth;
                ScaleNumbersColor = value.ScaleNumbersColor;
                ScaleNumbersFormat = value.ScaleNumbersFormat;
                ScaleNumbersRadius = value.ScaleNumbersRadius;
                ScaleNumbersRotation = value.ScaleNumbersRotation;
                ScaleNumbersStartScaleLine = value.ScaleNumbersStartScaleLine;
                ScaleNumbersStepScaleLines = value.ScaleNumbersStepScaleLines;
            }
        }
    }
}
