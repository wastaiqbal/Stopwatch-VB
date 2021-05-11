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
        Me.components = New System.ComponentModel.Container()
        Me.LbTime = New System.Windows.Forms.Label()
        Me.LsMark = New System.Windows.Forms.ListBox()
        Me.BtnMark = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerStopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LbTime
        '
        Me.LbTime.AutoSize = True
        Me.LbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTime.Location = New System.Drawing.Point(154, 100)
        Me.LbTime.Name = "LbTime"
        Me.LbTime.Size = New System.Drawing.Size(192, 36)
        Me.LbTime.TabIndex = 0
        Me.LbTime.Text = "00:00:00:000"
        '
        'LsMark
        '
        Me.LsMark.FormattingEnabled = True
        Me.LsMark.ItemHeight = 20
        Me.LsMark.Location = New System.Drawing.Point(76, 153)
        Me.LsMark.Name = "LsMark"
        Me.LsMark.Size = New System.Drawing.Size(333, 224)
        Me.LsMark.TabIndex = 1
        '
        'BtnMark
        '
        Me.BtnMark.Location = New System.Drawing.Point(189, 399)
        Me.BtnMark.Name = "BtnMark"
        Me.BtnMark.Size = New System.Drawing.Size(107, 46)
        Me.BtnMark.TabIndex = 2
        Me.BtnMark.Text = "Mark"
        Me.BtnMark.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(76, 451)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(107, 46)
        Me.BtnStart.TabIndex = 3
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Location = New System.Drawing.Point(302, 451)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(107, 46)
        Me.BtnStop.TabIndex = 4
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(189, 451)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(107, 46)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Stopwatch"
        '
        'TimerStopwatch
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 531)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.BtnMark)
        Me.Controls.Add(Me.LsMark)
        Me.Controls.Add(Me.LbTime)
        Me.Name = "Form1"
        Me.Text = "FormStopwatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbTime As System.Windows.Forms.Label
    Friend WithEvents LsMark As System.Windows.Forms.ListBox
    Friend WithEvents BtnMark As System.Windows.Forms.Button
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents BtnStop As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TimerStopwatch As System.Windows.Forms.Timer

End Class
