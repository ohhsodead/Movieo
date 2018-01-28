Imports System.Runtime.InteropServices

Public Class AddonTextboxWatermark
    Inherits TextBox

    Private NotInheritable Class NativeMethods
        Private Sub New()
        End Sub

        Private Const ECM_FIRST As UInteger = &H1500
        Friend Const EM_SETCUEBANNER As UInteger = ECM_FIRST + 1

        <DllImport("user32.dll", EntryPoint:="SendMessageW")>
        Public Shared Function SendMessageW(hWnd As IntPtr, Msg As UInt32, wParam As IntPtr, <MarshalAs(UnmanagedType.LPWStr)> lParam As String) As IntPtr
        End Function
    End Class

    Private _watermark As String
    Public Property Watermark() As String
        Get
            Return _watermark
        End Get
        Set(value As String)
            _watermark = value
            UpdateWatermark()
        End Set
    End Property

    Private Sub UpdateWatermark()
        If IsHandleCreated AndAlso _watermark IsNot Nothing Then
            NativeMethods.SendMessageW(Handle, NativeMethods.EM_SETCUEBANNER, CType(1, IntPtr), _watermark)
        End If
    End Sub

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        UpdateWatermark()
    End Sub

End Class