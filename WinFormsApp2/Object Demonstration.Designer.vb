﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Object_Demonstration
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
        GroupBox1 = New GroupBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        GroupBox2 = New GroupBox()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton6 = New RadioButton()
        GroupBox3 = New GroupBox()
        TextBox1 = New TextBox()
        GroupBox4 = New GroupBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(575, 221)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(195, 162)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Font color"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(23, 36)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(83, 29)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Green"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(23, 71)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(70, 29)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Blue"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(23, 96)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(67, 29)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Red"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton6)
        GroupBox2.Controls.Add(RadioButton5)
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.Location = New Point(362, 23)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(408, 81)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font"
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(3, 27)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(121, 29)
        RadioButton4.TabIndex = 0
        RadioButton4.TabStop = True
        RadioButton4.Text = "Garamond"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(140, 27)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(109, 29)
        RadioButton5.TabIndex = 1
        RadioButton5.Text = "Magneto"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(255, 27)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(99, 29)
        RadioButton6.TabIndex = 2
        RadioButton6.Text = "Tahoma"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBox1)
        GroupBox3.Location = New Point(49, 23)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(227, 81)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Display Test"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(20, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(107, 31)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Sample text"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(CheckBox3)
        GroupBox4.Controls.Add(CheckBox2)
        GroupBox4.Controls.Add(CheckBox1)
        GroupBox4.Location = New Point(372, 221)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(197, 162)
        GroupBox4.TabIndex = 4
        GroupBox4.TabStop = False
        GroupBox4.Text = "Font Style"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(35, 43)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(77, 29)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Italic"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox2.Location = New Point(33, 75)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(77, 29)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Bold"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBox3.Location = New Point(36, 108)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(126, 29)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Bold Italic"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(49, 221)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(227, 162)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(80, 401)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 34)
        Button1.TabIndex = 6
        Button1.Text = "Load Image"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(541, 401)
        Button2.Name = "Button2"
        Button2.Size = New Size(162, 34)
        Button2.TabIndex = 7
        Button2.Text = "EXIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Object_Demonstration
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Object_Demonstration"
        Text = "Object_Demonstration"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
