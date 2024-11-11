Public Class EventHandler
    Public Sub DoStuff(EventContainer As EventContainer2)
        AddHandler EventContainer.MyEvent, AddressOf MyEventHandler
        RemoveHandler EventContainer.MyEvent, AddressOf MyEventHandler

        EventContainer.FireEvent()
    End Sub

    Private Sub MyEventHandler()
        Console.WriteLine("I am your RAM, and I am taking this class hostage!")
    End Sub
End Class
