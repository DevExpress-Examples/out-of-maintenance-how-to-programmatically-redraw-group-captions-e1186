using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraLayout.Registrator;
using DevExpress.XtraLayout;
using DevExpress.LookAndFeel;
using DevExpress.XtraLayout.Painting;
using DevExpress.XtraLayout.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.Skins;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
    }
    
    public class MySkinGroupObjectPainter : SkinGroupObjectPainter
    {
        public MySkinGroupObjectPainter(IPanelControlOwner owner, ISkinProvider provider) : base(owner, provider)   {}
        protected override void DrawCaption(GroupObjectInfoArgs info) {
			if(info.CaptionBounds.IsEmpty) return;
            info.Cache.FillRectangle(info.Cache.GetSolidBrush(Color.Aqua), info.CaptionBounds);
			DrawButton(info);
			DrawVString(info.Cache, info.AppearanceCaption, info.Caption, info.TextBounds, GetRotateAngle(info));
		}

    }

        public class MyLayoutControlImplementor : LayoutControlImplementor {
            public MyLayoutControlImplementor(ILayoutControlOwner owner) : base(owner) { }
            protected override void InitializePaintStyles() {
            ISupportLookAndFeel lookAndFeelOwner = owner.GetISupportLookAndFeel();
            if (lookAndFeelOwner != null) {
                PaintStyles.Add(new LayoutOffice2003PaintStyle(lookAndFeelOwner));
                PaintStyles.Add(new LayoutWindowsXPPaintStyle(lookAndFeelOwner));
                //
                // TODO: Add your owner PaintStyle instead of PaintStyles.Add(new LayoutSkinPaintStyle(lookAndFeelOwner));
                //
                PaintStyles.Add(new MyLayoutSkinPaintStyle(lookAndFeelOwner));

                PaintStyles.Add(new Style3DPaintStyle(lookAndFeelOwner));
                PaintStyles.Add(new UltraFlatPaintStyle(lookAndFeelOwner));
                PaintStyles.Add(new FlatPaintStyle(lookAndFeelOwner));
            }
            lookAndFeelOwner = null;
        }
    }
    public class MyLayoutSkinPaintStyle : LayoutSkinPaintStyle {
        public MyLayoutSkinPaintStyle(ISupportLookAndFeel lookAndFeelOwner) : base(lookAndFeelOwner) { }

        public override GroupObjectPainter CreateGroupPainter(IPanelControlOwner owner)
        {
            return new MySkinGroupObjectPainter(owner, LookAndFeel);
        }


    }
    public class MyLayoutControl : LayoutControl {
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore() {
            return new MyLayoutControlImplementor(this);
        }
    }
}