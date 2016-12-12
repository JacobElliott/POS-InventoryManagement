Public Class SellingPoint

    Private Sub lblDescription_Click(sender As Object, e As EventArgs) Handles lblDescription.Click

    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
        ProductInput.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        ProductInput.Close()
        Restock.Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If IsNumeric(txtQuantity.Text) And txtQuantity.Text > 0 Then

                Dim intQtyBegin As Integer
                Dim intQtySold As Integer
                Dim intQtyEnd As Integer
                Dim strBarcode As String
                intQtySold = 0
                intQtySold = txtQuantity.Text
                strBarcode = txtBarCode.Text

                For Each Row In CIS_311_3WayPitStopDBDataSet.Items.Rows
                    If strBarcode = Row.BarCode Then
                        intQtyBegin = Row.Stock
                        intQtyEnd = intQtyBegin - intQtySold
                        Row.Stock = intQtyEnd
                    End If
                Next
                'intQtyEnd = intQtyBegin - intQtySold

                Me.ItemsBindingSource.EndEdit()
                Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
                txtBarCode.Clear()
                txtQuantity.Clear()
                lblDescription.Text = String.Empty

            Else
                MessageBox.Show("Please enter a numeric value grater than 0!")
            End If
        Catch
            MessageBox.Show("Please enter a numeric value grater than 0!")
        End Try

        If txtBarCode.Text.Length <= 12 Then

        Else
            MessageBox.Show("Please enter a valid barcode!")
        End If



    End Sub

    Private Sub btnCheckItem_Click(sender As Object, e As EventArgs) Handles btnCheckItem.Click
        Dim strBarcode As String
        strBarcode = txtBarCode.Text
        Dim Row As CIS_311_3WayPitStopDBDataSet.ItemsRow
        For Each Row In CIS_311_3WayPitStopDBDataSet.Items.Rows
            If strBarcode = Row.BarCode Then
                lblDescription.Text = Row._Long_Description_Name_
            Else
                'MessageBox.Show("Please provide a bar code that is in the system")
            End If

        Next
        'lblDescription.Text = String.Empty
        'Me.ItemsTableAdapter.Fill(CIS_311_3WayPitStopDBDataSet.Items)
        'Dim Row As CIS_311_3WayPitStopDBDataSet.ItemsRow
        'lblDescription.Text = Row._Long_Description_Name_
        'ItemsTableAdapter.LongDescriptionQ(CIS_311_3WayPitStopDBDataSet.Items, txtBarCode.Text)
        'lblDescription.Refresh()

        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
    End Sub

    Private Sub SellingPoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CIS_311_3WayPitStopDBDataSet1.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.CIS_311_3WayPitStopDBDataSet1.Items)
        'TODO: This line of code loads data into the 'CIS_311_3WayPitStopDBDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.CIS_311_3WayPitStopDBDataSet.Items)

        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
    End Sub
    
    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        Me.ItemsBindingSource.EndEdit()
        Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
        Restock.Show()
        Me.Hide()

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged

    End Sub

    Private Sub chkFree_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree.CheckedChanged



        Try
            If IsNumeric(txtQuantity.Text) And txtQuantity.Text > 0 Then
                MessageBox.Show("You have chosen to donate the item!")
                Dim intQtyBegin As Integer
                Dim intQtySold As Integer
                Dim intQtyEnd As Integer
                Dim strBarcode As String
                intQtySold = 0
                intQtySold = txtQuantity.Text
                strBarcode = txtBarCode.Text

                For Each Row In CIS_311_3WayPitStopDBDataSet.Items.Rows
                    If strBarcode = Row.BarCode Then
                        intQtyBegin = Row.Stock
                        intQtyEnd = intQtyBegin - intQtySold
                        Row.Stock = intQtyEnd
                    End If
                Next
                'intQtyEnd = intQtyBegin - intQtySold

                Me.ItemsBindingSource.EndEdit()
                Me.ItemsTableAdapter.Update(CIS_311_3WayPitStopDBDataSet.Items)
                txtBarCode.Clear()
                txtQuantity.Clear()
                lblDescription.Text = String.Empty

            Else
                MessageBox.Show("Please enter a numeric value grater than 0!")
            End If
        Catch
            MessageBox.Show("Please enter a numeric value grater than 0!")
        End Try

        If txtBarCode.Text.Length <= 12 Then

        Else
            MessageBox.Show("Please enter a valid barcode!")
        End If


    End Sub
End Class
