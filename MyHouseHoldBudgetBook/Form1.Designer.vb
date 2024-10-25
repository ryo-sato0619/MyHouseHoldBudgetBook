<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.編集EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.追加ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.変更CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.削除DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.表示VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.一覧表示LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.集計表示SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.バージョン情報VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.日付DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.分類DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.品名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.金額DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.備考DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoneyDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoneyDataSet = New MyHouseHoldBudgetBook.MoneyDataSet()
        Me.buttonAdd = New System.Windows.Forms.Button()
        Me.buttonChange = New System.Windows.Forms.Button()
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.buttonEnd = New System.Windows.Forms.Button()
        Me.CategoryDataSet1 = New MyHouseHoldBudgetBook.CategoryDataSet()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabList = New System.Windows.Forms.TabPage()
        Me.SummaryDataSet = New MyHouseHoldBudgetBook.SummaryDataSet()
        Me.sumDgv = New System.Windows.Forms.DataGridView()
        Me.出金合計DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.入金合計DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.日付DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabSummary = New System.Windows.Forms.TabPage()
        Me.SumDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.日付DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.入金合計DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.出金合計DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MainMenu.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabList.SuspendLayout()
        CType(Me.SummaryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sumDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSummary.SuspendLayout()
        CType(Me.SumDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MainMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.編集EToolStripMenuItem, Me.表示VToolStripMenuItem, Me.ヘルプHToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(1178, 33)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.保存SToolStripMenuItem, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(98, 29)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '保存SToolStripMenuItem
        '
        Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
        Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(171, 34)
        Me.保存SToolStripMenuItem.Text = "保存(&S)"
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(171, 34)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        '編集EToolStripMenuItem
        '
        Me.編集EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.追加ToolStripMenuItem, Me.変更CToolStripMenuItem, Me.削除DToolStripMenuItem})
        Me.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem"
        Me.編集EToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.編集EToolStripMenuItem.Text = "編集(&E)"
        '
        '追加ToolStripMenuItem
        '
        Me.追加ToolStripMenuItem.Name = "追加ToolStripMenuItem"
        Me.追加ToolStripMenuItem.Size = New System.Drawing.Size(173, 34)
        Me.追加ToolStripMenuItem.Text = "追加(&A)"
        '
        '変更CToolStripMenuItem
        '
        Me.変更CToolStripMenuItem.Name = "変更CToolStripMenuItem"
        Me.変更CToolStripMenuItem.Size = New System.Drawing.Size(173, 34)
        Me.変更CToolStripMenuItem.Text = "変更(&C)"
        '
        '削除DToolStripMenuItem
        '
        Me.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem"
        Me.削除DToolStripMenuItem.Size = New System.Drawing.Size(173, 34)
        Me.削除DToolStripMenuItem.Text = "削除(&D)"
        '
        '表示VToolStripMenuItem
        '
        Me.表示VToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.一覧表示LToolStripMenuItem, Me.集計表示SToolStripMenuItem})
        Me.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem"
        Me.表示VToolStripMenuItem.Size = New System.Drawing.Size(85, 32)
        Me.表示VToolStripMenuItem.Text = "表示(&V)"
        '
        '一覧表示LToolStripMenuItem
        '
        Me.一覧表示LToolStripMenuItem.Name = "一覧表示LToolStripMenuItem"
        Me.一覧表示LToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.一覧表示LToolStripMenuItem.Text = "一覧表示(&L)"
        '
        '集計表示SToolStripMenuItem
        '
        Me.集計表示SToolStripMenuItem.Name = "集計表示SToolStripMenuItem"
        Me.集計表示SToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.集計表示SToolStripMenuItem.Text = "集計表示(&S)"
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.バージョン情報VToolStripMenuItem})
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(108, 29)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ（&H)"
        '
        'バージョン情報VToolStripMenuItem
        '
        Me.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem"
        Me.バージョン情報VToolStripMenuItem.Size = New System.Drawing.Size(237, 34)
        Me.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)"
        '
        'dgv
        '
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.日付DataGridViewTextBoxColumn, Me.分類DataGridViewTextBoxColumn, Me.品名DataGridViewTextBoxColumn, Me.金額DataGridViewTextBoxColumn, Me.備考DataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.MoneyDataTableBindingSource
        Me.dgv.Location = New System.Drawing.Point(3, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 62
        Me.dgv.RowTemplate.Height = 27
        Me.dgv.Size = New System.Drawing.Size(1100, 450)
        Me.dgv.TabIndex = 1
        '
        '日付DataGridViewTextBoxColumn
        '
        Me.日付DataGridViewTextBoxColumn.DataPropertyName = "日付"
        Me.日付DataGridViewTextBoxColumn.HeaderText = "日付"
        Me.日付DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn"
        Me.日付DataGridViewTextBoxColumn.Width = 150
        '
        '分類DataGridViewTextBoxColumn
        '
        Me.分類DataGridViewTextBoxColumn.DataPropertyName = "分類"
        Me.分類DataGridViewTextBoxColumn.HeaderText = "分類"
        Me.分類DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.分類DataGridViewTextBoxColumn.Name = "分類DataGridViewTextBoxColumn"
        Me.分類DataGridViewTextBoxColumn.Width = 150
        '
        '品名DataGridViewTextBoxColumn
        '
        Me.品名DataGridViewTextBoxColumn.DataPropertyName = "品名"
        Me.品名DataGridViewTextBoxColumn.HeaderText = "品名"
        Me.品名DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.品名DataGridViewTextBoxColumn.Name = "品名DataGridViewTextBoxColumn"
        Me.品名DataGridViewTextBoxColumn.Width = 150
        '
        '金額DataGridViewTextBoxColumn
        '
        Me.金額DataGridViewTextBoxColumn.DataPropertyName = "金額"
        Me.金額DataGridViewTextBoxColumn.HeaderText = "金額"
        Me.金額DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.金額DataGridViewTextBoxColumn.Name = "金額DataGridViewTextBoxColumn"
        Me.金額DataGridViewTextBoxColumn.Width = 150
        '
        '備考DataGridViewTextBoxColumn
        '
        Me.備考DataGridViewTextBoxColumn.DataPropertyName = "備考"
        Me.備考DataGridViewTextBoxColumn.HeaderText = "備考"
        Me.備考DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn"
        Me.備考DataGridViewTextBoxColumn.Width = 150
        '
        'MoneyDataTableBindingSource
        '
        Me.MoneyDataTableBindingSource.DataMember = "moneyDataTable"
        Me.MoneyDataTableBindingSource.DataSource = Me.MoneyDataSet
        '
        'MoneyDataSet
        '
        Me.MoneyDataSet.DataSetName = "MoneyDataSet"
        Me.MoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'buttonAdd
        '
        Me.buttonAdd.Location = New System.Drawing.Point(23, 498)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(109, 34)
        Me.buttonAdd.TabIndex = 2
        Me.buttonAdd.Text = "追加"
        Me.buttonAdd.UseVisualStyleBackColor = True
        '
        'buttonChange
        '
        Me.buttonChange.Location = New System.Drawing.Point(138, 498)
        Me.buttonChange.Name = "buttonChange"
        Me.buttonChange.Size = New System.Drawing.Size(109, 34)
        Me.buttonChange.TabIndex = 3
        Me.buttonChange.Text = "変更"
        Me.buttonChange.UseVisualStyleBackColor = True
        '
        'buttonDelete
        '
        Me.buttonDelete.Location = New System.Drawing.Point(253, 498)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(109, 34)
        Me.buttonDelete.TabIndex = 4
        Me.buttonDelete.Text = "削除"
        Me.buttonDelete.UseVisualStyleBackColor = True
        '
        'buttonEnd
        '
        Me.buttonEnd.Location = New System.Drawing.Point(1018, 498)
        Me.buttonEnd.Name = "buttonEnd"
        Me.buttonEnd.Size = New System.Drawing.Size(109, 34)
        Me.buttonEnd.TabIndex = 5
        Me.buttonEnd.Text = "終了"
        Me.buttonEnd.UseVisualStyleBackColor = True
        '
        'CategoryDataSet1
        '
        Me.CategoryDataSet1.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabList)
        Me.TabControl1.Controls.Add(Me.tabSummary)
        Me.TabControl1.Location = New System.Drawing.Point(12, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1142, 442)
        Me.TabControl1.TabIndex = 6
        '
        'tabList
        '
        Me.tabList.Controls.Add(Me.dgv)
        Me.tabList.Location = New System.Drawing.Point(4, 28)
        Me.tabList.Name = "tabList"
        Me.tabList.Padding = New System.Windows.Forms.Padding(3)
        Me.tabList.Size = New System.Drawing.Size(1134, 410)
        Me.tabList.TabIndex = 0
        Me.tabList.Text = "一覧表示"
        Me.tabList.UseVisualStyleBackColor = True
        '
        'SummaryDataSet
        '
        Me.SummaryDataSet.DataSetName = "SummaryDataSet"
        Me.SummaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sumDgv
        '
        Me.sumDgv.AutoGenerateColumns = False
        Me.sumDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sumDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.日付DataGridViewTextBoxColumn2, Me.入金合計DataGridViewTextBoxColumn1, Me.出金合計DataGridViewTextBoxColumn1})
        Me.sumDgv.DataSource = Me.SumDataTableBindingSource
        Me.sumDgv.Location = New System.Drawing.Point(0, 0)
        Me.sumDgv.Name = "sumDgv"
        Me.sumDgv.RowHeadersWidth = 62
        Me.sumDgv.RowTemplate.Height = 27
        Me.sumDgv.Size = New System.Drawing.Size(1134, 404)
        Me.sumDgv.TabIndex = 0
        '
        '出金合計DataGridViewTextBoxColumn
        '
        Me.出金合計DataGridViewTextBoxColumn.DataPropertyName = "出金合計"
        Me.出金合計DataGridViewTextBoxColumn.HeaderText = "出金合計"
        Me.出金合計DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.出金合計DataGridViewTextBoxColumn.Name = "出金合計DataGridViewTextBoxColumn"
        Me.出金合計DataGridViewTextBoxColumn.Width = 150
        '
        '入金合計DataGridViewTextBoxColumn
        '
        Me.入金合計DataGridViewTextBoxColumn.DataPropertyName = "入金合計"
        Me.入金合計DataGridViewTextBoxColumn.HeaderText = "入金合計"
        Me.入金合計DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.入金合計DataGridViewTextBoxColumn.Name = "入金合計DataGridViewTextBoxColumn"
        Me.入金合計DataGridViewTextBoxColumn.Width = 150
        '
        '日付DataGridViewTextBoxColumn1
        '
        Me.日付DataGridViewTextBoxColumn1.DataPropertyName = "日付"
        Me.日付DataGridViewTextBoxColumn1.HeaderText = "日付"
        Me.日付DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.日付DataGridViewTextBoxColumn1.Name = "日付DataGridViewTextBoxColumn1"
        Me.日付DataGridViewTextBoxColumn1.Width = 150
        '
        'tabSummary
        '
        Me.tabSummary.Controls.Add(Me.sumDgv)
        Me.tabSummary.Location = New System.Drawing.Point(4, 28)
        Me.tabSummary.Name = "tabSummary"
        Me.tabSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSummary.Size = New System.Drawing.Size(1134, 410)
        Me.tabSummary.TabIndex = 1
        Me.tabSummary.Text = "集計表示"
        Me.tabSummary.UseVisualStyleBackColor = True
        '
        'SumDataTableBindingSource
        '
        Me.SumDataTableBindingSource.DataMember = "SumDataTable"
        Me.SumDataTableBindingSource.DataSource = Me.SummaryDataSet
        '
        '日付DataGridViewTextBoxColumn2
        '
        Me.日付DataGridViewTextBoxColumn2.DataPropertyName = "日付"
        Me.日付DataGridViewTextBoxColumn2.HeaderText = "日付"
        Me.日付DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.日付DataGridViewTextBoxColumn2.Name = "日付DataGridViewTextBoxColumn2"
        Me.日付DataGridViewTextBoxColumn2.Width = 150
        '
        '入金合計DataGridViewTextBoxColumn1
        '
        Me.入金合計DataGridViewTextBoxColumn1.DataPropertyName = "入金合計"
        Me.入金合計DataGridViewTextBoxColumn1.HeaderText = "入金合計"
        Me.入金合計DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.入金合計DataGridViewTextBoxColumn1.Name = "入金合計DataGridViewTextBoxColumn1"
        Me.入金合計DataGridViewTextBoxColumn1.Width = 150
        '
        '出金合計DataGridViewTextBoxColumn1
        '
        Me.出金合計DataGridViewTextBoxColumn1.DataPropertyName = "出金合計"
        Me.出金合計DataGridViewTextBoxColumn1.HeaderText = "出金合計"
        Me.出金合計DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.出金合計DataGridViewTextBoxColumn1.Name = "出金合計DataGridViewTextBoxColumn1"
        Me.出金合計DataGridViewTextBoxColumn1.Width = 150
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 544)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.buttonEnd)
        Me.Controls.Add(Me.buttonDelete)
        Me.Controls.Add(Me.buttonChange)
        Me.Controls.Add(Me.buttonAdd)
        Me.Controls.Add(Me.MainMenu)
        Me.MainMenuStrip = Me.MainMenu
        Me.MaximumSize = New System.Drawing.Size(1200, 6000)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "mainForm"
        Me.Text = "簡易家計簿"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabList.ResumeLayout(False)
        CType(Me.SummaryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sumDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSummary.ResumeLayout(False)
        CType(Me.SumDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents dgv As DataGridView
    Friend WithEvents buttonAdd As Button
    Friend WithEvents buttonChange As Button
    Friend WithEvents buttonDelete As Button
    Friend WithEvents buttonEnd As Button
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 保存SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 終了XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 編集EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 表示VToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoneyDataSet As MoneyDataSet
    Friend WithEvents CategoryDataSet1 As CategoryDataSet
    Friend WithEvents 日付DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 分類DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 品名DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 金額DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 備考DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoneyDataTableBindingSource As BindingSource
    Friend WithEvents 追加ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 変更CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 削除DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 一覧表示LToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 集計表示SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents バージョン情報VToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabList As TabPage
    Friend WithEvents SummaryDataSet As SummaryDataSet
    Friend WithEvents tabSummary As TabPage
    Friend WithEvents sumDgv As DataGridView
    Friend WithEvents 出金合計DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 入金合計DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 日付DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents 日付DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents 入金合計DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents 出金合計DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SumDataTableBindingSource As BindingSource
End Class
