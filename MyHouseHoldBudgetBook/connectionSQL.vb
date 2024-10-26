Imports Npgsql
Module connectionSQL

    Public pgsqlCon As New NpgsqlConnection
    Public sqlCommand As New NpgsqlCommand

    'データベース接続
    Public Sub sqlSt()

        Dim Builder = New NpgsqlConnectionStringBuilder()
        '接続に必要な情報をBuilderへ
        Builder.Host = ""
        Builder.Port = ""
        Builder.Username = ""
        Builder.Password = ""
        Builder.Database = ""

        Dim Constr = Builder.ToString()

        pgsqlCon.ConnectionString = Constr
        pgsqlCon.Open()

    End Sub

    'データベースの切断
    Public Sub cl()
        pgsqlCon.Close()
    End Sub

    'データセットを返すコード
    Public Function sqlResultReturn(ByVal query As String) As DataTable
        Dim dt As New DataTable()

        Try
            'データ取得の為のアダプタ設定
            Dim adapter = New NpgsqlDataAdapter(query, pgsqlCon)

            'データ取得
            Dim Ds As New DataSet
            adapter.Fill(dt)

            Return dt
        Catch ex As Exception

            Return dt

        End Try
    End Function
    'データセットを返さないSQLを処理
    Public Function sqlResultNo(ByVal query As String)

        Try
            sqlCommand.Connection = pgsqlCon
            sqlCommand.CommandText = query
            sqlCommand.ExecuteNonQuery()

            Return "Complete"

        Catch ex As Exception

            Return ex.Message

        End Try

    End Function

End Module
