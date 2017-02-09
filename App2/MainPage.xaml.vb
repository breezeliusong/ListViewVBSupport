' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Dim ItemData As List(Of ItemInfo) = New List(Of ItemInfo)

    Private Sub ItemData_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        'this loads the xml, text, or csv data retrieved from auto retrieval but I might need to add in db code for manual or switch to specific archival for manual evaluation
        Dim tmpdata = New ItemInfo()
        tmpdata.aquisitiondate = DateTime.Now
        tmpdata.damaged = "NO"
        tmpdata.evaluationSource = "ebay"
        tmpdata.itempicture = Nothing
        tmpdata.name = "Crazy item"
        tmpdata.price = 78.0
        ItemData.Add(tmpdata)
        'put item data into listview sources below and perform formatting.
        lstItemDataXT.ItemsSource = ItemData
    End Sub
End Class

Public Structure ItemInfo
    Public aquisitiondate As Date
    Public damaged As String
    Public evaluationSource As String
    Public itemid As Integer
    Public itempicture As Byte()
    Public Property name As String
    Public Property price As Double
End Structure
