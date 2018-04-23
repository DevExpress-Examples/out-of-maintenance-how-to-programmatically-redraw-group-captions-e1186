Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.myLayoutControl1 = New MyLayoutControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			CType(Me.myLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myLayoutControl1.SuspendLayout()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myLayoutControl1
			' 
			Me.myLayoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText
			Me.myLayoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = True
			Me.myLayoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText
			Me.myLayoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = True
			Me.myLayoutControl1.Controls.Add(Me.labelControl1)
			Me.myLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myLayoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.myLayoutControl1.Name = "myLayoutControl1"
			Me.myLayoutControl1.Root = Me.layoutControlGroup1
			Me.myLayoutControl1.Size = New System.Drawing.Size(292, 273)
			Me.myLayoutControl1.TabIndex = 0
			Me.myLayoutControl1.Text = "myLayoutControl1"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(10, 28)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(63, 13)
			Me.labelControl1.StyleController = Me.myLayoutControl1
			Me.labelControl1.TabIndex = 4
			Me.labelControl1.Text = "labelControl1"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(292, 273)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.AppearanceItemCaption.BackColor = System.Drawing.Color.Red
			Me.layoutControlItem1.AppearanceItemCaption.Options.UseBackColor = True
			Me.layoutControlItem1.Control = Me.labelControl1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(284, 247)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.AppearanceGroup.BackColor = System.Drawing.Color.Red
			Me.layoutControlGroup2.AppearanceGroup.Options.UseBackColor = True
			Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(290, 271)
			Me.layoutControlGroup2.Text = "layoutControlGroup2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 273)
			Me.Controls.Add(Me.myLayoutControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myLayoutControl1.ResumeLayout(False)
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myLayoutControl1 As MyLayoutControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup


	End Class
End Namespace

