<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellingPoint
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
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.chkFree = New System.Windows.Forms.CheckBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CIS_311_3WayPitStopDBDataSet = New GroupProject1.CIS_311_3WayPitStopDBDataSet()
        Me.btnCheckItem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongDescriptionNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsTableAdapter = New GroupProject1.CIS_311_3WayPitStopDBDataSetTableAdapters.ItemsTableAdapter()
        Me.CIS_311_3WayPitStopDBDataSet1 = New GroupProject1.CIS_311_3WayPitStopDBDataSet()
        Me.ItemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnRestock = New System.Windows.Forms.Button()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIS_311_3WayPitStopDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIS_311_3WayPitStopDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBarCode
        '
        Me.txtBarCode.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarCode.Location = New System.Drawing.Point(334, 9)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(352, 63)
        Me.txtBarCode.TabIndex = 0
        Me.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BARCODE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 42)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "QTY:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(237, 120)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(91, 48)
        Me.txtQuantity.TabIndex = 2
        '
        'chkFree
        '
        Me.chkFree.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkFree.AutoSize = True
        Me.chkFree.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFree.Location = New System.Drawing.Point(334, 116)
        Me.chkFree.Name = "chkFree"
        Me.chkFree.Size = New System.Drawing.Size(124, 52)
        Me.chkFree.TabIndex = 4
        Me.chkFree.Text = "Free?"
        Me.chkFree.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(464, 116)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(222, 52)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Sell!"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(137, 75)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(496, 42)
        Me.lblDescription.TabIndex = 6
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'btnCheckItem
        '
        Me.btnCheckItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckItem.Location = New System.Drawing.Point(639, 75)
        Me.btnCheckItem.Name = "btnCheckItem"
        Me.btnCheckItem.Size = New System.Drawing.Size(47, 42)
        Me.btnCheckItem.TabIndex = 7
        Me.btnCheckItem.Text = "Check Item"
        Me.btnCheckItem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(153, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Scan the barcode into this text box"
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(12, 7)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(112, 56)
        Me.btnAddItem.TabIndex = 9
        Me.btnAddItem.Text = "New Product"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 31)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "View Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 141)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 27)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.BarCodeDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.LongDescriptionNameDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(181, 203)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 33
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
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'CIS_311_3WayPitStopDBDataSet1
        '
        Me.CIS_311_3WayPitStopDBDataSet1.DataSetName = "CIS_311_3WayPitStopDBDataSet"
        Me.CIS_311_3WayPitStopDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsBindingSource1
        '
        Me.ItemsBindingSource1.DataMember = "Items"
        Me.ItemsBindingSource1.DataSource = Me.CIS_311_3WayPitStopDBDataSet1
        '
        'btnRestock
        '
        Me.btnRestock.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestock.Location = New System.Drawing.Point(12, 69)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.Size = New System.Drawing.Size(112, 29)
        Me.btnRestock.TabIndex = 34
        Me.btnRestock.Text = "Restock"
        Me.btnRestock.UseVisualStyleBackColor = True
        '
        'SellingPoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 176)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRestock)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCheckItem)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.chkFree)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBarCode)
        Me.Name = "SellingPoint"
        Me.Text = "Point of Purchase"
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIS_311_3WayPitStopDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIS_311_3WayPitStopDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents chkFree As System.Windows.Forms.CheckBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents btnCheckItem As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
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
    Friend WithEvents CIS_311_3WayPitStopDBDataSet1 As GroupProject1.CIS_311_3WayPitStopDBDataSet
    Friend WithEvents ItemsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btnRestock As System.Windows.Forms.Button

End Class
