Partial Class TradeStatisticsDataSet
    Partial Public Class ExportDataDataTable
        'Private Sub ExportDataDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
        '    If (e.Column.ColumnName = Me.HighlightFlag.ColumnName) Then
        '        'Add user code here
        '    End If

        'End Sub

    End Class

    Partial Public Class HscodeDataTable
        Private Sub HscodeDataTable_HscodeRowChanging(sender As Object, e As HscodeRowChangeEvent) Handles Me.HscodeRowChanging

        End Sub

    End Class
End Class


Namespace TradeStatisticsDataSetTableAdapters
    Partial Public Class usersTableAdapter
    End Class

    Partial Public Class ImportSummaryTableAdapter
    End Class

    Partial Public Class ExportDataTableAdapter
    End Class

    Partial Public Class SupervisorWorkTableAdapter
    End Class

    Partial Public Class ImportDataTableAdapter
    End Class
End Namespace
