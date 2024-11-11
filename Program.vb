Module Program
    Public Sub Main(args As String())
        Dim EventContainer As EventContainer = New EventContainer2()
        Dim Handler As New EventHandler()

        Handler.DoStuff(EventContainer)
    End Sub
End Module
