using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analizadorLexico
{
    class MyRenderer : ToolStripProfessionalRenderer
    {
        public MyRenderer() : base(new MyColors()) { }
    }

    class MyColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(26, 32, 44); }
        }
        public override Color MenuItemBorder
        {
            get { return Color.Transparent; }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(25, 30, 42); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(25, 30, 42); }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(25, 30, 42); }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(25, 30, 42); }
        }
        public override Color MenuBorder
        {
            get { return Color.Transparent; }
        }


        public override Color ToolStripDropDownBackground
        {
            get { return Color.FromArgb(25, 30, 42); }
        }
        public override Color ToolStripContentPanelGradientBegin
        {
            get { return Color.FromArgb(25, 30, 42); }
        }
        public override Color ToolStripGradientBegin
        {
            get { return Color.FromArgb(25, 30, 42); ; }
        }
        public override Color ToolStripGradientEnd
        {
            get { return Color.FromArgb(25, 30, 42); ; }
        }
        public override Color ToolStripGradientMiddle
        {
            get { return Color.FromArgb(25, 30, 42); ; }
        }
    }
}
