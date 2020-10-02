<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblLFeet = New System.Windows.Forms.Label()
        Me.lblWFeet = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.lblFCost = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lblTCost = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLFeet
        '
        Me.lblLFeet.AutoSize = True
        Me.lblLFeet.Location = New System.Drawing.Point(150, 37)
        Me.lblLFeet.Name = "lblLFeet"
        Me.lblLFeet.Size = New System.Drawing.Size(70, 13)
        Me.lblLFeet.TabIndex = 0
        Me.lblLFeet.Text = "Length (feet):"
        '
        'lblWFeet
        '
        Me.lblWFeet.AutoSize = True
        Me.lblWFeet.Location = New System.Drawing.Point(239, 37)
        Me.lblWFeet.Name = "lblWFeet"
        Me.lblWFeet.Size = New System.Drawing.Size(65, 13)
        Me.lblWFeet.TabIndex = 2
        Me.lblWFeet.Text = "Width (feet):"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(153, 53)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(40, 20)
        Me.txtLength.TabIndex = 1
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(242, 53)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(40, 20)
        Me.txtWidth.TabIndex = 3
        '
        'lblFCost
        '
        Me.lblFCost.AutoSize = True
        Me.lblFCost.Location = New System.Drawing.Point(330, 37)
        Me.lblFCost.Name = "lblFCost"
        Me.lblFCost.Size = New System.Drawing.Size(104, 13)
        Me.lblFCost.TabIndex = 4
        Me.lblFCost.Text = "Cost (per linear foot):"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(334, 53)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(40, 20)
        Me.txtCost.TabIndex = 5
        '
        'lblTCost
        '
        Me.lblTCost.AutoSize = True
        Me.lblTCost.Location = New System.Drawing.Point(150, 102)
        Me.lblTCost.Name = "lblTCost"
        Me.lblTCost.Size = New System.Drawing.Size(57, 13)
        Me.lblTCost.TabIndex = 6
        Me.lblTCost.Text = "Total cost:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(242, 118)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(114, 23)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calculate Total Cost"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(362, 118)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(39, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prjFenceProject_Mabasa.My.Resources.Resources._50_500558_free_painting_a_fence_paint_clipart
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCost.Location = New System.Drawing.Point(153, 118)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(67, 23)
        Me.lblTotalCost.TabIndex = 7
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 176)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTCost)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblFCost)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblWFeet)
        Me.Controls.Add(Me.lblLFeet)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                           All-Around Fence Company"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLFeet As Label
    Friend WithEvents lblWFeet As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents lblFCost As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents lblTCost As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTotalCost As Label
End Class
