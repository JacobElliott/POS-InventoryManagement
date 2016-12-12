<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductInput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddToDB = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.btnData = New System.Windows.Forms.Button()
        Me.btnSellItem = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongDescriptionNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CIS_311_3WayPitStopDBDataSet = New GroupProject1.CIS_311_3WayPitStopDBDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ItemsTableAdapter = New GroupProject1.CIS_311_3WayPitStopDBDataSetTableAdapters.ItemsTableAdapter()
        Me.TableAdapterManager1 = New GroupProject1.CIS_311_3WayPitStopDBDataSetTableAdapters.TableAdapterManager()
        Me.btnRestock = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIS_311_3WayPitStopDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 14)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Scan the barcode into this text box"
        '
        'btnAddToDB
        '
        Me.btnAddToDB.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToDB.Location = New System.Drawing.Point(601, 118)
        Me.btnAddToDB.Name = "btnAddToDB"
        Me.btnAddToDB.Size = New System.Drawing.Size(86, 102)
        Me.btnAddToDB.TabIndex = 15
        Me.btnAddToDB.Text = "Add Item"
        Me.btnAddToDB.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 42)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "QTY:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(238, 119)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(91, 48)
        Me.txtQuantity.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 40)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "BARCODE:"
        '
        'txtBarCode
        '
        Me.txtBarCode.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarCode.Location = New System.Drawing.Point(335, 6)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(352, 63)
        Me.txtBarCode.TabIndex = 10
        Me.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtItemDescription
        '
        Me.txtItemDescription.AllowDrop = True
        Me.txtItemDescription.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDescription.Location = New System.Drawing.Point(249, 75)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(438, 41)
        Me.txtItemDescription.TabIndex = 20
        Me.txtItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnData
        '
        Me.btnData.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnData.Location = New System.Drawing.Point(12, 75)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(112, 62)
        Me.btnData.TabIndex = 23
        Me.btnData.Text = "View Data"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'btnSellItem
        '
        Me.btnSellItem.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSellItem.Location = New System.Drawing.Point(12, 6)
        Me.btnSellItem.Name = "btnSellItem"
        Me.btnSellItem.Size = New System.Drawing.Size(112, 63)
        Me.btnSellItem.TabIndex = 22
        Me.btnSellItem.Text = "Sell Items"
        Me.btnSellItem.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(13, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(313, 172)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(282, 48)
        Me.txtCategory.TabIndex = 33
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.BarCodeDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.LongDescriptionNameDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(130, 219)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 30)
        Me.DataGridView1.TabIndex = 34
        Me.DataGridView1.Visible = False
        '
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'BarCodeDataGridViewTextBoxColumn
        '
        Me.BarCodeDataGridViewTextBoxColumn.DataPropertyName = "BarCode"
        Me.BarCodeDataGridViewTextBoxColumn.HeaderText = "BarCode"
        Me.BarCodeDataGridViewTextBoxColumn.Name = "BarCodeDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'LongDescriptionNameDataGridViewTextBoxColumn
        '
        Me.LongDescriptionNameDataGridViewTextBoxColumn.DataPropertyName = "Long_Description(Name)"
        Me.LongDescriptionNameDataGridViewTextBoxColumn.HeaderText = "Long_Description(Name)"
        Me.LongDescriptionNameDataGridViewTextBoxColumn.Name = "LongDescriptionNameDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.CIS_311_3WayPitStopDBDataSet
        '
        'CIS_311_3WayPitStopDBDataSet
        '
        Me.CIS_311_3WayPitStopDBDataSet.DataSetName = "CIS_311_3WayPitStopDBDataSet"
        Me.CIS_311_3WayPitStopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(335, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 42)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(452, 118)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(143, 48)
        Me.txtPrice.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(131, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 42)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Category:"
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ItemsTableAdapter = Me.ItemsTableAdapter
        Me.TableAdapterManager1.UpdateOrder = GroupProject1.CIS_311_3WayPitStopDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnRestock
        '
        Me.btnRestock.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestock.Location = New System.Drawing.Point(13, 143)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.Size = New System.Drawing.Size(112, 36)
        Me.btnRestock.TabIndex = 38
        Me.btnRestock.Text = "Restock"
        Me.btnRestock.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(131, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 40)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Detail:"
        '
        'ProductInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRestock)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnData)
        Me.Controls.Add(Me.btnSellItem)
        Me.Controls.Add(Me.txtItemDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAddToDB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBarCode)
        Me.Name = "ProductInput"
        Me.Text = "Product Input"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIS_311_3WayPitStopDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAddToDB As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnData As System.Windows.Forms.Button
    Friend WithEvents btnSellItem As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CIS_311_3WayPitStopDBDataSet As GroupProject1.CIS_311_3WayPitStopDBDataSet
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsTableAdapter As GroupProject1.CIS_311_3WayPitStopDBDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BarCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LongDescriptionNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager1 As GroupProject1.CIS_311_3WayPitStopDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnRestock As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
