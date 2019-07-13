<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lvwCar = New System.Windows.Forms.ListView()
        Me.chNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMake.Location = New System.Drawing.Point(68, 71)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(51, 23)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "Make:"
        '
        'lblModel
        '
        Me.lblModel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModel.Location = New System.Drawing.Point(68, 122)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(41, 15)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Model:"
        '
        'lblYear
        '
        Me.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYear.Location = New System.Drawing.Point(68, 171)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(41, 15)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "Year:"
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Location = New System.Drawing.Point(68, 225)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(41, 15)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "Price:"
        '
        'cmbMake
        '
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Honda", "Kia ", "GMC", "Hyundai"})
        Me.cmbMake.Location = New System.Drawing.Point(153, 65)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 21)
        Me.cmbMake.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmbMake, "Please select the make of the car.")
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.cmbYear.Location = New System.Drawing.Point(153, 168)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbYear.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.cmbYear, "Please select the year")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(153, 117)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 20)
        Me.txtModel.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtModel, "please enter the model.")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(153, 225)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtPrice, "Please eneter the price")
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(68, 271)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(51, 17)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "New:"
        Me.ToolTip1.SetToolTip(Me.chkNew, "Please enter if the car is new")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lvwCar
        '
        Me.lvwCar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNew, Me.chID, Me.chMake, Me.chModel, Me.chYear, Me.chPrice})
        Me.lvwCar.Location = New System.Drawing.Point(68, 294)
        Me.lvwCar.Name = "lvwCar"
        Me.lvwCar.Size = New System.Drawing.Size(371, 180)
        Me.lvwCar.TabIndex = 9
        Me.lvwCar.UseCompatibleStateImageBehavior = False
        Me.lvwCar.View = System.Windows.Forms.View.Details
        '
        'chNew
        '
        Me.chNew.Text = "New"
        '
        'chID
        '
        Me.chID.Text = "ID"
        '
        'chMake
        '
        Me.chMake.Text = "Make"
        '
        'chModel
        '
        Me.chModel.Text = "Model"
        '
        'chYear
        '
        Me.chYear.Text = "Year"
        '
        'chPrice
        '
        Me.chPrice.Text = "Price"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(74, 580)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "E&nter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "click to enter the data ")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(231, 580)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "R&eset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "click the button to reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(364, 580)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Please enter the button to exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(69, 490)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(370, 74)
        Me.lblResult.TabIndex = 10
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(463, 640)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lvwCar)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lvwCar As ListView
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents chNew As ColumnHeader
    Friend WithEvents chID As ColumnHeader
    Friend WithEvents chMake As ColumnHeader
    Friend WithEvents chModel As ColumnHeader
    Friend WithEvents chYear As ColumnHeader
    Friend WithEvents chPrice As ColumnHeader
    Friend WithEvents ToolTip1 As ToolTip
End Class
