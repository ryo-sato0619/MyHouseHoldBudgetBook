﻿Public Class mainForm
    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub 編集EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 編集EToolStripMenuItem.Click

    End Sub

    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click
        AddData()
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("給料", "入金")
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("食費", "出金")
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("娯楽費", "出金")
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("通信費", "出金")
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("交通費", "出金")
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("学習", "出金")
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("その他", "出金")
    End Sub

    '入力データを型付きデータセットに格納するサブルーチン
    Private Sub AddData()
        Dim frmItem As itemForm = New itemForm(CategoryDataSet1)
        Dim drRet As DialogResult = frmItem.ShowDialog()

        If drRet = DialogResult.OK Then
            MoneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                frmItem.MonthCalendar.SelectionRange.Start(),
                frmItem.cmbCategory.Text,
                frmItem.txtItem.Text,
                Integer.Parse(frmItem.mtxtMoney.Text),
                frmItem.txtRemarks.Text)
        End If
    End Sub

    Private Sub 追加ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 追加ToolStripMenuItem.Click
        AddData()
    End Sub

    Private Sub buttonEnd_Click(sender As Object, e As EventArgs) Handles buttonEnd.Click
        Me.Close()
    End Sub

    Private Sub 終了XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了XToolStripMenuItem.Click
        Me.Close()
    End Sub
    'データ保存用サブルーチン
    Private Sub SaveData()
        '出力ファイル名
        Dim path As String = "MoneyData.csv"
        'データ1行分
        Dim strData As String
        'ファイルを作成するクラスのインスタンスを作成
        Dim sw As System.IO.StreamWriter _
            = New System.IO.StreamWriter(path, False, System.Text.Encoding.Default)
        'レコード数ループ
        For Each drMoney As MoneyDataSet.moneyDataTableRow In MoneyDataSet.moneyDataTable
            strData = drMoney.日付.ToShortDateString() _
                + "," + drMoney.分類 _
                + "," + drMoney.品名 _
                + "," + drMoney.金額.ToString() _
                + "," + drMoney.備考
            '1行分のデータを出力
            sw.WriteLine(strData)
        Next
        sw.Close()
    End Sub

    'データ読み込み用サブルーチン
    Sub LoadData()
        'ファイル名
        Dim path As String = "MoneyData.csv"
        '区切り文字
        Dim delimStr As String = ","
        '区切り文字をまとめる
        Dim delimiter() As Char = delimStr.ToCharArray
        '分解後の文字の入れ物
        Dim strData() As String
        '1行分のデータ
        Dim strLine As String
        'ファイルが存在するか確認
        Dim fileExists As Boolean _
            = My.Computer.FileSystem.FileExists(path)
        'ファイルがあれば読み込む
        If fileExists Then
            Dim sr As IO.StreamReader = New IO.StreamReader(path, System.Text.Encoding.Default)
            While (sr.Peek() >= 0)
                strLine = sr.ReadLine()
                strData = strLine.Split(delimiter)
                MoneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                    Date.Parse(strData(0)),
                    strData(1).ToString(),
                    strData(2).ToString(),
                    Integer.Parse(strData(3)),
                    strData(4).ToString()
                )
            End While
            sr.Close()
        End If
    End Sub

    Private Sub 保存SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存SToolStripMenuItem.Click
        SaveData()
    End Sub

    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveData()
    End Sub

    'データ追加、変更処理
    Private Sub UpdateData()
        '選択行を取得
        Dim nowRow As Integer = dgv.CurrentRow.Index
        Dim oldDate As Date _
            = Date.Parse(dgv.Rows(nowRow).Cells(0).Value.ToString())
        Dim oldcategory As String = dgv.Rows(nowRow).Cells(1).Value.ToString()
        Dim oldItem As String = dgv.Rows(nowRow).Cells(2).Value.ToString()
        Dim oldMoney As Integer _
            = Integer.Parse(dgv.Rows(nowRow).Cells(3).Value.ToString())
        Dim oldRemarks As String = dgv.Rows(nowRow).Cells(4).Value.ToString()
        '6つの引数を渡してインスタンスを生成
        Dim frmItem As itemForm = New itemForm(CategoryDataSet1, oldDate, oldcategory, olditem, oldMoney, oldRemarks)
        Dim drRet As DialogResult = frmItem.ShowDialog
        '登録画面でOK選択時
        If drRet = DialogResult.OK Then
            dgv.Rows(nowRow).Cells(0).Value _
                = frmItem.MonthCalendar.SelectionRange.Start()
            dgv.Rows(nowRow).Cells(1).Value = frmItem.cmbCategory.Text
            dgv.Rows(nowRow).Cells(2).Value = frmItem.txtItem.Text
            dgv.Rows(nowRow).Cells(3).Value = Integer.Parse(frmItem.mtxtMoney.Text)
            dgv.Rows(nowRow).Cells(4).Value = frmItem.txtRemarks.Text
        End If
    End Sub

    Private Sub buttonChange_Click(sender As Object, e As EventArgs) Handles buttonChange.Click
        UpdateData()
    End Sub

    Private Sub 変更CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 変更CToolStripMenuItem.Click
        UpdateData()
    End Sub
    '削除処理
    Private Sub DeleteDate()
        Dim nowRow As Integer = dgv.CurrentRow.Index
        '選択している行を削除
        dgv.Rows.RemoveAt(nowRow)
    End Sub

    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click
        DeleteDate()
    End Sub

    Private Sub 削除DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 削除DToolStripMenuItem.Click
        DeleteDate()
    End Sub

    'データ集計
    Private Sub CalcSummary()
        Dim expression As String
        '集計用データテーブルセットの初期化
        SummaryDataSet.SumDataTable.Clear()
        '一覧表示のデータセット(レコード数ループ）
        For Each drMoney As MoneyDataSet.moneyDataTableRow _
                In MoneyDataSet.moneyDataTable
            '日付を検索文字に
            expression = "日付 ='" _
                + drMoney.日付.ToShortDateString() _
                + "'"
            'データテーブルから現在処理している日付を検索
            Dim curDR() As SummaryDataSet.SumDataTableRow _
                = CType(SummaryDataSet.SumDataTable.Select(expression), SummaryDataSet.SumDataTableRow())
            '検索したデータ件数の確認
            If curDR.Length = 0 Then

                If (CType(CategoryDataSet1.CategoryDataTable.Select _
                            ("分類='" & drMoney.分類 & "'"),
                             CategoryDataSet.CategoryDataTableRow())(0).入出金分類 = "入金") Then
                    SummaryDataSet.SumDataTable.AddSumDataTableRow(drMoney.日付, drMoney.金額, 0)
                ElseIf (CType(CategoryDataSet1.CategoryDataTable.Select _
                            ("分類='" & drMoney.分類 & "'"),
                            CategoryDataSet.CategoryDataTableRow())(0).入出金分類 = "出金") Then
                    SummaryDataSet.SumDataTable.AddSumDataTableRow(drMoney.日付, 0, drMoney.金額)
                End If

            Else

                If (CType(CategoryDataSet1.CategoryDataTable.Select _
                         ("分類='" & drMoney.分類 & "'"),
                     CategoryDataSet.CategoryDataTableRow())(0).入出金分類 = "入金") Then
                    curDR(0).入金合計 += drMoney.金額
                ElseIf (CType(CategoryDataSet1.CategoryDataTable.Select _
                                    ("分類='" & drMoney.分類 & "'"),
                                    CategoryDataSet.CategoryDataTableRow())(0).入出金分類 = "出金") Then
                    curDR(0).出金合計 += drMoney.金額
                End If

            End If
        Next
    End Sub
    'タブ切り替え時
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        CalcSummary()
    End Sub

    Private Sub 一覧表示LToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 一覧表示LToolStripMenuItem.Click
        TabControl1.SelectTab(tabList)
    End Sub

    Private Sub 集計表示SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 集計表示SToolStripMenuItem.Click
        TabControl1.SelectTab(tabSummary)
    End Sub

End Class