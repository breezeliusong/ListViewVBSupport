' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Public Property ItemData As ObservableCollection(Of ItemInfo) = New ObservableCollection(Of ItemInfo)

    Private Sub Page_Loaded(sender As Object, e As RoutedEventArgs)
        'this loads the xml, text, or csv data retrieved from auto retrieval but I might need to add in db code for manual or switch to specific archival for manual evaluation
        Dim ItemData = New ObservableCollection(Of ItemInfo)

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
    Public Property aquisitiondate As Date
    Public Property damaged As String
    Public evaluationSource As String
    Public itemid As Integer
    Public itempicture As Byte()
    Public Property name As String
    Public Property price As Double
End Structure
