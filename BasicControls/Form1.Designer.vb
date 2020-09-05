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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'txtFN
        '
        Me.txtFN.Location = New System.Drawing.Point(115, 25)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(250, 26)
        Me.txtFN.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Middle Name"
        '
        'txtMN
        '
        Me.txtMN.Location = New System.Drawing.Point(115, 57)
        Me.txtMN.Name = "txtMN"
        Me.txtMN.Size = New System.Drawing.Size(250, 26)
        Me.txtMN.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Last Name"
        '
        'txtLN
        '
        Me.txtLN.Location = New System.Drawing.Point(115, 89)
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(250, 26)
        Me.txtLN.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(115, 121)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(61, 26)
        Me.txtAge.TabIndex = 3
        '
        'cboSex
        '
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"Unspecified", "Male", "Female"})
        Me.cboSex.Location = New System.Drawing.Point(244, 121)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(121, 26)
        Me.cboSex.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sex"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(115, 154)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(123, 31)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(242, 154)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 31)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstResults)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 238)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Results"
        '
        'lstResults
        '
        Me.lstResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 22
        Me.lstResults.Location = New System.Drawing.Point(3, 22)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(395, 213)
        Me.lstResults.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(426, 442)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.cboSex)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFN)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basic Controls"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents cboSex As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstResults As ListBox
End Class
