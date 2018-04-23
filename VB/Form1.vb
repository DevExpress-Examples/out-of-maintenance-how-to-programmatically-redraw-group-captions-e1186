Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports DevExpress.XtraLayout.Registrator
Imports DevExpress.XtraLayout
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraLayout.Painting
Imports DevExpress.XtraLayout.ViewInfo
Imports DevExpress.Utils.Drawing
Imports DevExpress.Skins

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class MySkinGroupObjectPainter
		Inherits SkinGroupObjectPainter
		Public Sub New(ByVal owner As IPanelControlOwner, ByVal provider As ISkinProvider)
			MyBase.New(owner, provider)
		End Sub
		Protected Overrides Overloads Sub DrawCaption(ByVal info As GroupObjectInfoArgs)
			If info.CaptionBounds.IsEmpty Then
				Return
			End If
			info.Cache.FillRectangle(info.Cache.GetSolidBrush(Color.Aqua), info.CaptionBounds)
			DrawButton(info)
			DrawVString(info.Cache, info.AppearanceCaption, info.Caption, info.TextBounds, GetRotateAngle(info))
		End Sub

	End Class

		Public Class MyLayoutControlImplementor
			Inherits LayoutControlImplementor
			Public Sub New(ByVal owner As ILayoutControlOwner)
				MyBase.New(owner)
			End Sub
			Protected Overrides Sub InitializePaintStyles()
			Dim lookAndFeelOwner As ISupportLookAndFeel = owner.GetISupportLookAndFeel()
			If lookAndFeelOwner IsNot Nothing Then
				PaintStyles.Add(New LayoutOffice2003PaintStyle(lookAndFeelOwner))
				PaintStyles.Add(New LayoutWindowsXPPaintStyle(lookAndFeelOwner))
				'
				' TODO: Add your owner PaintStyle instead of PaintStyles.Add(new LayoutSkinPaintStyle(lookAndFeelOwner));
				'
				PaintStyles.Add(New MyLayoutSkinPaintStyle(lookAndFeelOwner))

				PaintStyles.Add(New Style3DPaintStyle(lookAndFeelOwner))
				PaintStyles.Add(New UltraFlatPaintStyle(lookAndFeelOwner))
				PaintStyles.Add(New FlatPaintStyle(lookAndFeelOwner))
			End If
			lookAndFeelOwner = Nothing
			End Sub
		End Class
	Public Class MyLayoutSkinPaintStyle
		Inherits LayoutSkinPaintStyle
		Public Sub New(ByVal lookAndFeelOwner As ISupportLookAndFeel)
			MyBase.New(lookAndFeelOwner)
		End Sub

		Public Overrides Function CreateGroupPainter(ByVal owner As IPanelControlOwner) As GroupObjectPainter
			Return New MySkinGroupObjectPainter(owner, LookAndFeel)
		End Function


	End Class
	Public Class MyLayoutControl
		Inherits LayoutControl
		Protected Overrides Function CreateILayoutControlImplementorCore() As LayoutControlImplementor
			Return New MyLayoutControlImplementor(Me)
		End Function
	End Class
End Namespace