Imports System.Text

Public Class Console

    Private Sub Console_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbPuzzles.Items.Add(New Puzzle("Longest words that start with one letter and adding one letter makes another word",
                                       AddressOf FindLongestWordsThatMakeAnotherWordAddingALetter))
        lbPuzzles.Items.Add(New Puzzle("Find x-letter words that can use all vowels or other letters same position",
                                       AddressOf Find4LetterWordsWith1VowelThatCanUseAllVowels))
        lbPuzzles.Items.Add(New Puzzle("Find words with most words contained with same letter order",
                                       AddressOf FindWordsWithTheMostWordsContainedInThem))
        lbPuzzles.Items.Add(New Puzzle("Find words with all of these letters",
                                       AddressOf Find8LetterWordWithAthroughF))
        lbPuzzles.Items.Add(New Puzzle("Find words with x letters in same sequence ascending or descending",
                                       AddressOf FourLettersInSameSequence))
        lbPuzzles.Items.Add(New Puzzle("Words with ""LE"" and similar words without ""LE""",
                                       AddressOf FindWordsWithLE))
        lbPuzzles.Items.Add(New Puzzle("2LW that add 1 letter to make 3LW",
                                       AddressOf All2LetterWordsAndTheWordsYouCanMakeAdding1Letter))
        lbPuzzles.Items.Add(New Puzzle("Palidromes",
                                       AddressOf Palindromes))
        lbPuzzles.SelectedIndex = 0
        MaintainGenerateButton()
        Initialized = True
    End Sub
    Private Initialized As Boolean = False

    Private Class Puzzle
        Public Sub New(Description As String, Solver As SolverDelegate)
            Me.Description = Description
            Me.Solver = Solver
        End Sub
        Public Delegate Sub SolverDelegate()
        Public Description As String
        Public Solver As SolverDelegate
        Public Overrides Function ToString() As String
            Return Description
        End Function
    End Class

    Private Sub lbPuzzles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPuzzles.SelectedIndexChanged

    End Sub

    Private Sub cbTWL06_CheckedChanged(sender As Object, e As EventArgs) Handles cbTWL06.CheckedChanged, cbSOWPODS.CheckedChanged, cbOther.CheckedChanged, cbDebug.CheckedChanged, cbNewWindow.CheckedChanged, cbFile.CheckedChanged, tbFileName.TextChanged
        MaintainGenerateButton()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        tlpMain.Enabled = False
        Application.DoEvents()

        Dictionaries.Clear()
        If cbTWL06.Checked Then
            Dictionaries.Add("twl06.txt")
            ProgressBar1.Visible = True
        Else
            ProgressBar1.Visible = False
        End If
        If cbSOWPODS.Checked Then
            Dictionaries.Add("sowpods.txt")
            ProgressBar2.Visible = True
        Else
            ProgressBar2.Visible = False
        End If
        If cbOther.Checked Then
            Dictionaries.Add("english3.txt")
            ProgressBar3.Visible = True
        Else
            ProgressBar3.Visible = False
        End If

        Output.Clear()
        Output.Add(CType(lbPuzzles.SelectedItem, Puzzle).Description)
        Output.Add("")
        tlpProgress.Visible = True

        CType(lbPuzzles.SelectedItem, Puzzle).Solver()

        If cbDebug.Checked Then
            For Each s As String In Output
                Debug.WriteLine(s)
            Next
        End If
        If cbFile.Checked Then
            Using sw As IO.StreamWriter = New IO.StreamWriter(tbFileName.Text)
                For Each s As String In Output
                    sw.WriteLine(s)
                Next
                sw.Close()
            End Using
        End If
        If cbNewWindow.Checked Then
            Dim tw As TextOutputWindow = New TextOutputWindow With {.Output = Output, .Text = lbPuzzles.SelectedItem.ToString()}
            tw.Show()
        End If

        tlpProgress.Visible = False
        tlpMain.Enabled = True
    End Sub

    Private Dictionaries As List(Of String) = New List(Of String)
    Private Output As List(Of String) = New List(Of String)

    Private Sub MaintainGenerateButton()
        btnGenerate.Enabled = {cbTWL06, cbSOWPODS, cbOther, cbDebug, cbNewWindow, cbFile}.Any(Function(btn) btn.Checked)
        If cbFile.Checked AndAlso tbFileName.Text.Trim.Length = 0 Then
            btnGenerate.Enabled = False
        End If
    End Sub

    Private CurrentProgressBar As ProgressBar
    Private Sub InitializeProgressBar(Dict As String, MaxValue As Integer)
        Select Case Dictionaries.IndexOf(Dict)
            Case 0
                CurrentProgressBar = ProgressBar1
            Case 1
                CurrentProgressBar = ProgressBar2
            Case 2
                CurrentProgressBar = ProgressBar3
        End Select
        CurrentProgressBar.Minimum = 0
        CurrentProgressBar.Maximum = MaxValue
    End Sub
    Private Sub IncProgress()
        CurrentProgressBar.Value += 1
        Application.DoEvents()
    End Sub
    Private Sub IncProgress(Amount As Integer)
        CurrentProgressBar.Value += Amount
        Application.DoEvents()
    End Sub

    Private Sub FindLongestWordsThatMakeAnotherWordAddingALetter()
        Dim DictionaryList As List(Of String) = New List(Of String)
        Dim WordList As List(Of String) = New List(Of String)
        Dim SingleLetterWords As List(Of String) = New List(Of String)
        For Each FileName As String In Dictionaries
            Output.Add(FileName)
            Output.Add(New String("=", FileName.Length))

            DictionaryList.Clear()
            SingleLetterWords.Clear()

            Using sr As IO.StreamReader = New IO.StreamReader(FileName)
                While Not sr.EndOfStream
                    DictionaryList.Add(sr.ReadLine.ToLower.Trim)
                End While
            End Using

            SingleLetterWords.AddRange({"a", "i"})   ' other languages?
            InitializeProgressBar(FileName, DictionaryList.Where(Function(w) SingleLetterWords.Any(Function(slw) w.StartsWith(slw))).Count)

            For Each SingleLetterWord As String In SingleLetterWords
                WordList.Clear()
                WordList.Add(SingleLetterWord)
                DictionaryList.Remove(SingleLetterWord)
                For Each Candidate As String In DictionaryList.Where(Function(w) w.StartsWith(SingleLetterWord, StringComparison.CurrentCulture))
                    If WordList.Any(Function(w) w.Equals(Strings.Left(Candidate, Candidate.Length - 1), StringComparison.CurrentCulture)) Then
                        WordList.Add(Candidate)
                    End If
                    IncProgress()
                Next
                For Each Winner As String In WordList.OrderByDescending(Function(w) w.Length).GroupBy(Function(w) w.Length)(0)
                    Output.Add(Winner)
                Next
                Output.Add(New String("-", WordList.OrderByDescending(Function(w) w.Length).GroupBy(Function(w) w.Length)(0).Count))
            Next

            Output.Add(New String("*", Dictionaries.Max(Function(fn) fn.Length)))
        Next
    End Sub
    Private WordsWithAllLettersDlg As FindXLetterWordsThatHaveAllTheseLettersInOnePositionDialog = Nothing
    Private Sub Find4LetterWordsWith1VowelThatCanUseAllVowels()
        Dim WordList As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        Dim MinWordLength As Integer = 4
        Dim MaxWordLength As Integer = 4
        Dim VList = {"a"c, "e"c, "i"c, "o"c, "u"c}    ' all but one of the letters is a vowel

        If WordsWithAllLettersDlg Is Nothing Then
            WordsWithAllLettersDlg = New FindXLetterWordsThatHaveAllTheseLettersInOnePositionDialog
            WordsWithAllLettersDlg.MinLetters = MinWordLength
            WordsWithAllLettersDlg.MaxLetters = MaxWordLength
            WordsWithAllLettersDlg.Letters = VList
        End If
        If WordsWithAllLettersDlg.ShowDialog = DialogResult.OK Then
            MinWordLength = WordsWithAllLettersDlg.MinLetters
            MaxWordLength = WordsWithAllLettersDlg.MaxLetters
            VList = WordsWithAllLettersDlg.Letters.ToArray()
            Output.Add($"Letters: {VList.ToString()}")
            Output.Add($"min word size: {MinWordLength}")
            Output.Add($"max word size: {MaxWordLength}")
        Else
            Output.Add("")
            Output.Add("ABORTED")
            Exit Sub
        End If

        Dim Word As String
        Dim VowelIndex As Integer
        Dim FileName As String
        For Each FileName In Dictionaries
            Output.Add(FileName)
            Output.Add(New String("=", FileName.Length))

            Using sr As IO.StreamReader = New IO.StreamReader(FileName)
                WordList.Clear()

                While Not sr.EndOfStream
                    Word = sr.ReadLine().ToLower().Trim()
                    If Word.Length >= MinWordLength AndAlso Word.Length <= MaxWordLength AndAlso Word.Count(Function(c) VList.Contains(c)) = 1 Then
                        VowelIndex = Word.IndexOfAny(VList)
                        If Word(VowelIndex) = "a"c Then        ' they'll be in alphabetical order
                            WordList.Add(Word, 1)
                        Else
                            Dim WordWithA As String = Word.Replace(Word(VowelIndex), "a")
                            If WordList.ContainsKey(WordWithA) Then
                                WordList(WordWithA) += 1
                            End If
                        End If
                    End If
                End While

                For Each Entry As KeyValuePair(Of String, Integer) In WordList.Where(Function(kvp) kvp.Value = VList.Length).OrderByDescending(Function(kvp) kvp.Key.Length).ThenBy(Function(kvp) kvp.Key)
                    Output.Add(VList.Skip(1).Aggregate(Entry.Key, Function(ag, c) $"{ag},{Entry.Key.Replace("a"c, c)}"))
                Next
            End Using

            Output.Add(New String("*", Dictionaries.Max(Function(fn) fn.Length)))
        Next
    End Sub
    Private WordsWithXLettersDialog As FindXLetterWordWithAThroughZDialog = Nothing
    Private Sub Find8LetterWordWithAthroughF()
        Dim WordList As List(Of String) = New List(Of String)
        Dim MinWordLength As Integer = 8
        Dim MaxWordLength As Integer = 8
        Dim LList = {"a"c, "b"c, "c"c, "d"c, "e"c, "f"c}

        If WordsWithXLettersDialog Is Nothing Then
            WordsWithXLettersDialog = New FindXLetterWordWithAThroughZDialog
            WordsWithXLettersDialog.MinLetters = MinWordLength
            WordsWithXLettersDialog.MaxLetters = MaxWordLength
            WordsWithXLettersDialog.Letters = LList
        End If
        If WordsWithXLettersDialog.ShowDialog = DialogResult.OK Then
            MinWordLength = WordsWithXLettersDialog.MinLetters
            MaxWordLength = WordsWithXLettersDialog.MaxLetters
            LList = WordsWithXLettersDialog.Letters.ToArray()
            Output.Add($"Letters: {LList.ToString()}")
            Output.Add($"min word size: {MinWordLength}")
            Output.Add($"max word size: {MaxWordLength}")
        Else
            Output.Add("")
            Output.Add("ABORTED")
            Exit Sub
        End If

        Dim Word As String
        For Each FileName As String In Dictionaries
            Output.Add(FileName)
            Output.Add(New String("=", FileName.Length))

            WordList.Clear()

            Using sr As IO.StreamReader = New IO.StreamReader(FileName)
                While Not sr.EndOfStream
                    Word = sr.ReadLine().ToLower().Trim()
                    If Word.Length >= MinWordLength AndAlso Word.Length <= MaxWordLength AndAlso LList.All(Function(c) Word.Contains(c)) Then
                        WordList.Add(Word)
                    End If
                End While
            End Using
            For Each Word In WordList.OrderBy(Function(w) w.Length).ThenBy(Function(w) w)
                Output.Add(Word)
            Next

            Output.Add(New String("*", Dictionaries.Max(Function(fn) fn.Length)))
        Next
    End Sub

    ' todo: this one can change its parameters
    Private WordsWithXLettersSameSequenceDialog As FindWordsWithXLettersConsecutiveAscendingOrDescending = Nothing
    Public Sub FourLettersInSameSequence()
        Dim DictionaryList As List(Of String) = New List(Of String)
        Dim WordsContainedDictionary As Dictionary(Of String, List(Of String)) = New Dictionary(Of String, List(Of String))
        Dim MinWordLength As Integer = 4
        Dim MaxWordLength As Integer = 26
        Dim MinConseqLetters As Integer = 4
        Dim MaxConseqLetters As Integer = 4
        Dim Direction As Integer = 1    ' or -1

        If WordsWithXLettersSameSequenceDialog Is Nothing Then
            WordsWithXLettersSameSequenceDialog = New FindWordsWithXLettersConsecutiveAscendingOrDescending
            WordsWithXLettersSameSequenceDialog.MinLetters = MinWordLength
            WordsWithXLettersSameSequenceDialog.MaxLetters = MaxWordLength
            WordsWithXLettersSameSequenceDialog.MinConseq = MinConseqLetters
            WordsWithXLettersSameSequenceDialog.MaxConseq = MaxConseqLetters
            WordsWithXLettersSameSequenceDialog.Ascending = Direction = 1
        End If
        If WordsWithXLettersSameSequenceDialog.ShowDialog = DialogResult.OK Then
            MinWordLength = WordsWithXLettersSameSequenceDialog.MinLetters
            MaxWordLength = WordsWithXLettersSameSequenceDialog.MaxLetters
            MinConseqLetters = WordsWithXLettersSameSequenceDialog.MinConseq
            MaxConseqLetters = WordsWithXLettersSameSequenceDialog.MaxConseq
            Direction = IIf(WordsWithXLettersSameSequenceDialog.Ascending, 1, -1)
            Output.Add($"min word size: {MinWordLength}")
            Output.Add($"max word size: {MaxWordLength}")
            Output.Add($"min conseq: {MinConseqLetters}")
            Output.Add($"max conseq: {MaxConseqLetters}")
            If Direction = 1 Then
                Output.Add("ascending")
            Else
                Output.Add("descending")
            End If
        Else
            Output.Add("")
            Output.Add("ABORTED")
            Exit Sub
        End If

        Dim NewWord As Boolean
        Dim LastAsc As Integer
        Dim Count As Integer
        Dim i As Integer
        For Each FileName As String In Dictionaries
            Output.Add(FileName)
            Output.Add(New String("=", FileName.Length))

            DictionaryList.Clear()
            WordsContainedDictionary.Clear()

            Using sr As IO.StreamReader = New IO.StreamReader(FileName)
                While Not sr.EndOfStream
                    DictionaryList.Add(sr.ReadLine().ToLower().Trim())
                End While
            End Using

            For Each Word As String In DictionaryList.Where(Function(w) w.Length >= MinWordLength AndAlso w.Length <= MaxWordLength)
                NewWord = True
                LastAsc = Asc(Word(0))
                Count = 1

                For i = 1 To Word.Length - 1
                    LastAsc += Direction
                    If LastAsc = Asc(Word(i)) Then
                        Count += 1
                    Else
                        If Count >= MinConseqLetters AndAlso Count <= MaxConseqLetters Then
                            Output.Add($"{Word} ({Count})")
                        End If
                        LastAsc = Asc(Word(i))
                        Count = 1
                    End If
                Next
                If Count >= MinConseqLetters AndAlso Count <= MaxConseqLetters Then
                    Output.Add($"{Word} ({Count})")
                End If
            Next

            Output.Add(New String("*", Math.Min(Dictionaries.Max(Function(fn) fn.Length), MaxConseqLetters)))
        Next
    End Sub
    Private Sub FindWordsWithTheMostWordsContainedInThem()
        Dim DictionaryList As List(Of String) = New List(Of String)
        Dim LongWords As Dictionary(Of String, List(Of String)) = New Dictionary(Of String, List(Of String))
        Dim LargestQuantityOfShorterWords As Integer
        For Each FileName As String In Dictionaries
            Output.Add(FileName)
            Output.Add(New String("=", FileName.Length))

            DictionaryList.Clear()

            Using sr As IO.StreamReader = New IO.StreamReader(FileName)
                While Not sr.EndOfStream
                    DictionaryList.Add(sr.ReadLine.ToLower.Trim)
                End While
            End Using

            InitializeProgressBar(FileName, DictionaryList.Count)

            LongWords.Clear()
            For Each LongWord As String In DictionaryList
                LongWords.Add(LongWord, New List(Of String)(LongWords.Keys.Where(Function(w) w.Length < LongWord.Length).Where(Function(w) LongWord.Contains(w))))
                IncProgress()
            Next

            Output.Add("Words with most smaller words")
            Output.Add("-----------------------------")
            LargestQuantityOfShorterWords = LongWords.Values.Max(Function(sl) sl.Count)
            For Each LongWord As String In LongWords.Keys.Where(Function(k) LongWords(k).Count >= LargestQuantityOfShorterWords).OrderByDescending(Function(k) LongWords(k).Count).ThenByDescending(Function(k) k)
                Output.Add($"{LongWord} {LongWords(LongWord).Count}")
                For Each ShortWord As String In LongWords(LongWord).OrderByDescending(Function(w) w.Length).ThenByDescending(Of String)(Function(w) w)
                    Output.Add(" " & ShortWord)
                Next
            Next

            Output.Add("Words with no smaller words")
            Output.Add("---------------------------")
            For Each LongWord As String In LongWords.Keys.Where(Function(k) LongWords(k).Count = 0).OrderByDescending(Function(k) k)
                Output.Add($"{LongWord} {LongWord.Length}")
            Next

            Output.Add(New String("*", Dictionaries.Max(Function(fn) fn.Length)))
        Next
    End Sub
    Private Sub FindWordsWithLE()
        Dim DictionaryList As List(Of String) = New List(Of String)
        Dim Separator As String
        For Each FileName As String In Dictionaries
            Output.Add(FileName)
            Output.Add(New String("=", FileName.Length))

            DictionaryList.Clear()

            Using sr As IO.StreamReader = New IO.StreamReader(FileName)
                While Not sr.EndOfStream
                    DictionaryList.Add(sr.ReadLine().ToLower().Trim())
                End While
            End Using
            Separator = New String("=", DictionaryList.Max(Function(w) w.Length))

            Dim WordsWithLE As IEnumerable(Of String) = DictionaryList.Where(Function(w) w.Contains("le"))
            InitializeProgressBar(FileName, WordsWithLE.Count)
            For Each Word As String In WordsWithLE
                For Each SmallerWord As String In DictionaryList.Where(Function(w) w = Word.Replace("le", ""))
                    Output.Add(Word)
                    Output.Add(SmallerWord)
                    Output.Add(Separator)
                Next
                IncProgress()
            Next

            Output.Add(New String("*", Dictionaries.Max(Function(fn) fn.Length)))
        Next
    End Sub
    Private Sub All2LetterWordsAndTheWordsYouCanMakeAdding1Letter()
        Dim DictionaryList As List(Of String) = New List(Of String)
        For Each FileName As String In Dictionaries
            Output.Add(FileName)
            Output.Add(New String("=", FileName.Length))

            DictionaryList.Clear()

            Using sr As IO.StreamReader = New IO.StreamReader(FileName)
                While Not sr.EndOfStream
                    DictionaryList.Add(sr.ReadLine().ToLower().Trim())
                End While
            End Using

            Dim Words2 As IEnumerable(Of String) = DictionaryList.Where(Function(w) w.Length = 2)
            InitializeProgressBar(FileName, Words2.Count)
            For Each Word2 As String In Words2
                Output.Add(Word2)

                For Each Word3 As String In DictionaryList.Where(Function(w) w.Length = 3 AndAlso w.Contains(Word2)).OrderBy(Function(w) w)
                    Output.Add($"    {Word3}")
                Next

                Output.Add(New String("-", 7))
                IncProgress()
            Next

            Output.Add(New String("*", Dictionaries.Max(Function(fn) fn.Length)))
        Next
    End Sub
    Private Sub Palindromes()
        Dim DictionaryList As List(Of String) = New List(Of String)
        Dim Palindromes As List(Of String) = New List(Of String)
        Dim Word As String
        Dim ReversedWord As String
        For Each FileName As String In Dictionaries
            Output.Add(FileName)
            Output.Add(New String("=", FileName.Length))

            DictionaryList.Clear()
            Palindromes.Clear()

            Using sr As IO.StreamReader = New IO.StreamReader(FileName)
                While Not sr.EndOfStream
                    DictionaryList.Add(sr.ReadLine().ToLower().Trim())
                End While
            End Using

            For Each Word In DictionaryList
                ReversedWord = Word.Reverse().ToArray()
                If Word.Equals(ReversedWord, StringComparison.CurrentCulture) Then
                    Palindromes.Add(Word)
                End If
            Next

            For Each Word In Palindromes.OrderByDescending(Function(w) w.Length).ThenBy(Function(w) w)
                Output.Add(Word)
            Next

            Output.Add(New String("*", Dictionaries.Max(Function(fn) fn.Length)))
        Next
    End Sub
End Class
