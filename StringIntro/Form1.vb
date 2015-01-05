Public Class Form1

    Private Sub btnChars_Click(sender As Object, e As EventArgs) Handles btnChars.Click
        'chars shows the character in a certain position in a string 
        'Chars returns the character at a position in the string specified by the index aka address for that position in that string
        Dim intIndex As Integer = InputBox("Index:")
        Dim strInput As String = Me.txtStrInput.Text

        MsgBox("The character at index position " & intIndex & "is: " & strInput.Chars(intIndex))
    End Sub

    Private Sub btnLength_Click(sender As Object, e As EventArgs) Handles btnLength.Click
        'length returns a count of characters in a string as an integer
        Dim strInput As String = Me.txtStrInput.Text

        MsgBox("There are " & strInput.Length & " characters in this string.")

    End Sub

    Private Sub btnToUpper_Click(sender As Object, e As EventArgs) Handles btnToUpper.Click
        'forces all string letters to be UPPERCASE
        Dim strInput As String = Me.txtStrInput.Text

        MsgBox(strInput.ToUpper)

    End Sub

    Private Sub btnToLower_Click(sender As Object, e As EventArgs) Handles btnToLower.Click
        'forces all string letters to be lowercase
        Dim strInput As String = Me.txtStrInput.Text.ToLower
        'recommended way to use the tolower/toupper function

        MsgBox(strInput)

    End Sub

    Private Sub btnTrim_Click(sender As Object, e As EventArgs) Handles btnTrim.Click
        'removes extra leading or trailing spaces (unnecessary spaces at the beginning or end of the text)
        Dim strInput As String = Me.txtStrInput.Text.Trim


        MsgBox(strInput)

    End Sub

    Private Sub btnSubstring_Click(sender As Object, e As EventArgs) Handles btnSubstring.Click
        'extracts a subset of the actual string and store in a new variable
        'index is the "address" of a character in a string
        Dim strInput As String = Me.txtStrInput.Text.Trim


        Dim intStartIndex, intSubStrLength As Integer
        Dim strSubString As String

        intStartIndex = InputBox("Enter the index of the beginning of the substring")

        Do
            intSubStrLength = InputBox("Enter the number of characters in the substring")
        Loop Until intStartIndex + intSubStrLength <= strInput.Length

        strSubString = strInput.Substring(intStartIndex, intSubStrLength)

        MsgBox("Substring: " & strSubString)

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'remove part of the original string and store in a new variable
        Dim strInput As String = Me.txtStrInput.Text.Trim


        Dim intStartIndex, intSubStrLength As Integer
        Dim strStringwithPartRemoved As String

        intStartIndex = InputBox("Enter the index of the beginning of the substring you want removed")

        Do
            intSubStrLength = InputBox("Enter the number of characters in the substring")
        Loop Until intStartIndex + intSubStrLength <= strInput.Length

        strStringwithPartRemoved = strInput.Remove(intStartIndex, intSubStrLength)

        MsgBox("Modified original string: " & strStringwithPartRemoved)

    End Sub

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        'replace a subset of the actual string with some other string and store in a new variable 
        Dim strInput As String = Me.txtStrInput.Text.Trim

        Dim strOldString, strNewString As String
        Dim strReplacedString As String

        strOldString = InputBox("Enter the text to be replaced")

        strNewString = InputBox("Enter the replacement text")

        strReplacedString = strInput.Replace(strOldString, strNewString)

        MsgBox(strReplacedString)

    End Sub


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'replace a subset of the actual string with some other string and store in a new variable 
        Dim strInput As String = Me.txtStrInput.Text.Trim

        Dim intInsertPosition As Integer
        Dim strStringAddition As String
        Dim strModifiedString As String

        intInsertPosition = InputBox("Enter the index of the insert start position")

        strStringAddition = InputBox("Enter the text to be inserted")

        strModifiedString = strInput.Insert(intInsertPosition, strStringAddition)

        MsgBox("Your new string is:" & vbCrLf & strModifiedString)
        'vbtab indents stuff 

    End Sub
End Class
