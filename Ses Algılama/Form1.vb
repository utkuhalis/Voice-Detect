Imports System.Speech.Recognition
Imports System.Speech.Recognition.SrgsGrammar
Public Class Form1

    Private recognizer As SpeechRecognizer

    Public Sub New()

        InitializeComponent()

        recognizer = New SpeechRecognizer()

        AddHandler recognizer.SpeechRecognized, AddressOf recognizer_SpeechRecognized

    Dim grammar As New GrammarBuilder()
        grammar.Append(New Choices(System.IO.File.ReadAllLines("text.txt")))

        recognizer.LoadGrammar(New Grammar(grammar))

    End Sub

    Private Sub recognizer_SpeechRecognized(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)
        Label1.Text = e.Result.Text.ToUpper
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
