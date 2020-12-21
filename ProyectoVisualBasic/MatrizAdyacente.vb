Public Class MatrizAdyacente
    Private grafo As List(Of NodoGrafo) = New List(Of NodoGrafo)()
    Public Sub New(ByVal gr As List(Of NodoGrafo))
        InitializeComponent()
        grafo = gr
    End Sub
    Private Sub MatrizAdyacente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataGridView1.ColumnCount = 0
        dataGridView1.ColumnCount = grafo.Count
        dataGridView1.RowCount = 1
        dataGridView1.RowCount = grafo.Count

        For i As Integer = 0 To grafo.Count - 1
            dataGridView1.Columns(i).Name = i.ToString()
        Next

        For i As Integer = 0 To grafo.Count - 1

            For j As Integer = 0 To grafo.Count - 1
                dataGridView1.Rows(i).Cells(j).Value = 0
            Next
        Next

        For i As Integer = 0 To grafo.Count - 1

            For j As Integer = 0 To grafo(i).aristas.Count() - 1
                dataGridView1.Rows(i).Cells(grafo(i).aristas(j).getDestino()).Value = 1
            Next
        Next
    End Sub
End Class