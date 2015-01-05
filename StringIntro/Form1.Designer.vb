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
        Me.txtStrInput = New System.Windows.Forms.TextBox()
        Me.btnChars = New System.Windows.Forms.Button()
        Me.btnLength = New System.Windows.Forms.Button()
        Me.btnToUpper = New System.Windows.Forms.Button()
        Me.btnToLower = New System.Windows.Forms.Button()
        Me.btnTrim = New System.Windows.Forms.Button()
        Me.btnSubstring = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtStrInput
        '
        Me.txtStrInput.Location = New System.Drawing.Point(110, 26)
        Me.txtStrInput.Name = "txtStrInput"
        Me.txtStrInput.Size = New System.Drawing.Size(53, 20)
        Me.txtStrInput.TabIndex = 0
        '
        'btnChars
        '
        Me.btnChars.Location = New System.Drawing.Point(22, 76)
        Me.btnChars.Name = "btnChars"
        Me.btnChars.Size = New System.Drawing.Size(76, 23)
        Me.btnChars.TabIndex = 1
        Me.btnChars.Text = "Chars"
        Me.btnChars.UseVisualStyleBackColor = True
        '
        'btnLength
        '
        Me.btnLength.Location = New System.Drawing.Point(21, 117)
        Me.btnLength.Name = "btnLength"
        Me.btnLength.Size = New System.Drawing.Size(75, 23)
        Me.btnLength.TabIndex = 2
        Me.btnLength.Text = "Length"
        Me.btnLength.UseVisualStyleBackColor = True
        '
        'btnToUpper
        '
        Me.btnToUpper.Location = New System.Drawing.Point(21, 157)
        Me.btnToUpper.Name = "btnToUpper"
        Me.btnToUpper.Size = New System.Drawing.Size(75, 23)
        Me.btnToUpper.TabIndex = 3
        Me.btnToUpper.Text = "To Upper"
        Me.btnToUpper.UseVisualStyleBackColor = True
        '
        'btnToLower
        '
        Me.btnToLower.Location = New System.Drawing.Point(22, 199)
        Me.btnToLower.Name = "btnToLower"
        Me.btnToLower.Size = New System.Drawing.Size(74, 23)
        Me.btnToLower.TabIndex = 4
        Me.btnToLower.Text = "To Lower"
        Me.btnToLower.UseVisualStyleBackColor = True
        '
        'btnTrim
        '
        Me.btnTrim.Location = New System.Drawing.Point(21, 238)
        Me.btnTrim.Name = "btnTrim"
        Me.btnTrim.Size = New System.Drawing.Size(71, 23)
        Me.btnTrim.TabIndex = 5
        Me.btnTrim.Text = "Trim "
        Me.btnTrim.UseVisualStyleBackColor = True
        '
        'btnSubstring
        '
        Me.btnSubstring.Location = New System.Drawing.Point(172, 76)
        Me.btnSubstring.Name = "btnSubstring"
        Me.btnSubstring.Size = New System.Drawing.Size(75, 23)
        Me.btnSubstring.TabIndex = 6
        Me.btnSubstring.Text = "Substring"
        Me.btnSubstring.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(172, 117)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(172, 157)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 8
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(172, 199)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 9
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 295)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnSubstring)
        Me.Controls.Add(Me.btnTrim)
        Me.Controls.Add(Me.btnToLower)
        Me.Controls.Add(Me.btnToUpper)
        Me.Controls.Add(Me.btnLength)
        Me.Controls.Add(Me.btnChars)
        Me.Controls.Add(Me.txtStrInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStrInput As System.Windows.Forms.TextBox
    Friend WithEvents btnChars As System.Windows.Forms.Button
    Friend WithEvents btnLength As System.Windows.Forms.Button
    Friend WithEvents btnToUpper As System.Windows.Forms.Button
    Friend WithEvents btnToLower As System.Windows.Forms.Button
    Friend WithEvents btnTrim As System.Windows.Forms.Button
    Friend WithEvents btnSubstring As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button

End Class
