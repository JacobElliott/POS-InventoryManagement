<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPage
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
        Me.CIS_311_3WayPitStopDBDataSet = New GroupProject1.CIS_311_3WayPitStopDBDataSet()
        Me.btnSellItem = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.btnCategoryFilter = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.btnFilterDescription = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radEqualTo = New System.Windows.Forms.RadioButton()
        Me.btnFilterStock = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radGreaterThan = New System.Windows.Forms.RadioButton()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.radLessThan = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTotalDisplayed = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalcDisplayed = New System.Windows.Forms.Button()
        Me.btnDisplayAll = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ItemsTableAdapter = New GroupProject1.CIS_311_3WayPitStopDBDataSetTableAdapters.ItemsTableAdapter()
        Me.ItemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnRestock = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIS_311_3WayPitStopDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.BarCodeDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.LongDescriptionNameDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(864, 137)
        Me.DataGridView1.TabIndex = 0
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
        'btnSellItem
        '
        Me.btnSellItem.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSellItem.Location = New System.Drawing.Point(12, 10)
        Me.btnSellItem.Name = "btnSellItem"
        Me.btnSellItem.Size = New System.Drawing.Size(112, 68)
        Me.btnSellItem.TabIndex = 23
        Me.btnSellItem.Text = "Sell Item"
        Me.btnSellItem.UseVisualStyleBackColor = True
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(12, 84)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(112, 37)
        Me.btnAddItem.TabIndex = 24
        Me.btnAddItem.Text = "New Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.btnCategoryFilter)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(130, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 85)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Category Search"
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(6, 30)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(177, 41)
        Me.txtCategory.TabIndex = 26
        Me.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCategoryFilter
        '
        Me.btnCategoryFilter.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoryFilter.Location = New System.Drawing.Point(189, 25)
        Me.btnCategoryFilter.Name = "btnCategoryFilter"
        Me.btnCategoryFilter.Size = New System.Drawing.Size(98, 48)
        Me.btnCategoryFilter.TabIndex = 23
        Me.btnCategoryFilter.Text = "Filter"
        Me.btnCategoryFilter.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtItemDescription)
        Me.GroupBox2.Controls.Add(Me.btnFilterDescription)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(130, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 98)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Description Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Search for all or part of an item's description here"
        '
        'txtItemDescription
        '
        Me.txtItemDescription.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDescription.Location = New System.Drawing.Point(6, 25)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(177, 41)
        Me.txtItemDescription.TabIndex = 24
        Me.txtItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFilterDescription
        '
        Me.btnFilterDescription.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilterDescription.Location = New System.Drawing.Point(189, 25)
        Me.btnFilterDescription.Name = "btnFilterDescription"
        Me.btnFilterDescription.Size = New System.Drawing.Size(98, 41)
        Me.btnFilterDescription.TabIndex = 23
        Me.btnFilterDescription.Text = "Filter"
        Me.btnFilterDescription.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radEqualTo)
        Me.GroupBox3.Controls.Add(Me.btnFilterStock)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.radGreaterThan)
        Me.GroupBox3.Controls.Add(Me.txtQuantity)
        Me.GroupBox3.Controls.Add(Me.radLessThan)
        Me.GroupBox3.Location = New System.Drawing.Point(429, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 101)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock"
        '
        'radEqualTo
        '
        Me.radEqualTo.AutoSize = True
        Me.radEqualTo.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEqualTo.Location = New System.Drawing.Point(153, 65)
        Me.radEqualTo.Name = "radEqualTo"
        Me.radEqualTo.Size = New System.Drawing.Size(49, 36)
        Me.radEqualTo.TabIndex = 27
        Me.radEqualTo.TabStop = True
        Me.radEqualTo.Text = "="
        Me.radEqualTo.UseVisualStyleBackColor = True
        '
        'btnFilterStock
        '
        Me.btnFilterStock.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilterStock.Location = New System.Drawing.Point(12, 54)
        Me.btnFilterStock.Name = "btnFilterStock"
        Me.btnFilterStock.Size = New System.Drawing.Size(135, 41)
        Me.btnFilterStock.TabIndex = 26
        Me.btnFilterStock.Text = "Filter"
        Me.btnFilterStock.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 32)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "QTY:"
        '
        'radGreaterThan
        '
        Me.radGreaterThan.AutoSize = True
        Me.radGreaterThan.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGreaterThan.Location = New System.Drawing.Point(153, 40)
        Me.radGreaterThan.Name = "radGreaterThan"
        Me.radGreaterThan.Size = New System.Drawing.Size(49, 36)
        Me.radGreaterThan.TabIndex = 1
        Me.radGreaterThan.TabStop = True
        Me.radGreaterThan.Text = ">"
        Me.radGreaterThan.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(89, 13)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(58, 35)
        Me.txtQuantity.TabIndex = 14
        '
        'radLessThan
        '
        Me.radLessThan.AutoSize = True
        Me.radLessThan.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLessThan.Location = New System.Drawing.Point(153, 9)
        Me.radLessThan.Name = "radLessThan"
        Me.radLessThan.Size = New System.Drawing.Size(49, 36)
        Me.radLessThan.TabIndex = 0
        Me.radLessThan.TabStop = True
        Me.radLessThan.Text = "<"
        Me.radLessThan.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTotalDisplayed)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.btnCalcDisplayed)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(645, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(231, 72)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total Cost of Displayed Items"
        '
        'lblTotalDisplayed
        '
        Me.lblTotalDisplayed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalDisplayed.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDisplayed.Location = New System.Drawing.Point(12, 22)
        Me.lblTotalDisplayed.Name = "lblTotalDisplayed"
        Me.lblTotalDisplayed.Size = New System.Drawing.Size(106, 28)
        Me.lblTotalDisplayed.TabIndex = 28
        Me.lblTotalDisplayed.Text = "$$$"
        Me.lblTotalDisplayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Multiply Displayed qty by price in loop"
        '
        'btnCalcDisplayed
        '
        Me.btnCalcDisplayed.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcDisplayed.Location = New System.Drawing.Point(124, 22)
        Me.btnCalcDisplayed.Name = "btnCalcDisplayed"
        Me.btnCalcDisplayed.Size = New System.Drawing.Size(98, 28)
        Me.btnCalcDisplayed.TabIndex = 23
        Me.btnCalcDisplayed.Text = "Calculate"
        Me.btnCalcDisplayed.UseVisualStyleBackColor = True
        '
        'btnDisplayAll
        '
        Me.btnDisplayAll.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayAll.Location = New System.Drawing.Point(645, 160)
        Me.btnDisplayAll.Name = "btnDisplayAll"
        Me.btnDisplayAll.Size = New System.Drawing.Size(231, 34)
        Me.btnDisplayAll.TabIndex = 30
        Me.btnDisplayAll.Text = "Display All Items"
        Me.btnDisplayAll.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtBarCode)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(429, 121)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(210, 74)
        Me.GroupBox6.TabIndex = 27
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Barcode Search"
        '
        'txtBarCode
        '
        Me.txtBarCode.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarCode.Location = New System.Drawing.Point(6, 25)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(115, 35)
        Me.txtBarCode.TabIndex = 24
        Me.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(127, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 35)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Filter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 29)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'ItemsBindingSource1
        '
        Me.ItemsBindingSource1.DataMember = "Items"
        Me.ItemsBindingSource1.DataSource = Me.CIS_311_3WayPitStopDBDataSet
        '
        'btnRestock
        '
        Me.btnRestock.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestock.Location = New System.Drawing.Point(12, 127)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.Size = New System.Drawing.Size(112, 29)
        Me.btnRestock.TabIndex = 32
        Me.btnRestock.Text = "Restock"
        Me.btnRestock.UseVisualStyleBackColor = True
        '
        'DataPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRestock)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.btnDisplayAll)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnSellItem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DataPage"
        Me.Text = "Data Page"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIS_311_3WayPitStopDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSellItem As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCategoryFilter As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFilterDescription As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radGreaterThan As System.Windows.Forms.RadioButton
    Friend WithEvents radLessThan As System.Windows.Forms.RadioButton
    Friend WithEvents radEqualTo As System.Windows.Forms.RadioButton
    Friend WithEvents btnFilterStock As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalDisplayed As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCalcDisplayed As System.Windows.Forms.Button
    Friend WithEvents btnDisplayAll As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
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
    Friend WithEvents txtItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents ItemsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents btnRestock As System.Windows.Forms.Button
End Class
