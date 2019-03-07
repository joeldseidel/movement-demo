Option Strict On
Public Class frmDemo
    Private Sub frmDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initLevel()
    End Sub
    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        onUpdate()
    End Sub
    'Location to start the bird at
    Private characterPosition As Point
    'Listing of all of the barrier image elements
    Private barriers As PictureBox() = {picTop1, picTop2, picBottom1, picBottom2}
    'Listing of all of the barrier elements locations
    Private barrierLocation As List(Of Point)
    Private Sub initLevel()
        'Reset the Position of the character
        characterPosition = New Point(12, 154)
        picCharacter.Location = characterPosition
        barrierLocation = New List(Of Point) From {New Point(227, 0), New Point(381, 0), New Point(222, 227), New Point(381, 227)}
        'Initiate each of the barriers to its original location
        For i As Integer = 0 To barriers.Count Step 1
            'Set a barrier to its corresponding start location
            barriers(i).Location = barrierLocation(i)
        Next
    End Sub
    Private Sub onUpdate()
        'Move the barriers
        updateBarriers()
        'Move the character
        updateCharacter()
    End Sub
    'The amount of X pixels to move per fixed update
    Private Const horizontalSpeed As Integer = 5
    'The amount of Y pixels to move per fixed update
    Private Const verticalSpeed As Integer = 10
    Private Sub updateBarriers()
        For Each barrier As PictureBox In barriers
            barrier.Location = New Point(barrier.Location.X + horizontalSpeed, barrier.Location.Y)
            'Add the current barriers location to the position list
            barrierLocation.Add(barrier.Location)
        Next
    End Sub
    Private spaceDown As Boolean = False
    Private Sub updateCharacter()
        Dim appliedVertSpeed As Integer = verticalSpeed
        If Not spaceDown Then
            'Apply gravity - multiply the up speed by -1
            appliedVertSpeed *= -1
        End If
        characterPosition.Y = characterPosition.Y + appliedVertSpeed
        picCharacter.Location = characterPosition
    End Sub

    Private Sub frmDemo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space Then
            'Toggle the space state
            spaceDown = Not spaceDown
        End If
    End Sub
End Class
