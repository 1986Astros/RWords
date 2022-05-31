Public Class FindXLetterWordWithAThroughZDialog
    Public Property MinLetters As Integer
        Get
            Return nudMinLetters.Value
        End Get
        Set(value As Integer)
            nudMinLetters.Value = value
        End Set
    End Property
    Public Property MaxLetters As Integer
        Get
            Return nudMaxLetters.Value
        End Get
        Set(value As Integer)
            nudMaxLetters.Value = value
        End Set
    End Property
    Public Property Letters As IEnumerable(Of Char)
        Get
            Return New List(Of Char)(tbLetters.Text.Where(Function(c) Char.IsLetter(c)).Distinct().OrderBy(Function(c) c))
        End Get
        Set(value As IEnumerable(Of Char))
            tbLetters.Text = value.ToArray()
        End Set
    End Property

    Private Sub tbLetters_TextChanged(sender As Object, e As EventArgs) Handles tbLetters.TextChanged, nudMinLetters.ValueChanged, nudMaxLetters.ValueChanged
        Dim Validated As Boolean = True
        Dim CurrentLetterCount As Integer = Letters.Count()
        If nudMaxLetters.Value < nudMinLetters.Value Then
            lblMinLetters.BackColor = Color.Red
            lblMaxLetters.BackColor = Color.Red
            Validated = False
        ElseIf nudMinLetters.Value < CurrentLetterCount Then
            lblMinLetters.BackColor = Color.Red
            If nudMaxLetters.Value < CurrentLetterCount Then
                lblMaxLetters.BackColor = Color.Red
            Else
                lblMaxLetters.BackColor = tlpWordSize.BackColor
            End If
            Validated = False
        ElseIf nudMaxLetters.Value < CurrentLetterCount Then
            lblMinLetters.BackColor = tlpWordSize.BackColor
            lblMaxLetters.BackColor = Color.Red
            Validated = False
        Else
            lblMinLetters.BackColor = tlpWordSize.BackColor
            lblMaxLetters.BackColor = tlpWordSize.BackColor
        End If
        btnOK.Enabled = Validated
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class