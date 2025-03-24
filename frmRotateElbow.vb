Imports Inventor

Public Class frmRotateElbow
    Public oldPartAngle As Double
    Public newPartAngle As Double
    Public oEnterclick As Boolean = False
    Dim pi = Math.Acos(-1)
    Dim oRotateByAngle


    Private Sub frmRotateElbow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TopMost = True
        oldPartAngle = FormPiping.oElbowInsertAngle
        CbxTurnByAngle.SelectedIndex = 5
        oRotateByAngle = 45

    End Sub




    Private Sub RotateElbowByNewValues()


        If FormPiping.oOrient = "XYaxis" Then

            Dim asmDoc As Inventor.AssemblyDocument
            Dim oElbowInsertAngle As Double
            oElbowInsertAngle = newPartAngle
            asmDoc = FormPiping.oInvApp.ActiveDocument
            Try
                FormPiping.elbowOcc.Constraints.Item(1).Delete()
                Call asmDoc.ComponentDefinition.Constraints.AddAngleConstraint(asmDoc.ComponentDefinition.WorkPlanes(3), FormPiping.oPartAglePlaneProxy, oElbowInsertAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try
            oldPartAngle = oElbowInsertAngle
        End If

        If FormPiping.oOrient = "XZaxis" Then

            Dim asmDoc As Inventor.AssemblyDocument
            Dim oElbowInsertAngle As Double
            oElbowInsertAngle = newPartAngle
            asmDoc = FormPiping.oInvApp.ActiveDocument
            Try
                FormPiping.elbowOcc.Constraints.Item(1).Delete()
                Call asmDoc.ComponentDefinition.Constraints.AddAngleConstraint(asmDoc.ComponentDefinition.WorkPlanes(2), FormPiping.oPartAglePlaneProxy, oElbowInsertAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try
            oldPartAngle = oElbowInsertAngle
        End If

        If FormPiping.oOrient = "YZaxis" Then

            Dim asmDoc As Inventor.AssemblyDocument
            Dim oElbowInsertAngle As Double
            oElbowInsertAngle = newPartAngle
            asmDoc = FormPiping.oInvApp.ActiveDocument
            Try
                FormPiping.elbowOcc.Constraints.Item(1).Delete()
                Call asmDoc.ComponentDefinition.Constraints.AddAngleConstraint(asmDoc.ComponentDefinition.WorkPlanes(1), FormPiping.oPartAglePlaneProxy, oElbowInsertAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try
            oldPartAngle = oElbowInsertAngle
        End If


    End Sub



    Private Sub btnTurnPos_Click(sender As Object, e As EventArgs) Handles btnTurnPos.Click
        oEnterclick = False
        newPartAngle = oldPartAngle + (oRotateByAngle * pi / 180)
        If newPartAngle >= (360 * pi / 180) Then
            newPartAngle = 0
        End If
        If newPartAngle <= (-360 * pi / 180) Then
            newPartAngle = 0
        End If
        RotateElbowByNewValues()
    End Sub

    Private Sub btnTurnNeg_Click(sender As Object, e As EventArgs) Handles btnTurnNeg.Click
        oEnterclick = False
        newPartAngle = oldPartAngle - (oRotateByAngle * pi / 180)
        If newPartAngle >= (360 * pi / 180) Then
            newPartAngle = 0
        End If
        If newPartAngle <= (-360 * pi / 180) Then
            newPartAngle = 0
        End If
        RotateElbowByNewValues()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        oEnterclick = True
        Close()
    End Sub

    Private Sub CbxTurnByAngle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxTurnByAngle.SelectedIndexChanged
        oRotateByAngle = CbxTurnByAngle.Text
    End Sub


End Class