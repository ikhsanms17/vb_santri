<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class index
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Private WithEvents dataGridView As DataGridView
    Private WithEvents btnTambah As Button
    Private WithEvents txtSearch As TextBox
    Private WithEvents lblTitle As Label
    Private WithEvents panelHeader As Panel

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.panelHeader = New System.Windows.Forms.Panel()

        ' Form settings
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Beige

        ' Panel Header
        Me.panelHeader.Dock = DockStyle.Top
        Me.panelHeader.Height = 60
        Me.panelHeader.BackColor = Color.White
        Controls.Add(Me.panelHeader)

        ' Label Title
        Me.lblTitle.Text = "Data Users"
        Me.lblTitle.Font = New Font("Arial", 14, FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.panelHeader.Controls.Add(Me.lblTitle)

        ' Button Tambah Data
        Me.btnTambah.Text = "+ Tambah Data"
        Me.btnTambah.Font = New Font("Arial", 10, FontStyle.Bold)
        Me.btnTambah.BackColor = Color.Green
        Me.btnTambah.ForeColor = Color.White
        Me.btnTambah.Location = New System.Drawing.Point(20, 80)
        Me.btnTambah.Size = New System.Drawing.Size(120, 35)
        Controls.Add(Me.btnTambah)

        ' Search Box
        Me.txtSearch.Location = New System.Drawing.Point(Me.ClientSize.Width - 220, 85)
        Me.txtSearch.Size = New System.Drawing.Size(200, 25)
        Controls.Add(Me.txtSearch)
        AddHandler txtSearch.TextChanged, AddressOf SearchData

        ' DataGridView settings
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.dataGridView.Location = New System.Drawing.Point(20, 130)
        Me.dataGridView.Size = New System.Drawing.Size(Me.ClientSize.Width - 40, Me.ClientSize.Height - 150)
        Me.dataGridView.BackgroundColor = Color.White
        Me.dataGridView.DefaultCellStyle.BackColor = Color.Beige
        Me.dataGridView.DefaultCellStyle.Font = New Font("Arial", 12)
        Me.dataGridView.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 14, FontStyle.Bold)
        Me.dataGridView.AllowUserToResizeColumns = False
        Me.dataGridView.AllowUserToResizeRows = False
        Me.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridView.ReadOnly = True ' Semua data hanya-baca
        Controls.Add(Me.dataGridView)

        ' Form settings
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Name = "index"
        Text = "Data Users"
        ResumeLayout(False)
        PerformLayout()

        ' Event Handlers
        AddHandler Me.Load, AddressOf index_Load
        AddHandler Me.Resize, AddressOf index_Resize
    End Sub

    Private Sub index_Resize(sender As Object, e As EventArgs)
        If dataGridView IsNot Nothing Then
            dataGridView.Size = New System.Drawing.Size(Me.ClientSize.Width - 40, Me.ClientSize.Height - 150)
            txtSearch.Location = New System.Drawing.Point(Me.ClientSize.Width - 220, 85)
        End If
    End Sub
End Class
