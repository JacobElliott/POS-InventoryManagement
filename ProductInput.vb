Public Class ProductInput

    Private Sub btnSellItems_Click(sender As Object, e As EventArgs) Handles btnSellItem.Click
        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
        SellingPoint.Show()
        Me.Hide()
    End Sub

    Private Sub btnData_Click(sender As Object, e As EventArgs) Handles btnData.Click
        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
        DataPage.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
        Me.Close()
        DataPage.Close()
        SellingPoint.Close()
        Restock.Close()
    End Sub

    Private Sub btnAddToDB_Click(sender As Object, e As EventArgs) Handles btnAddToDB.Click

        Try
            If txtBarCode.TextLength > 0 And txtCategory.TextLength > 0 And txtItemDescription.TextLength > 0 And txtPrice.TextLength > 0 And txtQuantity.TextLength > 0 Then
                Me.ItemsTableAdapter.Insert(Today, txtBarCode.Text, txtPrice.Text, txtItemDescription.Text, txtCategory.Text, txtQuantity.Text)

                Me.ItemsBindingSource.EndEdit()
                Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)

                txtBarCode.Text = ""
                txtCategory.Text = ""
                txtItemDescription.Text = ""
                txtPrice.Text = ""
                txtQuantity.Text = ""
            Else
                MessageBox.Show("Please enter a product in order to Modify the DB!", "Error!")
            End If

        Catch
        End Try


    End Sub

    Private Sub ProductInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CIS_311_3WayPitStopDBDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.CIS_311_3WayPitStopDBDataSet.Items)

    End Sub

    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
        Restock.Show()
        Me.Hide()
    End Sub

    Private Sub txtItemDescription_TextChanged(sender As Object, e As EventArgs) Handles txtItemDescription.TextChanged

    End Sub
End Class