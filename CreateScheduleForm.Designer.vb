﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateScheduleForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateScheduleForm))
        Panel1 = New Panel()
        EndTIme = New DateTimePicker()
        StartTime = New DateTimePicker()
        Panel10 = New Panel()
        txt_search = New TextBox()
        Panel9 = New Panel()
        txt_room = New TextBox()
        Panel8 = New Panel()
        txt_building = New TextBox()
        Panel6 = New Panel()
        txt_day = New TextBox()
        Panel4 = New Panel()
        txt_subject = New TextBox()
        Panel3 = New Panel()
        txt_section = New TextBox()
        Panel2 = New Panel()
        txt_Instructor = New TextBox()
        Label8 = New Label()
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label11 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label10 = New Label()
        logo = New PictureBox()
        Label1 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        closeBtn = New PictureBox()
        minimizeBtn = New PictureBox()
        Panel1.SuspendLayout()
        Panel10.SuspendLayout()
        Panel9.SuspendLayout()
        Panel8.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(minimizeBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(222))
        Panel1.Controls.Add(EndTIme)
        Panel1.Controls.Add(StartTime)
        Panel1.Controls.Add(Panel10)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(logo)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(0, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1488, 721)
        Panel1.TabIndex = 0
        ' 
        ' EndTIme
        ' 
        EndTIme.Font = New Font("Calibri", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EndTIme.Format = DateTimePickerFormat.Time
        EndTIme.Location = New Point(444, 404)
        EndTIme.Name = "EndTIme"
        EndTIme.ShowUpDown = True
        EndTIme.Size = New Size(239, 48)
        EndTIme.TabIndex = 35
        ' 
        ' StartTime
        ' 
        StartTime.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        StartTime.CustomFormat = ""
        StartTime.Font = New Font("Calibri", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StartTime.Format = DateTimePickerFormat.Time
        StartTime.Location = New Point(110, 404)
        StartTime.Name = "StartTime"
        StartTime.ShowUpDown = True
        StartTime.Size = New Size(239, 48)
        StartTime.TabIndex = 34
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.LightYellow
        Panel10.BorderStyle = BorderStyle.FixedSingle
        Panel10.Controls.Add(txt_search)
        Panel10.Location = New Point(761, 111)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(573, 50)
        Panel10.TabIndex = 33
        ' 
        ' txt_search
        ' 
        txt_search.BackColor = Color.LightYellow
        txt_search.BorderStyle = BorderStyle.None
        txt_search.CharacterCasing = CharacterCasing.Upper
        txt_search.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_search.Location = New Point(13, 9)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(547, 26)
        txt_search.TabIndex = 0
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.LightYellow
        Panel9.BorderStyle = BorderStyle.FixedSingle
        Panel9.Controls.Add(txt_room)
        Panel9.Location = New Point(110, 578)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(239, 50)
        Panel9.TabIndex = 8
        ' 
        ' txt_room
        ' 
        txt_room.BackColor = Color.LightYellow
        txt_room.BorderStyle = BorderStyle.None
        txt_room.CharacterCasing = CharacterCasing.Upper
        txt_room.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_room.Location = New Point(13, 9)
        txt_room.Name = "txt_room"
        txt_room.Size = New Size(214, 26)
        txt_room.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.LightYellow
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(txt_building)
        Panel8.Location = New Point(444, 497)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(239, 50)
        Panel8.TabIndex = 32
        ' 
        ' txt_building
        ' 
        txt_building.BackColor = Color.LightYellow
        txt_building.BorderStyle = BorderStyle.None
        txt_building.CharacterCasing = CharacterCasing.Upper
        txt_building.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_building.Location = New Point(13, 9)
        txt_building.Name = "txt_building"
        txt_building.Size = New Size(214, 26)
        txt_building.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.LightYellow
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(txt_day)
        Panel6.Location = New Point(110, 497)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(239, 50)
        Panel6.TabIndex = 8
        ' 
        ' txt_day
        ' 
        txt_day.BackColor = Color.LightYellow
        txt_day.BorderStyle = BorderStyle.None
        txt_day.CharacterCasing = CharacterCasing.Upper
        txt_day.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_day.Location = New Point(13, 9)
        txt_day.Name = "txt_day"
        txt_day.Size = New Size(214, 26)
        txt_day.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LightYellow
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(txt_subject)
        Panel4.Location = New Point(110, 309)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(573, 50)
        Panel4.TabIndex = 31
        ' 
        ' txt_subject
        ' 
        txt_subject.BackColor = Color.LightYellow
        txt_subject.BorderStyle = BorderStyle.None
        txt_subject.CharacterCasing = CharacterCasing.Upper
        txt_subject.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_subject.Location = New Point(13, 9)
        txt_subject.Name = "txt_subject"
        txt_subject.Size = New Size(547, 26)
        txt_subject.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightYellow
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txt_section)
        Panel3.Location = New Point(110, 209)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(573, 50)
        Panel3.TabIndex = 30
        ' 
        ' txt_section
        ' 
        txt_section.BackColor = Color.LightYellow
        txt_section.BorderStyle = BorderStyle.None
        txt_section.CharacterCasing = CharacterCasing.Upper
        txt_section.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_section.Location = New Point(13, 9)
        txt_section.Name = "txt_section"
        txt_section.Size = New Size(547, 26)
        txt_section.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightYellow
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txt_Instructor)
        Panel2.Location = New Point(110, 108)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(573, 50)
        Panel2.TabIndex = 29
        ' 
        ' txt_Instructor
        ' 
        txt_Instructor.BackColor = Color.LightYellow
        txt_Instructor.BorderStyle = BorderStyle.None
        txt_Instructor.CharacterCasing = CharacterCasing.Upper
        txt_Instructor.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_Instructor.Location = New Point(13, 9)
        txt_Instructor.Name = "txt_Instructor"
        txt_Instructor.Size = New Size(547, 26)
        txt_Instructor.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label8.Location = New Point(110, 376)
        Label8.Name = "Label8"
        Label8.Size = New Size(104, 25)
        Label8.TabIndex = 27
        Label8.Text = "Start Time"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Location = New Point(761, 173)
        GroupBox2.Margin = New Padding(2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(2)
        GroupBox2.Size = New Size(699, 453)
        GroupBox2.TabIndex = 26
        GroupBox2.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.Location = New Point(24, -10)
        Label7.Name = "Label7"
        Label7.Size = New Size(167, 37)
        Label7.TabIndex = 27
        Label7.Text = "SCHEDULES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(761, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 28)
        Label2.TabIndex = 23
        Label2.Text = "Search"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label6.Location = New Point(444, 461)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 25)
        Label6.TabIndex = 22
        Label6.Text = "Building"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.Location = New Point(110, 550)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 25)
        Label5.TabIndex = 21
        Label5.Text = "Room"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label11.Location = New Point(444, 376)
        Label11.Name = "Label11"
        Label11.Size = New Size(94, 25)
        Label11.TabIndex = 20
        Label11.Text = "End Time"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(110, 464)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 25)
        Label4.TabIndex = 19
        Label4.Text = "Day"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(110, 281)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 25)
        Label3.TabIndex = 18
        Label3.Text = "Subject"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label10.Location = New Point(110, 181)
        Label10.Name = "Label10"
        Label10.Size = New Size(78, 25)
        Label10.TabIndex = 17
        Label10.Text = "Section"
        ' 
        ' logo
        ' 
        logo.BackgroundImage = CType(resources.GetObject("logo.BackgroundImage"), Image)
        logo.BackgroundImageLayout = ImageLayout.Zoom
        logo.Location = New Point(12, 668)
        logo.Name = "logo"
        logo.Size = New Size(57, 43)
        logo.TabIndex = 16
        logo.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(110, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 25)
        Label1.TabIndex = 9
        Label1.Text = "Instructor"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(507, 633)
        Button2.Name = "Button2"
        Button2.Size = New Size(156, 53)
        Button2.TabIndex = 8
        Button2.Text = "Submit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        Button1.BackgroundImage = My.Resources.Resources._434230529_948718966640697_2976062282803324491_n1
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(43, 38)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' closeBtn
        ' 
        closeBtn.BackColor = Color.Transparent
        closeBtn.BackgroundImage = CType(resources.GetObject("closeBtn.BackgroundImage"), Image)
        closeBtn.BackgroundImageLayout = ImageLayout.Stretch
        closeBtn.Cursor = Cursors.Hand
        closeBtn.Location = New Point(1459, 0)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(22, 21)
        closeBtn.TabIndex = 3
        closeBtn.TabStop = False
        ' 
        ' minimizeBtn
        ' 
        minimizeBtn.BackColor = Color.Transparent
        minimizeBtn.BackgroundImage = CType(resources.GetObject("minimizeBtn.BackgroundImage"), Image)
        minimizeBtn.BackgroundImageLayout = ImageLayout.Stretch
        minimizeBtn.Cursor = Cursors.Hand
        minimizeBtn.Location = New Point(1432, 0)
        minimizeBtn.Name = "minimizeBtn"
        minimizeBtn.Size = New Size(22, 21)
        minimizeBtn.TabIndex = 4
        minimizeBtn.TabStop = False
        ' 
        ' CreateScheduleForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(1), CByte(81), CByte(54))
        ClientSize = New Size(1489, 757)
        Controls.Add(minimizeBtn)
        Controls.Add(closeBtn)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "CreateScheduleForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreateScheduleForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(minimizeBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_Instructor As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_subject As TextBox
    Friend WithEvents txt_section As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents minimizeBtn As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txt_building As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_day As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txt_room As TextBox
    Friend WithEvents StartTime As DateTimePicker
    Friend WithEvents EndTIme As DateTimePicker
End Class
