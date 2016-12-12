<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restock
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongDescriptionNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CIS3113WayPitStopDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CIS_311_3WayPitStopDBDataSet = New GroupProject1.CIS_311_3WayPitStopDBDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCheckItem = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.ItemsTableAdapter = New GroupProject1.CIS_311_3WayPitStopDBDataSetTableAdapters.ItemsTableAdapter()
        Me.btnSell = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIS3113WayPitStopDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIS_311_3WayPitStopDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.BarCodeDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.LongDescriptionNameDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 179)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 46
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
        Me.ItemsBindingSource.DataSource = Me.CIS3113WayPitStopDBDataSetBindingSource
        '
        'CIS3113WayPitStopDBDataSetBindingSource
        '
        Me.CIS3113WayPitStopDBDataSetBindingSource.DataSource = Me.CIS_311_3WayPitStopDBDataSet
        Me.CIS3113WayPitStopDBDataSetBindingSource.Position = 0
        '
        'CIS_311_3WayPitStopDBDataSet
        '
        Me.CIS_311_3WayPitStopDBDataSet.DataSetName = "CIS_311_3WayPitStopDBDataSet"
        Me.CIS_311_3WayPitStopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 142)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 26)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 30)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "View Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(12, 47)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(112, 53)
        Me.btnAddItem.TabIndex = 43
        Me.btnAddItem.Text = "New Product"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(153, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 14)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Scan the barcode into this text box"
        '
        'btnCheckItem
        '
        Me.btnCheckItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckItem.Location = New System.Drawing.Point(639, 80)
        Me.btnCheckItem.Name = "btnCheckItem"
        Me.btnCheckItem.Size = New System.Drawing.Size(47, 42)
        Me.btnCheckItem.TabIndex = 41
        Me.btnCheckItem.Text = "Check Item"
        Me.btnCheckItem.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(137, 80)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(496, 42)
        Me.lblDescription.TabIndex = 40
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(464, 121)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(222, 52)
        Me.btnSubmit.TabIndex = 39
        Me.btnSubmit.Text = "Restock!"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 42)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "QTY:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(237, 125)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(91, 48)
        Me.txtQuantity.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 40)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "BARCODE:"
        '
        'txtBarCode
        '
        Me.txtBarCode.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarCode.Location = New System.Drawing.Point(334, 14)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(352, 63)
        Me.txtBarCode.TabIndex = 34
        Me.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'btnSell
        '
        Me.btnSell.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSell.Location = New System.Drawing.Point(12, 6)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(112, 35)
        Me.btnSell.TabIndex = 47
        Me.btnSell.Text = "Sell"
        Me.btnSell.UseVisualStyleBackColor = True
        '
        'Restock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 183)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSell)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCheckItem)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBarCode)
        Me.Name = "Restock"
        Me.Text = "Restock"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIS3113WayPitStopDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIS_311_3WayPitStopDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCheckItem As System.Windows.Forms.Button
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents CIS3113WayPitStopDBDataSetBindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents btnSell As System.Windows.Forms.Button
End Class
