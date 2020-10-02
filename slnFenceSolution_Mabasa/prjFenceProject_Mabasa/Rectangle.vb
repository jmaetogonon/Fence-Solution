Option Explicit On
Option Strict On
Option Infer Off

Public Class Rectangle
    Private _dblLength As Double
    Private _dblWidth As Double

    Public Property Length As Double
        Get
            Return _dblLength
        End Get
        Set(value As Double)
            If value > 0 Then
                _dblLength = value
            Else
                _dblLength = 0
            End If
        End Set
    End Property

    Public Property Width As Double
        Get
            Return _dblWidth
        End Get
        Set(value As Double)
            If value > 0 Then
                _dblWidth = value
            Else
                _dblWidth = 0
            End If
        End Set
    End Property

    Public Sub New()
        _dblLength = 0
        _dblWidth = 0
    End Sub

    Public Function GetArea() As Double
        Return _dblLength * _dblWidth
    End Function

    Public Function GetPerimeter() As Double
        Return ((_dblLength + _dblWidth) * 2)
    End Function
End Class
