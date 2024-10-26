<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userText = New System.Windows.Forms.TextBox()
        Me.passText = New System.Windows.Forms.TextBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ユーザー名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "パスワード"
        '
        'userText
        '
        Me.userText.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.userText.Location = New System.Drawing.Point(40, 82)
        Me.userText.Name = "userText"
        Me.userText.Size = New System.Drawing.Size(350, 34)
        Me.userText.TabIndex = 2
        '
        'passText
        '
        Me.passText.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.passText.Location = New System.Drawing.Point(40, 184)
        Me.passText.Name = "passText"
        Me.passText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.passText.Size = New System.Drawing.Size(350, 34)
        Me.passText.TabIndex = 3
        '
        'loginButton
        '
        Me.loginButton.Font = New System.Drawing.Font("メイリオ", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.loginButton.Location = New System.Drawing.Point(40, 283)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(350, 63)
        Me.loginButton.TabIndex = 5
        Me.loginButton.Text = "ログイン"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 444)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.passText)
        Me.Controls.Add(Me.userText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "loginForm"
        Me.Text = "ログイン"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents userText As TextBox
    Friend WithEvents passText As TextBox
    Friend WithEvents loginButton As Button
End Class
