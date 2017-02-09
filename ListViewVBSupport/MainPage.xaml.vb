' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Public Property ItemData As ObservableCollection(Of ItemInfo)
    Dim archivepath As String = Windows.Storage.ApplicationData.Current.LocalFolder.Path

End Class

Public Structure ItemInfo
    Public aquisitiondate As Date
    Public damaged As String
    Public evaluationSource As String
    Public itemid As Integer
    Public itempicture As Byte()
    Public name As String
    Public price As Double
End Structure
