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
        Me.SaveLance = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Location = New System.Windows.Forms.TextBox()
        Me.ContractType = New System.Windows.Forms.ComboBox()
        Me.ContractName = New System.Windows.Forms.TextBox()
        Me.Terrain = New System.Windows.Forms.ComboBox()
        Me.Difficulty = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Result = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveMission = New System.Windows.Forms.Button()
        Me.SaveLog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SaveLance
        '
        Me.SaveLance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveLance.Location = New System.Drawing.Point(607, 480)
        Me.SaveLance.Name = "SaveLance"
        Me.SaveLance.Size = New System.Drawing.Size(106, 23)
        Me.SaveLance.TabIndex = 14
        Me.SaveLance.Text = "Save"
        Me.SaveLance.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(569, 360)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(177, 24)
        Me.ComboBox1.TabIndex = 10
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(569, 390)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(177, 24)
        Me.ComboBox2.TabIndex = 11
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(569, 420)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(177, 24)
        Me.ComboBox3.TabIndex = 12
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(569, 450)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(177, 24)
        Me.ComboBox4.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(603, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Mission Lance"
        '
        'Location
        '
        Me.Location.Location = New System.Drawing.Point(16, 42)
        Me.Location.Name = "Location"
        Me.Location.Size = New System.Drawing.Size(100, 20)
        Me.Location.TabIndex = 1
        Me.Location.Text = "System"
        '
        'ContractType
        '
        Me.ContractType.FormattingEnabled = True
        Me.ContractType.Location = New System.Drawing.Point(16, 94)
        Me.ContractType.Name = "ContractType"
        Me.ContractType.Size = New System.Drawing.Size(121, 21)
        Me.ContractType.TabIndex = 3
        Me.ContractType.Text = "Contract Type"
        '
        'ContractName
        '
        Me.ContractName.Location = New System.Drawing.Point(16, 68)
        Me.ContractName.Name = "ContractName"
        Me.ContractName.Size = New System.Drawing.Size(100, 20)
        Me.ContractName.TabIndex = 2
        Me.ContractName.Text = "Contract Name"
        '
        'Terrain
        '
        Me.Terrain.FormattingEnabled = True
        Me.Terrain.Location = New System.Drawing.Point(16, 121)
        Me.Terrain.Name = "Terrain"
        Me.Terrain.Size = New System.Drawing.Size(121, 21)
        Me.Terrain.TabIndex = 4
        Me.Terrain.Text = "Terrain (Biome)"
        '
        'Difficulty
        '
        Me.Difficulty.FormattingEnabled = True
        Me.Difficulty.Location = New System.Drawing.Point(16, 149)
        Me.Difficulty.Name = "Difficulty"
        Me.Difficulty.Size = New System.Drawing.Size(121, 21)
        Me.Difficulty.TabIndex = 5
        Me.Difficulty.Text = "Difficulty"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(545, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Result
        '
        Me.Result.FormattingEnabled = True
        Me.Result.Location = New System.Drawing.Point(624, 38)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(121, 21)
        Me.Result.TabIndex = 8
        Me.Result.Text = "Result"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Mission Details"
        '
        'SaveMission
        '
        Me.SaveMission.Location = New System.Drawing.Point(26, 176)
        Me.SaveMission.Name = "SaveMission"
        Me.SaveMission.Size = New System.Drawing.Size(100, 23)
        Me.SaveMission.TabIndex = 6
        Me.SaveMission.Text = "Save Mission"
        Me.SaveMission.UseVisualStyleBackColor = True
        '
        'SaveLog
        '
        Me.SaveLog.Location = New System.Drawing.Point(645, 68)
        Me.SaveLog.Name = "SaveLog"
        Me.SaveLog.Size = New System.Drawing.Size(100, 23)
        Me.SaveLog.TabIndex = 9
        Me.SaveLog.Text = "Save To Log"
        Me.SaveLog.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(757, 515)
        Me.Controls.Add(Me.SaveLog)
        Me.Controls.Add(Me.SaveMission)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Difficulty)
        Me.Controls.Add(Me.Terrain)
        Me.Controls.Add(Me.ContractName)
        Me.Controls.Add(Me.ContractType)
        Me.Controls.Add(Me.Location)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SaveLance)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Battletech"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveLance As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Location As TextBox
    Friend WithEvents ContractType As ComboBox
    Friend WithEvents ContractName As TextBox
    Friend WithEvents Terrain As ComboBox
    Friend WithEvents Difficulty As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Result As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveMission As Button
    Friend WithEvents SaveLog As Button
End Class
