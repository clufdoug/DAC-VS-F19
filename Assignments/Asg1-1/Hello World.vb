' Assignment: Asg1-1
' RCET0265
' Doug Cluff
' Hello World Program
'https://github.com/clufdoug/DAC-VS-F19/tree/master/Assignments/Asg1-1

Public Class HelloWorldLanguagesForm
    Dim response As String
    Dim language As String



    Private Sub LanguageEnglish_Click(sender As Object, e As EventArgs) Handles LanguageEnglishButton.Click
        response = "Hello World"
        language = "English"
        Text_Reply.Text = ("To say Hello world in " & language & " you would say " & response)

    End Sub

    Private Sub LanguageFrench_Click(sender As Object, e As EventArgs) Handles LanguageFrenchButton.Click
        response = "Bonjour le monde"
        language = "French"
        Text_Reply.Text = ("To say Hello world in " & language & " you would say " & response)
    End Sub

    Private Sub LanguageSpanish_Click(sender As Object, e As EventArgs) Handles LanguageSpanishButton.Click
        response = "Hola Mundo"
        language = "Spanish"
        Text_Reply.Text = ("To say Hello world in " & language & " you would say " & response)
    End Sub

    Private Sub LanguageGerman_Click(sender As Object, e As EventArgs) Handles LanguageGermanButton.Click
        response = "Hallo Welt"
        language = "German"
        Text_Reply.Text = ("To say Hello world in " & language & " you would say " & response)
    End Sub

    Private Sub LanguageItalian_Click(sender As Object, e As EventArgs) Handles LanguageItalianButton.Click
        response = "Ciao mondo"
        language = "Italian"
        Text_Reply.Text = ("To say Hello world in " & language & " you would say " & response)
    End Sub

    Private Sub LanguageNorwegian_Click(sender As Object, e As EventArgs) Handles LanguageNorwegianButton.Click
        response = "Hei Verden"
        language = "Norwegian"
        Text_Reply.Text = ("To say Hello world in " & language & " you would say " & response)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()


    End Sub
End Class
