Public Class EventContainer
    Public Event MyEvent()

    Public Sub FireEvent()
        RaiseEvent MyEvent()
    End Sub
End Class
