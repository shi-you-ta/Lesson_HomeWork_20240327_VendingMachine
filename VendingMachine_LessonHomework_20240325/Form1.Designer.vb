<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVendingMachine
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
        components = New ComponentModel.Container()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        TextBoxInput = New TextBox()
        LabelInput = New Label()
        LabelUnit1 = New Label()
        ButtonBuy = New Button()
        LabelSauce = New Label()
        TextBoxSauce = New TextBox()
        LabelUnit2 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBoxCoin1 = New TextBox()
        Label8 = New Label()
        TextBoxCoin5 = New TextBox()
        TextBoxCoin10 = New TextBox()
        TextBoxCoin50 = New TextBox()
        TextBoxCoin100 = New TextBox()
        TextBoxCoin500 = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' TextBoxInput
        ' 
        TextBoxInput.Location = New Point(91, 6)
        TextBoxInput.Name = "TextBoxInput"
        TextBoxInput.Size = New Size(126, 27)
        TextBoxInput.TabIndex = 1
        TextBoxInput.TextAlign = HorizontalAlignment.Right
        ' 
        ' LabelInput
        ' 
        LabelInput.AutoSize = True
        LabelInput.Location = New Point(12, 9)
        LabelInput.Name = "LabelInput"
        LabelInput.Size = New Size(69, 20)
        LabelInput.TabIndex = 2
        LabelInput.Text = "投入金額"
        ' 
        ' LabelUnit1
        ' 
        LabelUnit1.AutoSize = True
        LabelUnit1.Location = New Point(223, 9)
        LabelUnit1.Name = "LabelUnit1"
        LabelUnit1.Size = New Size(24, 20)
        LabelUnit1.TabIndex = 3
        LabelUnit1.Text = "円"
        ' 
        ' ButtonBuy
        ' 
        ButtonBuy.Location = New Point(12, 48)
        ButtonBuy.Name = "ButtonBuy"
        ButtonBuy.Size = New Size(235, 46)
        ButtonBuy.TabIndex = 4
        ButtonBuy.Text = "購入する"
        ButtonBuy.UseVisualStyleBackColor = True
        ' 
        ' LabelSauce
        ' 
        LabelSauce.AutoSize = True
        LabelSauce.Location = New Point(39, 114)
        LabelSauce.Name = "LabelSauce"
        LabelSauce.Size = New Size(46, 20)
        LabelSauce.TabIndex = 5
        LabelSauce.Text = "お釣り"
        ' 
        ' TextBoxSauce
        ' 
        TextBoxSauce.Location = New Point(91, 111)
        TextBoxSauce.Name = "TextBoxSauce"
        TextBoxSauce.Size = New Size(126, 27)
        TextBoxSauce.TabIndex = 1
        TextBoxSauce.TextAlign = HorizontalAlignment.Right
        ' 
        ' LabelUnit2
        ' 
        LabelUnit2.AutoSize = True
        LabelUnit2.Location = New Point(223, 114)
        LabelUnit2.Name = "LabelUnit2"
        LabelUnit2.Size = New Size(24, 20)
        LabelUnit2.TabIndex = 3
        LabelUnit2.Text = "円"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(12, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 41)
        Label1.TabIndex = 6
        Label1.Text = "＜お釣りの詳細＞"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 20)
        Label2.TabIndex = 7
        Label2.Text = "1円玉"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(28, 270)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 20)
        Label3.TabIndex = 7
        Label3.Text = "5円玉"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 320)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 20)
        Label4.TabIndex = 7
        Label4.Text = "10円玉"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 370)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 20)
        Label5.TabIndex = 7
        Label5.Text = "50円玉"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 420)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 20)
        Label6.TabIndex = 7
        Label6.Text = "100円玉"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 470)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 20)
        Label7.TabIndex = 7
        Label7.Text = "500円玉"
        ' 
        ' TextBoxCoin1
        ' 
        TextBoxCoin1.Location = New Point(105, 217)
        TextBoxCoin1.Name = "TextBoxCoin1"
        TextBoxCoin1.Size = New Size(112, 27)
        TextBoxCoin1.TabIndex = 8
        TextBoxCoin1.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(223, 220)
        Label8.Name = "Label8"
        Label8.Size = New Size(24, 20)
        Label8.TabIndex = 3
        Label8.Text = "枚"
        ' 
        ' TextBoxCoin5
        ' 
        TextBoxCoin5.Location = New Point(105, 267)
        TextBoxCoin5.Name = "TextBoxCoin5"
        TextBoxCoin5.Size = New Size(112, 27)
        TextBoxCoin5.TabIndex = 8
        TextBoxCoin5.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBoxCoin10
        ' 
        TextBoxCoin10.Location = New Point(105, 317)
        TextBoxCoin10.Name = "TextBoxCoin10"
        TextBoxCoin10.Size = New Size(112, 27)
        TextBoxCoin10.TabIndex = 8
        TextBoxCoin10.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBoxCoin50
        ' 
        TextBoxCoin50.Location = New Point(105, 367)
        TextBoxCoin50.Name = "TextBoxCoin50"
        TextBoxCoin50.Size = New Size(112, 27)
        TextBoxCoin50.TabIndex = 8
        TextBoxCoin50.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBoxCoin100
        ' 
        TextBoxCoin100.Location = New Point(105, 417)
        TextBoxCoin100.Name = "TextBoxCoin100"
        TextBoxCoin100.Size = New Size(112, 27)
        TextBoxCoin100.TabIndex = 8
        TextBoxCoin100.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBoxCoin500
        ' 
        TextBoxCoin500.Location = New Point(105, 467)
        TextBoxCoin500.Name = "TextBoxCoin500"
        TextBoxCoin500.Size = New Size(112, 27)
        TextBoxCoin500.TabIndex = 8
        TextBoxCoin500.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(223, 270)
        Label9.Name = "Label9"
        Label9.Size = New Size(24, 20)
        Label9.TabIndex = 3
        Label9.Text = "枚"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(223, 320)
        Label10.Name = "Label10"
        Label10.Size = New Size(24, 20)
        Label10.TabIndex = 3
        Label10.Text = "枚"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(223, 370)
        Label11.Name = "Label11"
        Label11.Size = New Size(24, 20)
        Label11.TabIndex = 3
        Label11.Text = "枚"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(223, 420)
        Label12.Name = "Label12"
        Label12.Size = New Size(24, 20)
        Label12.TabIndex = 3
        Label12.Text = "枚"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(223, 470)
        Label13.Name = "Label13"
        Label13.Size = New Size(24, 20)
        Label13.TabIndex = 3
        Label13.Text = "枚"
        ' 
        ' FormVendingMachine
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(272, 525)
        Controls.Add(TextBoxCoin500)
        Controls.Add(TextBoxCoin100)
        Controls.Add(TextBoxCoin50)
        Controls.Add(TextBoxCoin10)
        Controls.Add(TextBoxCoin5)
        Controls.Add(TextBoxCoin1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LabelSauce)
        Controls.Add(ButtonBuy)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(LabelUnit2)
        Controls.Add(LabelUnit1)
        Controls.Add(LabelInput)
        Controls.Add(TextBoxSauce)
        Controls.Add(TextBoxInput)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FormVendingMachine"
        Text = "自動販売機"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents LabelInput As Label
    Friend WithEvents LabelUnit1 As Label
    Friend WithEvents ButtonBuy As Button
    Friend WithEvents LabelSauce As Label
    Friend WithEvents TextBoxSauce As TextBox
    Friend WithEvents LabelUnit2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxCoin1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxCoin5 As TextBox
    Friend WithEvents TextBoxCoin10 As TextBox
    Friend WithEvents TextBoxCoin50 As TextBox
    Friend WithEvents TextBoxCoin100 As TextBox
    Friend WithEvents TextBoxCoin500 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label

End Class
