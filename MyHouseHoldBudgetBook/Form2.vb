Public Class itemForm
    '初期化処理
    Public Sub New(ByVal dsCategory As CategoryDataSet)
        InitializeComponent()
        CategoryDataSet.Merge(dsCategory)
    End Sub

    Private Sub buttonOK_Click(sender As Object, e As EventArgs) Handles buttonOK.Click

    End Sub
    Public Sub New(dsCategory As CategoryDataSet, '第1引数　分類一覧（型付きデータセット型）
                   nowDate As Date,　　　　　　　 '第2引数　日付（日付型）
                   category As String,          　'第3引数　分類（文字列型）
                   item As String,              　'第4引数　品名（文字列型）
                   money As Integer,            　'第5引数  金額（整数型）
                   remarks As String)             '第6引数  備考（文字列型）


        ' 初期化処理
        InitializeComponent()
        CategoryDataSet.Merge(dsCategory)
        MonthCalendar.SetDate(nowDate)
        cmbCategory.Text = category
        txtItem.Text = item
        mtxtMoney.Text = money.ToString()
        txtRemarks.Text = remarks
    End Sub
    '引数がない状態での呼出しを禁止
    Private Sub New()

    End Sub
End Class