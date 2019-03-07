Option Strict On
Public Class frmDemo
    Private Sub frmDemo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        initLevel()
    End Sub
    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        onUpdate()
    End Sub
    'Location to start the bird at
    Private characterPosition As Point
    'Listing of all of the barrier image elements
    Private barriers As PictureBox()
    'Listing of all of the barrier elements locations
    Private barrierLocation As List(Of Point)
    Private Sub initLevel()
        'Reset the Position of the character
        characterPosition = New Point(12, 154)
        picCharacter.Location = characterPosition
        barriers = {picTop1, picTop2, picBottom1, picBottom2}
        barrierLocation = New List(Of Point) From {New Point(227, 0), New Point(381, 0), New Point(222, 227), New Point(381, 292)}
        'Initiate each of the barriers to its original location
        For i As Integer = 0 To barriers.Length - 1 Step 1
            'Set a barrier to its corresponding start location
            barriers(i).Location = barrierLocation(i)
        Next
        tmrMain.Enabled = True
    End Sub
    Private Sub onUpdate()
        'Move the barriers
        updateBarriers()
        'Move the character
        updateCharacter()
        'Collision detection
        detectCollision()
    End Sub
    'The amount of X pixels to move per fixed update
    Private Const horizontalSpeed As Integer = 5
    'The amount of Y pixels to move per fixed update
    Private Const verticalSpeed As Integer = 10
    Private Sub updateBarriers()
        For Each barrier As PictureBox In barriers
            barrier.Location = New Point(barrier.Location.X - horizontalSpeed, barrier.Location.Y)
            'Add the current barriers location to the position list
            barrierLocation.Add(barrier.Location)
        Next
    End Sub
    Private spaceDown As Boolean = False
    Private Sub updateCharacter()
        Dim appliedVertSpeed As Integer = verticalSpeed
        If spaceDown Then
            'Apply gravity - multiply the up speed by -1
            appliedVertSpeed *= -1
        End If
        characterPosition.Y = characterPosition.Y + appliedVertSpeed
        picCharacter.Location = characterPosition
    End Sub
    Private Sub detectCollision()
        'Define the the additional character properties
        Dim characterRight As Integer = picCharacter.Left + picCharacter.Size.Width
        Dim characterBottom As Integer = picCharacter.Top + picCharacter.Size.Height
        For Each barrier As PictureBox In barriers
            'Define the additional barrier properties
            Dim barrierRight As Integer = barrier.Left + barrier.Size.Width
            Dim barrierBottom As Integer = barrier.Top + barrier.Size.Height
            If characterRight >= barrier.Left And picCharacter.Left <= barrierRight Then
                'The character is beyond this barrier but still within
                If barrier.Top = 0 Then
                    'This is a top barrier
                    If picCharacter.Top <= barrierBottom Then
                        'The character is currently inside of the barrier's bounds
                        handleCollision("barrier")
                    End If
                Else
                    'This is a bottom barrier
                    If characterBottom >= barrier.Top Then
                        'The character is currently inside of the barrier's bounds
                        handleCollision("barrier")
                    End If
                End If
            End If
        Next
        'Check the top and bottom
        If picCharacter.Top <= 0 Then
            handleCollision("top")
        ElseIf characterBottom >= Me.Height Then
            handleCollision("bottom")
        End If
    End Sub
    Private Sub handleCollision(collisionName As String)
        tmrMain.Enabled = False
        MsgBox("Failure. You hit the " & collisionName)
        Dim newInstance As New frmDemo
        newInstance.Show()
        Me.Close()
    End Sub
    Private Sub frmDemo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space Then
            'Toggle the space state
            spaceDown = True
        End If
    End Sub
    Private Sub frmDemo_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Space Then
            'Toggle the space state
            spaceDown = False
        End If
    End Sub
End Class
