Public Class FindWordsWithXLettersConsecutiveAscendingOrDescending
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
    Public Property MinConseq As Integer
        Get
            Return nudMinConseq.Value
        End Get
        Set(value As Integer)
            nudMinConseq.Value = value
        End Set
    End Property
    Public Property MaxConseq As Integer
        Get
            Return nudMaxConseq.Value
        End Get
        Set(value As Integer)
            nudMaxConseq.Value = value
        End Set
    End Property
    Public Property Ascending As Boolean
        Get
            Return IIf(rbAscending.Checked, True, False)
        End Get
        Set(value As Boolean)
            If value Then
                rbAscending.Checked = True
            Else
                rbDescending.Checked = True
            End If
        End Set
    End Property

    Private Sub FindWordsWithXLettersConsecutiveAscendingOrDescending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialized = True
    End Sub
    Private Initialized As Boolean = False

    Private Sub button_TextChanged(sender As Object, e As EventArgs) Handles nudMinLetters.ValueChanged, nudMaxLetters.ValueChanged, nudMinConseq.ValueChanged, nudMaxConseq.ValueChanged, nudMinLetters.Validating, nudMaxLetters.Validating, nudMinConseq.Validating, nudMaxConseq.Validating
        If Initialized Then
            Dim MinLettersValid As Boolean = True
            Dim MaxLettersValid As Boolean = True
            Dim MinConseqValid As Boolean = True
            Dim MaxConseqValid As Boolean = True
            If nudMaxLetters.Value < nudMinLetters.Value Then
                MinLettersValid = False
                MaxLettersValid = False
            End If
            If nudMinLetters.Value < nudMinConseq.Value Then
                MinLettersValid = False
                MinConseqValid = False
            End If
            If nudMaxLetters.Value < nudMaxConseq.Value Then
                MaxLettersValid = False
                MaxConseqValid = False
            End If
            If nudMinConseq.Value > nudMaxConseq.Value Then
                MinConseqValid = False
                MaxConseqValid = False
            End If
            UpdateControlBackColor(lblMinLetters, MinLettersValid)
            UpdateControlBackColor(lblMaxLetters, MaxLettersValid)
            UpdateControlBackColor(lblMinConseq, MinConseqValid)
            UpdateControlBackColor(lblMaxConseq, MaxConseqValid)

            btnOK.Enabled = MinLettersValid AndAlso MaxLettersValid AndAlso MinConseqValid AndAlso MaxConseqValid
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub UpdateControlBackColor(C As Control, Valid As Boolean)
        If Valid Then
            C.BackColor = tlpLengths.BackColor
        Else
            C.BackColor = Color.Red
        End If
    End Sub
End Class