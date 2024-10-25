<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class itemForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.CategoryDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryDataSet = New MyHouseHoldBudgetBook.CategoryDataSet()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.mtxtMoney = New System.Windows.Forms.MaskedTextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonOK = New System.Windows.Forms.Button()
        CType(Me.CategoryDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar
        '
        Me.MonthCalendar.Location = New System.Drawing.Point(18, 18)
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(366, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "分類"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(366, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "品名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(366, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "金額"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(366, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 30)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "備考"
        '
        'cmbCategory
        '
        Me.cmbCategory.DataSource = Me.CategoryDataTableBindingSource
        Me.cmbCategory.DisplayMember = "分類"
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(456, 21)
        Me.cmbCategory.MinimumSize = New System.Drawing.Size(210, 0)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(210, 26)
        Me.cmbCategory.TabIndex = 5
        '
        'CategoryDataTableBindingSource
        '
        Me.CategoryDataTableBindingSource.DataMember = "CategoryDataTable"
        Me.CategoryDataTableBindingSource.DataSource = Me.CategoryDataSet
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(456, 81)
        Me.txtItem.MinimumSize = New System.Drawing.Size(210, 25)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(210, 25)
        Me.txtItem.TabIndex = 6
        '
        'mtxtMoney
        '
        Me.mtxtMoney.Location = New System.Drawing.Point(456, 133)
        Me.mtxtMoney.Mask = "999999"
        Me.mtxtMoney.MinimumSize = New System.Drawing.Size(210, 25)
        Me.mtxtMoney.Name = "mtxtMoney"
        Me.mtxtMoney.Size = New System.Drawing.Size(210, 25)
        Me.mtxtMoney.TabIndex = 7
        Me.mtxtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(456, 202)
        Me.txtRemarks.MinimumSize = New System.Drawing.Size(210, 25)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(210, 25)
        Me.txtRemarks.TabIndex = 8
        '
        'buttonCancel
        '
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Location = New System.Drawing.Point(436, 361)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(144, 36)
        Me.buttonCancel.TabIndex = 9
        Me.buttonCancel.Text = "キャンセル"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'buttonOK
        '
        Me.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.buttonOK.Location = New System.Drawing.Point(128, 361)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(144, 36)
        Me.buttonOK.TabIndex = 10
        Me.buttonOK.Text = "登録"
        Me.buttonOK.UseVisualStyleBackColor = True
        '
        'itemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 444)
        Me.Controls.Add(Me.buttonOK)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.mtxtMoney)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthCalendar)
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "itemForm"
        Me.Text = "登録"
        CType(Me.CategoryDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents buttonCancel As Button
    Friend WithEvents buttonOK As Button
    Public WithEvents MonthCalendar As MonthCalendar
    Public WithEvents cmbCategory As ComboBox
    Public WithEvents txtItem As TextBox
    Public WithEvents mtxtMoney As MaskedTextBox
    Public WithEvents txtRemarks As TextBox
    Friend WithEvents CategoryDataSet As CategoryDataSet
    Friend WithEvents CategoryDataTableBindingSource As BindingSource
End Class
