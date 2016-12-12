Public Class DataPage

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
        ProductInput.Show()
        Me.Hide()
    End Sub

    Private Sub btnSellItem_Click(sender As Object, e As EventArgs) Handles btnSellItem.Click
        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
        SellingPoint.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
        Me.Close()
        SellingPoint.Close()
        ProductInput.Close()
    End Sub

    Private Sub btnCategoryFilter_Click(sender As Object, e As EventArgs) Handles btnCategoryFilter.Click

        Try
            If txtCategory.TextLength > 0 Then
                Me.ItemsTableAdapter.DescriptionSearchQ(CIS_311_3WayPitStopDBDataSet.Items, txtCategory.Text)
            Else
                MessageBox.Show("Please enter a character that you would like to search!", "Error")
            End If
        Catch
        End Try
    End Sub

    Private Sub DataPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CIS_311_3WayPitStopDBDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.CIS_311_3WayPitStopDBDataSet.Items)
        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
    End Sub

    Private Sub btnFilterDescription_Click(sender As Object, e As EventArgs) Handles btnFilterDescription.Click
        Try
            If txtItemDescription.TextLength > 0 Then
                Me.ItemsTableAdapter.LongDescriptionQ(CIS_311_3WayPitStopDBDataSet.Items, txtItemDescription.Text)
            Else
                MessageBox.Show("Please enter a character that you would like to search!", "Error")
            End If
        Catch
        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If txtBarCode.TextLength > 0 Then
                Me.ItemsTableAdapter.BarcodeSearchQ(CIS_311_3WayPitStopDBDataSet.Items, txtBarCode.Text)
            Else
                MessageBox.Show("Please enter a barcode in order to search!", "Error")
            End If
        Catch
        End Try
    End Sub

    Private Sub btnFilterStock_Click(sender As Object, e As EventArgs) Handles btnFilterStock.Click

        Try
            If radLessThan.Checked = True Then
                Me.ItemsTableAdapter.StockLessThanQ(CIS_311_3WayPitStopDBDataSet.Items, txtQuantity.Text)
            ElseIf radGreaterThan.Checked = True Then
                Me.ItemsTableAdapter.StockGraterThanQ(CIS_311_3WayPitStopDBDataSet.Items, txtQuantity.Text)
            ElseIf radEqualTo.Checked = True Then
                Me.ItemsTableAdapter.StockEqualToQ(CIS_311_3WayPitStopDBDataSet.Items, txtQuantity.Text)
            End If
        Catch
            MessageBox.Show("Please enter a value in order to display the information!", "Error")
        End Try



    End Sub

    Private Sub btnCalcDisplayed_Click(sender As Object, e As EventArgs) Handles btnCalcDisplayed.Click

        Dim decTotal As Decimal
        Dim row As CIS_311_3WayPitStopDBDataSet.ItemsRow

        For Each row In CIS_311_3WayPitStopDBDataSet.Items.Rows
            decTotal += row.Price * row.Stock
        Next

        lblTotalDisplayed.Text = decTotal.ToString("C")

    End Sub



    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click
        Me.ItemsTableAdapter.Fill(CIS_311_3WayPitStopDBDataSet.Items)

    End Sub

    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
        Restock.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class