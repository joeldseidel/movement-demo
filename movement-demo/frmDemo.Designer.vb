<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDemo))
        Me.picCharacter = New System.Windows.Forms.PictureBox()
        Me.picBottom1 = New System.Windows.Forms.PictureBox()
        Me.picTop1 = New System.Windows.Forms.PictureBox()
        Me.picTop2 = New System.Windows.Forms.PictureBox()
        Me.picBottom2 = New System.Windows.Forms.PictureBox()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBottom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTop1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTop2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBottom2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCharacter
        '
        Me.picCharacter.Image = CType(resources.GetObject("picCharacter.Image"), System.Drawing.Image)
        Me.picCharacter.Location = New System.Drawing.Point(12, 154)
        Me.picCharacter.Name = "picCharacter"
        Me.picCharacter.Size = New System.Drawing.Size(53, 48)
        Me.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCharacter.TabIndex = 0
        Me.picCharacter.TabStop = False
        '
        'picBottom1
        '
        Me.picBottom1.Image = CType(resources.GetObject("picBottom1.Image"), System.Drawing.Image)
        Me.picBottom1.Location = New System.Drawing.Point(222, 227)
        Me.picBottom1.Name = "picBottom1"
        Me.picBottom1.Size = New System.Drawing.Size(56, 154)
        Me.picBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBottom1.TabIndex = 1
        Me.picBottom1.TabStop = False
        '
        'picTop1
        '
        Me.picTop1.Image = CType(resources.GetObject("picTop1.Image"), System.Drawing.Image)
        Me.picTop1.Location = New System.Drawing.Point(222, 0)
        Me.picTop1.Name = "picTop1"
        Me.picTop1.Size = New System.Drawing.Size(63, 137)
        Me.picTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTop1.TabIndex = 2
        Me.picTop1.TabStop = False
        '
        'picTop2
        '
        Me.picTop2.Image = CType(resources.GetObject("picTop2.Image"), System.Drawing.Image)
        Me.picTop2.Location = New System.Drawing.Point(381, 0)
        Me.picTop2.Name = "picTop2"
        Me.picTop2.Size = New System.Drawing.Size(63, 184)
        Me.picTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTop2.TabIndex = 3
        Me.picTop2.TabStop = False
        '
        'picBottom2
        '
        Me.picBottom2.Image = CType(resources.GetObject("picBottom2.Image"), System.Drawing.Image)
        Me.picBottom2.Location = New System.Drawing.Point(381, 292)
        Me.picBottom2.Name = "picBottom2"
        Me.picBottom2.Size = New System.Drawing.Size(63, 89)
        Me.picBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBottom2.TabIndex = 4
        Me.picBottom2.TabStop = False
        '
        'tmrMain
        '
        Me.tmrMain.Interval = 200
        '
        'frmDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(528, 382)
        Me.Controls.Add(Me.picBottom2)
        Me.Controls.Add(Me.picTop2)
        Me.Controls.Add(Me.picTop1)
        Me.Controls.Add(Me.picBottom1)
        Me.Controls.Add(Me.picCharacter)
        Me.Name = "frmDemo"
        Me.Text = "Movement Demo"
        CType(Me.picCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBottom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTop1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTop2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBottom2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picCharacter As PictureBox
    Friend WithEvents picBottom1 As PictureBox
    Friend WithEvents picTop1 As PictureBox
    Friend WithEvents picTop2 As PictureBox
    Friend WithEvents picBottom2 As PictureBox
    Friend WithEvents tmrMain As Timer
End Class
