﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.finderButton = New System.Windows.Forms.Button()
        Me.unshippedJobsListBox = New System.Windows.Forms.ListBox()
        Me.jobNumberTextBox = New System.Windows.Forms.TextBox()
        Me.serialInTextBox = New System.Windows.Forms.TextBox()
        Me.serialOutTextBox = New System.Windows.Forms.TextBox()
        Me.faultTextBox = New System.Windows.Forms.TextBox()
        Me.ShipButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.siteTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.foodstuffsJobCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'finderButton
        '
        Me.finderButton.Location = New System.Drawing.Point(12, 315)
        Me.finderButton.Name = "finderButton"
        Me.finderButton.Size = New System.Drawing.Size(160, 31)
        Me.finderButton.TabIndex = 0
        Me.finderButton.Text = "Find Unshipped Jobs"
        Me.finderButton.UseVisualStyleBackColor = True
        '
        'unshippedJobsListBox
        '
        Me.unshippedJobsListBox.FormattingEnabled = True
        Me.unshippedJobsListBox.ItemHeight = 16
        Me.unshippedJobsListBox.Location = New System.Drawing.Point(20, 12)
        Me.unshippedJobsListBox.Name = "unshippedJobsListBox"
        Me.unshippedJobsListBox.Size = New System.Drawing.Size(889, 292)
        Me.unshippedJobsListBox.TabIndex = 1
        '
        'jobNumberTextBox
        '
        Me.jobNumberTextBox.Location = New System.Drawing.Point(128, 361)
        Me.jobNumberTextBox.Name = "jobNumberTextBox"
        Me.jobNumberTextBox.Size = New System.Drawing.Size(776, 22)
        Me.jobNumberTextBox.TabIndex = 2
        '
        'serialInTextBox
        '
        Me.serialInTextBox.Location = New System.Drawing.Point(128, 398)
        Me.serialInTextBox.Name = "serialInTextBox"
        Me.serialInTextBox.Size = New System.Drawing.Size(776, 22)
        Me.serialInTextBox.TabIndex = 3
        '
        'serialOutTextBox
        '
        Me.serialOutTextBox.Location = New System.Drawing.Point(128, 437)
        Me.serialOutTextBox.Name = "serialOutTextBox"
        Me.serialOutTextBox.Size = New System.Drawing.Size(776, 22)
        Me.serialOutTextBox.TabIndex = 4
        '
        'faultTextBox
        '
        Me.faultTextBox.Location = New System.Drawing.Point(128, 514)
        Me.faultTextBox.Multiline = True
        Me.faultTextBox.Name = "faultTextBox"
        Me.faultTextBox.Size = New System.Drawing.Size(776, 212)
        Me.faultTextBox.TabIndex = 5
        '
        'ShipButton
        '
        Me.ShipButton.Location = New System.Drawing.Point(189, 315)
        Me.ShipButton.Name = "ShipButton"
        Me.ShipButton.Size = New System.Drawing.Size(85, 31)
        Me.ShipButton.TabIndex = 6
        Me.ShipButton.Text = "Ship"
        Me.ShipButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "JOB NUMBER:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "SERIAL IN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 437)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "SERIAL OUT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 517)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "FAULT:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 475)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "SITE:"
        '
        'siteTextBox
        '
        Me.siteTextBox.Location = New System.Drawing.Point(128, 475)
        Me.siteTextBox.Name = "siteTextBox"
        Me.siteTextBox.Size = New System.Drawing.Size(776, 22)
        Me.siteTextBox.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(294, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "FOODSTUFFS JOB:"
        '
        'foodstuffsJobCheckBox
        '
        Me.foodstuffsJobCheckBox.AutoSize = True
        Me.foodstuffsJobCheckBox.Location = New System.Drawing.Point(452, 322)
        Me.foodstuffsJobCheckBox.Name = "foodstuffsJobCheckBox"
        Me.foodstuffsJobCheckBox.Size = New System.Drawing.Size(18, 17)
        Me.foodstuffsJobCheckBox.TabIndex = 14
        Me.foodstuffsJobCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(913, 738)
        Me.Controls.Add(Me.foodstuffsJobCheckBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.siteTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShipButton)
        Me.Controls.Add(Me.faultTextBox)
        Me.Controls.Add(Me.serialOutTextBox)
        Me.Controls.Add(Me.serialInTextBox)
        Me.Controls.Add(Me.jobNumberTextBox)
        Me.Controls.Add(Me.unshippedJobsListBox)
        Me.Controls.Add(Me.finderButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents finderButton As Button
    Friend WithEvents unshippedJobsListBox As ListBox
    Friend WithEvents jobNumberTextBox As TextBox
    Friend WithEvents serialInTextBox As TextBox
    Friend WithEvents serialOutTextBox As TextBox
    Friend WithEvents faultTextBox As TextBox
    Friend WithEvents ShipButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents siteTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents foodstuffsJobCheckBox As CheckBox
End Class
