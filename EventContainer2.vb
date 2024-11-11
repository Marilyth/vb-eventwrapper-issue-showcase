Public Class EventContainer2
    Inherits EventContainer
    Public Shadows Event MyEvent(Text As String)

    Public Sub FireEvent()
        RaiseEvent MyEvent("Me")
    End Sub
End Class
