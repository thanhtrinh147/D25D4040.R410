<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D99U1111
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D99U1111))
        Me.tdbgD99U1111 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.lbl1 = New System.Windows.Forms.Label
        Me.btnRefresh = New System.Windows.Forms.Button
        CType(Me.tdbgD99U1111, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tdbgD99U1111
        '
        Me.tdbgD99U1111.AllowColMove = False
        Me.tdbgD99U1111.AllowColSelect = False
        Me.tdbgD99U1111.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbgD99U1111.AllowSort = False
        Me.tdbgD99U1111.AlternatingRows = True
        Me.tdbgD99U1111.EmptyRows = True
        Me.tdbgD99U1111.ExtendRightColumn = True
        Me.tdbgD99U1111.FetchRowStyles = True
        Me.tdbgD99U1111.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard
        Me.tdbgD99U1111.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbgD99U1111.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbgD99U1111.Images.Add(CType(resources.GetObject("tdbgD99U1111.Images"), System.Drawing.Image))
        Me.tdbgD99U1111.Location = New System.Drawing.Point(3, 24)
        Me.tdbgD99U1111.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.tdbgD99U1111.Name = "tdbgD99U1111"
        Me.tdbgD99U1111.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbgD99U1111.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbgD99U1111.PreviewInfo.ZoomFactor = 75
        Me.tdbgD99U1111.PrintInfo.PageSettings = CType(resources.GetObject("tdbgD99U1111.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbgD99U1111.Size = New System.Drawing.Size(259, 334)
        Me.tdbgD99U1111.TabAcrossSplits = True
        Me.tdbgD99U1111.TabIndex = 1
        Me.tdbgD99U1111.Tag = "COL"
        Me.tdbgD99U1111.WrapCellPointer = True
        Me.tdbgD99U1111.PropBag = resources.GetString("tdbgD99U1111.PropBag")
        '
        'picClose
        '
        Me.picClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(248, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(14, 15)
        Me.picClose.TabIndex = 20
        Me.picClose.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(186, 364)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 22)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Lưu"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl1.Location = New System.Drawing.Point(0, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(266, 21)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Chọn cột hiển thị"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(104, 364)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(76, 22)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'D99U1111
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tdbgD99U1111)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "D99U1111"
        Me.Size = New System.Drawing.Size(266, 391)
        CType(Me.tdbgD99U1111, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tdbgD99U1111 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Private WithEvents picClose As System.Windows.Forms.PictureBox
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents lbl1 As System.Windows.Forms.Label
    Private WithEvents btnRefresh As System.Windows.Forms.Button

End Class
