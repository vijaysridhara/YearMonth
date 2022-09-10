<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YearMonth
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YearMonth))
        Me.butRight = New System.Windows.Forms.Button()
        Me.butLeft = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.ctxMonth = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.JanuaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FebruaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AprilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JuneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JulyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AugustToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeptemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OctoberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstpJan = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstpFeb = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxMonth.SuspendLayout()
        Me.SuspendLayout()
        '
        'butRight
        '
        Me.butRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.butRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRight.Image = CType(resources.GetObject("butRight.Image"), System.Drawing.Image)
        Me.butRight.Location = New System.Drawing.Point(163, 0)
        Me.butRight.Name = "butRight"
        Me.butRight.Size = New System.Drawing.Size(18, 21)
        Me.butRight.TabIndex = 2
        Me.butRight.UseVisualStyleBackColor = True
        '
        'butLeft
        '
        Me.butLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.butLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butLeft.Image = CType(resources.GetObject("butLeft.Image"), System.Drawing.Image)
        Me.butLeft.Location = New System.Drawing.Point(0, 0)
        Me.butLeft.Name = "butLeft"
        Me.butLeft.Size = New System.Drawing.Size(19, 21)
        Me.butLeft.TabIndex = 0
        Me.butLeft.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtYear.ContextMenuStrip = Me.ctxMonth
        Me.txtYear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtYear.Location = New System.Drawing.Point(19, 0)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(144, 20)
        Me.txtYear.TabIndex = 0
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ctxMonth
        '
        Me.ctxMonth.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JanuaryToolStripMenuItem, Me.FebruaryToolStripMenuItem, Me.MarchToolStripMenuItem, Me.AprilToolStripMenuItem, Me.MayToolStripMenuItem, Me.JuneToolStripMenuItem, Me.JulyToolStripMenuItem, Me.AugustToolStripMenuItem, Me.SeptemberToolStripMenuItem, Me.OctoberToolStripMenuItem, Me.NovemberToolStripMenuItem, Me.DecemberToolStripMenuItem})
        Me.ctxMonth.Name = "ctxMonth"
        Me.ctxMonth.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ctxMonth.ShowImageMargin = False
        Me.ctxMonth.Size = New System.Drawing.Size(102, 268)
        '
        'JanuaryToolStripMenuItem
        '
        Me.JanuaryToolStripMenuItem.Name = "JanuaryToolStripMenuItem"
        Me.JanuaryToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.JanuaryToolStripMenuItem.Text = "January"
        '
        'FebruaryToolStripMenuItem
        '
        Me.FebruaryToolStripMenuItem.Name = "FebruaryToolStripMenuItem"
        Me.FebruaryToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.FebruaryToolStripMenuItem.Text = "February"
        '
        'MarchToolStripMenuItem
        '
        Me.MarchToolStripMenuItem.Name = "MarchToolStripMenuItem"
        Me.MarchToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.MarchToolStripMenuItem.Text = "March"
        '
        'AprilToolStripMenuItem
        '
        Me.AprilToolStripMenuItem.Name = "AprilToolStripMenuItem"
        Me.AprilToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.AprilToolStripMenuItem.Text = "April"
        '
        'MayToolStripMenuItem
        '
        Me.MayToolStripMenuItem.Name = "MayToolStripMenuItem"
        Me.MayToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.MayToolStripMenuItem.Text = "May"
        '
        'JuneToolStripMenuItem
        '
        Me.JuneToolStripMenuItem.Name = "JuneToolStripMenuItem"
        Me.JuneToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.JuneToolStripMenuItem.Text = "June"
        '
        'JulyToolStripMenuItem
        '
        Me.JulyToolStripMenuItem.Name = "JulyToolStripMenuItem"
        Me.JulyToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.JulyToolStripMenuItem.Text = "July"
        '
        'AugustToolStripMenuItem
        '
        Me.AugustToolStripMenuItem.Name = "AugustToolStripMenuItem"
        Me.AugustToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.AugustToolStripMenuItem.Text = "August"
        '
        'SeptemberToolStripMenuItem
        '
        Me.SeptemberToolStripMenuItem.Name = "SeptemberToolStripMenuItem"
        Me.SeptemberToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.SeptemberToolStripMenuItem.Text = "September"
        '
        'OctoberToolStripMenuItem
        '
        Me.OctoberToolStripMenuItem.Name = "OctoberToolStripMenuItem"
        Me.OctoberToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.OctoberToolStripMenuItem.Text = "October"
        '
        'NovemberToolStripMenuItem
        '
        Me.NovemberToolStripMenuItem.Name = "NovemberToolStripMenuItem"
        Me.NovemberToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.NovemberToolStripMenuItem.Text = "November"
        '
        'DecemberToolStripMenuItem
        '
        Me.DecemberToolStripMenuItem.Name = "DecemberToolStripMenuItem"
        Me.DecemberToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.DecemberToolStripMenuItem.Text = "December"
        '
        'tlstpJan
        '
        Me.tlstpJan.Name = "tlstpJan"
        Me.tlstpJan.Size = New System.Drawing.Size(113, 22)
        Me.tlstpJan.Text = "January"
        '
        'tlstpFeb
        '
        Me.tlstpFeb.Name = "tlstpFeb"
        Me.tlstpFeb.Size = New System.Drawing.Size(126, 22)
        Me.tlstpFeb.Text = "February"
        '
        'YearMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.butRight)
        Me.Controls.Add(Me.butLeft)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "YearMonth"
        Me.Size = New System.Drawing.Size(181, 21)
        Me.ctxMonth.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butLeft As System.Windows.Forms.Button
    Friend WithEvents butRight As System.Windows.Forms.Button
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents ctxMonth As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tlstpJan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlstpFeb As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FebruaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AprilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JuneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JulyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AugustToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeptemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OctoberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JanuaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
