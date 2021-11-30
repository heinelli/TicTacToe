'Tic Tac Toe Game
'RCET0265 Fall 2021
'

Option Strict On
Option Explicit On
'Option Compare Binary
Option Compare Text

'TODO:
'display game board console
'Player vs player
'evaluate win/draw
'new game, player turn, end game
'track wins per session (tournament play like best two out of three)

'Future:
'Allow choice of console game or graphical game (WinForm). web based asp.net if really ambitious
'

Module TicTacToe

    Dim gameBoard(2, 2) As String


    Sub Main()
        Dim row As String = "3"
        Dim rowCheck As String
        Dim column As String
        Dim userInput As String

        Do Until CInt(row) <= 2
            userInput = Console.ReadLine()
            rowCheck = userInput.Chars(0)
            column = userInput.Chars(1)
            If rowCheck = "A" Then
                row = "0"
            ElseIf rowCheck = "B" Then
                row = "1"
            ElseIf rowCheck = "C" Then
                row = "2"
            Else
                row = "3"
            End If

            If CInt(column) > 2 Then
                row = "3"
            End If

            If row = "3" Then
                MsgBox("test")
            End If

        Loop

        Console.WriteLine(row & column)
        Console.ReadLine()

    End Sub

End Module
