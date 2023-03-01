<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBtnCon = New System.Windows.Forms.RadioButton()
        Me.RBtnConAuto = New System.Windows.Forms.RadioButton()
        Me.RBtnConSup = New System.Windows.Forms.RadioButton()
        Me.LblReg = New System.Windows.Forms.Label()
        Me.LblGSize = New System.Windows.Forms.Label()
        Me.TxtGroup = New System.Windows.Forms.TextBox()
        Me.LblRegi = New System.Windows.Forms.Label()
        Me.LblRegTotal = New System.Windows.Forms.Label()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.RBtnCon)
        Me.GroupBox1.Controls.Add(Me.RBtnConAuto)
        Me.GroupBox1.Controls.Add(Me.RBtnConSup)
        Me.GroupBox1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(128, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Badge Type:"
        '
        'RBtnCon
        '
        Me.RBtnCon.AutoSize = True
        Me.RBtnCon.Location = New System.Drawing.Point(19, 122)
        Me.RBtnCon.Name = "RBtnCon"
        Me.RBtnCon.Size = New System.Drawing.Size(133, 22)
        Me.RBtnCon.TabIndex = 2
        Me.RBtnCon.TabStop = True
        Me.RBtnCon.Text = "Convention"
        Me.RBtnCon.UseVisualStyleBackColor = True
        '
        'RBtnConAuto
        '
        Me.RBtnConAuto.AutoSize = True
        Me.RBtnConAuto.Location = New System.Drawing.Point(19, 82)
        Me.RBtnConAuto.Name = "RBtnConAuto"
        Me.RBtnConAuto.Size = New System.Drawing.Size(259, 22)
        Me.RBtnConAuto.TabIndex = 1
        Me.RBtnConAuto.TabStop = True
        Me.RBtnConAuto.Text = "Convention + Autographs"
        Me.RBtnConAuto.UseVisualStyleBackColor = True
        '
        'RBtnConSup
        '
        Me.RBtnConSup.AutoSize = True
        Me.RBtnConSup.Location = New System.Drawing.Point(19, 39)
        Me.RBtnConSup.Name = "RBtnConSup"
        Me.RBtnConSup.Size = New System.Drawing.Size(354, 22)
        Me.RBtnConSup.TabIndex = 0
        Me.RBtnConSup.TabStop = True
        Me.RBtnConSup.Text = "Convention + Superhero Experience"
        Me.RBtnConSup.UseVisualStyleBackColor = True
        '
        'LblReg
        '
        Me.LblReg.AutoSize = True
        Me.LblReg.BackColor = System.Drawing.Color.White
        Me.LblReg.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReg.ForeColor = System.Drawing.Color.Red
        Me.LblReg.Location = New System.Drawing.Point(104, 151)
        Me.LblReg.Name = "LblReg"
        Me.LblReg.Size = New System.Drawing.Size(440, 30)
        Me.LblReg.TabIndex = 1
        Me.LblReg.Text = "Comic Convention Registration"
        '
        'LblGSize
        '
        Me.LblGSize.AutoSize = True
        Me.LblGSize.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGSize.ForeColor = System.Drawing.Color.Red
        Me.LblGSize.Location = New System.Drawing.Point(197, 206)
        Me.LblGSize.Name = "LblGSize"
        Me.LblGSize.Size = New System.Drawing.Size(128, 21)
        Me.LblGSize.TabIndex = 2
        Me.LblGSize.Text = "Group Size: "
        '
        'TxtGroup
        '
        Me.TxtGroup.Font = New System.Drawing.Font("Showcard Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGroup.ForeColor = System.Drawing.Color.Red
        Me.TxtGroup.Location = New System.Drawing.Point(352, 208)
        Me.TxtGroup.Name = "TxtGroup"
        Me.TxtGroup.Size = New System.Drawing.Size(100, 24)
        Me.TxtGroup.TabIndex = 3
        Me.TxtGroup.Text = "0"
        Me.TxtGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblRegi
        '
        Me.LblRegi.AutoSize = True
        Me.LblRegi.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegi.ForeColor = System.Drawing.Color.Red
        Me.LblRegi.Location = New System.Drawing.Point(143, 447)
        Me.LblRegi.Name = "LblRegi"
        Me.LblRegi.Size = New System.Drawing.Size(201, 21)
        Me.LblRegi.TabIndex = 4
        Me.LblRegi.Text = "Registration Cost: "
        '
        'LblRegTotal
        '
        Me.LblRegTotal.AutoSize = True
        Me.LblRegTotal.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegTotal.ForeColor = System.Drawing.Color.Red
        Me.LblRegTotal.Location = New System.Drawing.Point(408, 447)
        Me.LblRegTotal.Name = "LblRegTotal"
        Me.LblRegTotal.Size = New System.Drawing.Size(20, 21)
        Me.LblRegTotal.TabIndex = 5
        Me.LblRegTotal.Text = "0"
        '
        'BtnCalculate
        '
        Me.BtnCalculate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnCalculate.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.ForeColor = System.Drawing.Color.Black
        Me.BtnCalculate.Location = New System.Drawing.Point(147, 511)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(124, 49)
        Me.BtnCalculate.TabIndex = 6
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClear.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Black
        Me.BtnClear.Location = New System.Drawing.Point(367, 511)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(115, 49)
        Me.BtnClear.TabIndex = 7
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(733, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnClear
        Me.ClientSize = New System.Drawing.Size(722, 606)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.LblRegTotal)
        Me.Controls.Add(Me.LblRegi)
        Me.Controls.Add(Me.TxtGroup)
        Me.Controls.Add(Me.LblGSize)
        Me.Controls.Add(Me.LblReg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Comic Convention Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBtnCon As RadioButton
    Friend WithEvents RBtnConAuto As RadioButton
    Friend WithEvents RBtnConSup As RadioButton
    Friend WithEvents LblReg As Label
    Friend WithEvents LblGSize As Label
    Friend WithEvents TxtGroup As TextBox
    Friend WithEvents LblRegi As Label
    Friend WithEvents LblRegTotal As Label
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
