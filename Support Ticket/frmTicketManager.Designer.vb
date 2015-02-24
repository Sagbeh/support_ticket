<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketManager
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
        Me.txtTicketReporter = New System.Windows.Forms.TextBox()
        Me.txtTicketIssue = New System.Windows.Forms.TextBox()
        Me.lstTicketList = New System.Windows.Forms.ListBox()
        Me.btnAddTicket = New System.Windows.Forms.Button()
        Me.btnDeleteTicket = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numTicketSeverity = New System.Windows.Forms.NumericUpDown()
        CType(Me.numTicketSeverity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTicketReporter
        '
        Me.txtTicketReporter.Location = New System.Drawing.Point(143, 12)
        Me.txtTicketReporter.Name = "txtTicketReporter"
        Me.txtTicketReporter.Size = New System.Drawing.Size(100, 20)
        Me.txtTicketReporter.TabIndex = 0
        '
        'txtTicketIssue
        '
        Me.txtTicketIssue.Location = New System.Drawing.Point(143, 67)
        Me.txtTicketIssue.Name = "txtTicketIssue"
        Me.txtTicketIssue.Size = New System.Drawing.Size(100, 20)
        Me.txtTicketIssue.TabIndex = 1
        '
        'lstTicketList
        '
        Me.lstTicketList.FormattingEnabled = True
        Me.lstTicketList.Location = New System.Drawing.Point(3, 191)
        Me.lstTicketList.Name = "lstTicketList"
        Me.lstTicketList.Size = New System.Drawing.Size(501, 186)
        Me.lstTicketList.TabIndex = 2
        '
        'btnAddTicket
        '
        Me.btnAddTicket.Location = New System.Drawing.Point(282, 12)
        Me.btnAddTicket.Name = "btnAddTicket"
        Me.btnAddTicket.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTicket.TabIndex = 3
        Me.btnAddTicket.Text = "Add"
        Me.btnAddTicket.UseVisualStyleBackColor = True
        '
        'btnDeleteTicket
        '
        Me.btnDeleteTicket.Location = New System.Drawing.Point(282, 67)
        Me.btnDeleteTicket.Name = "btnDeleteTicket"
        Me.btnDeleteTicket.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteTicket.TabIndex = 4
        Me.btnDeleteTicket.Text = "Delete"
        Me.btnDeleteTicket.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Severity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Issue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Reporter"
        '
        'numTicketSeverity
        '
        Me.numTicketSeverity.Location = New System.Drawing.Point(143, 120)
        Me.numTicketSeverity.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numTicketSeverity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTicketSeverity.Name = "numTicketSeverity"
        Me.numTicketSeverity.Size = New System.Drawing.Size(120, 20)
        Me.numTicketSeverity.TabIndex = 8
        Me.numTicketSeverity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmTicketManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 394)
        Me.Controls.Add(Me.numTicketSeverity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeleteTicket)
        Me.Controls.Add(Me.btnAddTicket)
        Me.Controls.Add(Me.lstTicketList)
        Me.Controls.Add(Me.txtTicketIssue)
        Me.Controls.Add(Me.txtTicketReporter)
        Me.Name = "frmTicketManager"
        Me.Text = "Form1"
        CType(Me.numTicketSeverity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTicketReporter As System.Windows.Forms.TextBox
    Friend WithEvents txtTicketIssue As System.Windows.Forms.TextBox
    Friend WithEvents lstTicketList As System.Windows.Forms.ListBox
    Friend WithEvents btnAddTicket As System.Windows.Forms.Button
    Friend WithEvents btnDeleteTicket As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numTicketSeverity As System.Windows.Forms.NumericUpDown

End Class
