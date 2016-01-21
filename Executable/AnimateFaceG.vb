Imports System
Imports System.IO
Friend Class AnimateFaceG
    Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents VisemePicture As System.Windows.Forms.PictureBox
    Public WithEvents chkShowEvents As System.Windows.Forms.CheckBox
    Public WithEvents chkSpFlagNLPSpeakPunc As System.Windows.Forms.CheckBox
    Public WithEvents chkSpFlagAync As System.Windows.Forms.CheckBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents AudioOutputCB As System.Windows.Forms.ComboBox
    Public WithEvents MainTxtBox As System.Windows.Forms.TextBox
    Public WithEvents MouthImgList As AxMSComctlLib.AxImageList
    Public WithEvents DebugTxtBox As System.Windows.Forms.TextBox
    Public WithEvents ComDlg As AxMSComDlg.AxCommonDialog
    Public WithEvents FormatCB As System.Windows.Forms.ComboBox
    Public WithEvents RateSldr As AxMSComctlLib.AxSlider
    Public WithEvents VoiceCB As System.Windows.Forms.ComboBox
    Public WithEvents VolumeSldr As AxMSComctlLib.AxSlider
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents menuFileSpeakWave As System.Windows.Forms.MenuItem
    Public WithEvents menuFileSaveToWave As System.Windows.Forms.MenuItem
    Public WithEvents menuSep As System.Windows.Forms.MenuItem
    Public WithEvents menuFileExit As System.Windows.Forms.MenuItem
    Public WithEvents menuFile As System.Windows.Forms.MenuItem
    Public MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents menuFileOpenText As System.Windows.Forms.MenuItem
    Public WithEvents SpeakBtn As System.Windows.Forms.Button
    Public WithEvents PauseBtn As System.Windows.Forms.Button
    Public WithEvents SkipBtn As System.Windows.Forms.Button
    Public WithEvents ResetBtn As System.Windows.Forms.Button
    Public WithEvents StopBtn As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mnuBack As System.Windows.Forms.MenuItem
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnimateFaceG))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkShowEvents = New System.Windows.Forms.CheckBox
        Me.chkSpFlagNLPSpeakPunc = New System.Windows.Forms.CheckBox
        Me.chkSpFlagAync = New System.Windows.Forms.CheckBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.AudioOutputCB = New System.Windows.Forms.ComboBox
        Me.MainTxtBox = New System.Windows.Forms.TextBox
        Me.DebugTxtBox = New System.Windows.Forms.TextBox
        Me.FormatCB = New System.Windows.Forms.ComboBox
        Me.VoiceCB = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.menuFile = New System.Windows.Forms.MenuItem
        Me.menuFileSpeakWave = New System.Windows.Forms.MenuItem
        Me.menuFileSaveToWave = New System.Windows.Forms.MenuItem
        Me.menuFileOpenText = New System.Windows.Forms.MenuItem
        Me.mnuBack = New System.Windows.Forms.MenuItem
        Me.menuSep = New System.Windows.Forms.MenuItem
        Me.menuFileExit = New System.Windows.Forms.MenuItem
        Me.ComDlg = New AxMSComDlg.AxCommonDialog
        Me.SpeakBtn = New System.Windows.Forms.Button
        Me.PauseBtn = New System.Windows.Forms.Button
        Me.SkipBtn = New System.Windows.Forms.Button
        Me.ResetBtn = New System.Windows.Forms.Button
        Me.StopBtn = New System.Windows.Forms.Button
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.VisemePicture = New System.Windows.Forms.PictureBox
        Me.MouthImgList = New AxMSComctlLib.AxImageList
        Me.RateSldr = New AxMSComctlLib.AxSlider
        Me.VolumeSldr = New AxMSComctlLib.AxSlider
        Me.Frame1.SuspendLayout()
        CType(Me.ComDlg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VisemePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MouthImgList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RateSldr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeSldr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkShowEvents
        '
        Me.chkShowEvents.BackColor = System.Drawing.Color.White
        Me.chkShowEvents.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkShowEvents.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowEvents.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkShowEvents.Location = New System.Drawing.Point(33, 45)
        Me.chkShowEvents.Name = "chkShowEvents"
        Me.chkShowEvents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkShowEvents.Size = New System.Drawing.Size(98, 16)
        Me.chkShowEvents.TabIndex = 25
        Me.chkShowEvents.Text = "Show Events"
        Me.chkShowEvents.UseVisualStyleBackColor = False
        '
        'chkSpFlagNLPSpeakPunc
        '
        Me.chkSpFlagNLPSpeakPunc.BackColor = System.Drawing.Color.White
        Me.chkSpFlagNLPSpeakPunc.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSpFlagNLPSpeakPunc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpFlagNLPSpeakPunc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSpFlagNLPSpeakPunc.Location = New System.Drawing.Point(33, 67)
        Me.chkSpFlagNLPSpeakPunc.Name = "chkSpFlagNLPSpeakPunc"
        Me.chkSpFlagNLPSpeakPunc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSpFlagNLPSpeakPunc.Size = New System.Drawing.Size(105, 21)
        Me.chkSpFlagNLPSpeakPunc.TabIndex = 24
        Me.chkSpFlagNLPSpeakPunc.Text = "NLPSpeakPunc"
        Me.chkSpFlagNLPSpeakPunc.UseVisualStyleBackColor = False
        '
        'chkSpFlagAync
        '
        Me.chkSpFlagAync.BackColor = System.Drawing.Color.White
        Me.chkSpFlagAync.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSpFlagAync.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpFlagAync.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSpFlagAync.Location = New System.Drawing.Point(32, 19)
        Me.chkSpFlagAync.Name = "chkSpFlagAync"
        Me.chkSpFlagAync.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSpFlagAync.Size = New System.Drawing.Size(98, 20)
        Me.chkSpFlagAync.TabIndex = 20
        Me.chkSpFlagAync.Text = "FlagsAsync"
        Me.chkSpFlagAync.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.White
        Me.Frame1.Controls.Add(Me.chkShowEvents)
        Me.Frame1.Controls.Add(Me.chkSpFlagAync)
        Me.Frame1.Controls.Add(Me.chkSpFlagNLPSpeakPunc)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(245, 343)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(147, 105)
        Me.Frame1.TabIndex = 18
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Speak Flags"
        '
        'AudioOutputCB
        '
        Me.AudioOutputCB.BackColor = System.Drawing.SystemColors.Window
        Me.AudioOutputCB.Cursor = System.Windows.Forms.Cursors.Default
        Me.AudioOutputCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AudioOutputCB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudioOutputCB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AudioOutputCB.Location = New System.Drawing.Point(61, 467)
        Me.AudioOutputCB.Name = "AudioOutputCB"
        Me.AudioOutputCB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AudioOutputCB.Size = New System.Drawing.Size(177, 22)
        Me.AudioOutputCB.TabIndex = 17
        '
        'MainTxtBox
        '
        Me.MainTxtBox.AcceptsReturn = True
        Me.MainTxtBox.BackColor = System.Drawing.SystemColors.Window
        Me.MainTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MainTxtBox.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTxtBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MainTxtBox.HideSelection = False
        Me.MainTxtBox.Location = New System.Drawing.Point(6, 255)
        Me.MainTxtBox.MaxLength = 0
        Me.MainTxtBox.Multiline = True
        Me.MainTxtBox.Name = "MainTxtBox"
        Me.MainTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MainTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MainTxtBox.Size = New System.Drawing.Size(391, 85)
        Me.MainTxtBox.TabIndex = 0
        Me.MainTxtBox.Text = "Enter the text here"
        '
        'DebugTxtBox
        '
        Me.DebugTxtBox.AcceptsReturn = True
        Me.DebugTxtBox.BackColor = System.Drawing.Color.White
        Me.DebugTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DebugTxtBox.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DebugTxtBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DebugTxtBox.Location = New System.Drawing.Point(12, 499)
        Me.DebugTxtBox.MaxLength = 0
        Me.DebugTxtBox.Multiline = True
        Me.DebugTxtBox.Name = "DebugTxtBox"
        Me.DebugTxtBox.ReadOnly = True
        Me.DebugTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DebugTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DebugTxtBox.Size = New System.Drawing.Size(385, 108)
        Me.DebugTxtBox.TabIndex = 26
        Me.DebugTxtBox.WordWrap = False
        '
        'FormatCB
        '
        Me.FormatCB.BackColor = System.Drawing.SystemColors.Window
        Me.FormatCB.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FormatCB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormatCB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormatCB.Location = New System.Drawing.Point(61, 435)
        Me.FormatCB.Name = "FormatCB"
        Me.FormatCB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FormatCB.Size = New System.Drawing.Size(177, 22)
        Me.FormatCB.TabIndex = 15
        '
        'VoiceCB
        '
        Me.VoiceCB.BackColor = System.Drawing.SystemColors.Window
        Me.VoiceCB.Cursor = System.Windows.Forms.Cursors.Default
        Me.VoiceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VoiceCB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoiceCB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.VoiceCB.Location = New System.Drawing.Point(61, 347)
        Me.VoiceCB.Name = "VoiceCB"
        Me.VoiceCB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VoiceCB.Size = New System.Drawing.Size(177, 22)
        Me.VoiceCB.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(9, 468)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(41, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Audio Output"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(9, 437)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Format"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 407)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Volume"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(9, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Rate"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(9, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Voice"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFile})
        '
        'menuFile
        '
        Me.menuFile.Index = 0
        Me.menuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFileSpeakWave, Me.menuFileSaveToWave, Me.menuFileOpenText, Me.mnuBack, Me.menuSep, Me.menuFileExit})
        Me.menuFile.Text = "File"
        '
        'menuFileSpeakWave
        '
        Me.menuFileSpeakWave.Index = 0
        Me.menuFileSpeakWave.Shortcut = System.Windows.Forms.Shortcut.CtrlW
        Me.menuFileSpeakWave.Text = "Speak Wave File"
        Me.menuFileSpeakWave.Visible = False
        '
        'menuFileSaveToWave
        '
        Me.menuFileSaveToWave.Index = 1
        Me.menuFileSaveToWave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.menuFileSaveToWave.Text = "Save To Wave File"
        '
        'menuFileOpenText
        '
        Me.menuFileOpenText.Index = 2
        Me.menuFileOpenText.Text = "Open Text File"
        '
        'mnuBack
        '
        Me.mnuBack.Index = 3
        Me.mnuBack.Text = "Back"
        '
        'menuSep
        '
        Me.menuSep.Index = 4
        Me.menuSep.Text = "-"
        '
        'menuFileExit
        '
        Me.menuFileExit.Index = 5
        Me.menuFileExit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
        Me.menuFileExit.Text = "Quit"
        '
        'ComDlg
        '
        Me.ComDlg.Enabled = True
        Me.ComDlg.Location = New System.Drawing.Point(290, 449)
        Me.ComDlg.Name = "ComDlg"
        Me.ComDlg.OcxState = CType(resources.GetObject("ComDlg.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ComDlg.Size = New System.Drawing.Size(32, 32)
        Me.ComDlg.TabIndex = 29
        '
        'SpeakBtn
        '
        Me.SpeakBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpeakBtn.BackColor = System.Drawing.Color.White
        Me.SpeakBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.SpeakBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeakBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SpeakBtn.Location = New System.Drawing.Point(2, 9)
        Me.SpeakBtn.Name = "SpeakBtn"
        Me.SpeakBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SpeakBtn.Size = New System.Drawing.Size(71, 32)
        Me.SpeakBtn.TabIndex = 1
        Me.SpeakBtn.Text = "Speak"
        Me.SpeakBtn.UseVisualStyleBackColor = False
        '
        'PauseBtn
        '
        Me.PauseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PauseBtn.BackColor = System.Drawing.Color.White
        Me.PauseBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.PauseBtn.Enabled = False
        Me.PauseBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PauseBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PauseBtn.Location = New System.Drawing.Point(130, 9)
        Me.PauseBtn.Name = "PauseBtn"
        Me.PauseBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PauseBtn.Size = New System.Drawing.Size(80, 32)
        Me.PauseBtn.TabIndex = 3
        Me.PauseBtn.Text = "Pause"
        Me.PauseBtn.UseVisualStyleBackColor = False
        '
        'SkipBtn
        '
        Me.SkipBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SkipBtn.BackColor = System.Drawing.Color.White
        Me.SkipBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.SkipBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkipBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SkipBtn.Location = New System.Drawing.Point(276, 9)
        Me.SkipBtn.Name = "SkipBtn"
        Me.SkipBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SkipBtn.Size = New System.Drawing.Size(64, 32)
        Me.SkipBtn.TabIndex = 4
        Me.SkipBtn.Text = "Skip"
        Me.SkipBtn.UseVisualStyleBackColor = False
        Me.SkipBtn.Visible = False
        '
        'ResetBtn
        '
        Me.ResetBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResetBtn.BackColor = System.Drawing.Color.White
        Me.ResetBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ResetBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetBtn.Location = New System.Drawing.Point(206, 9)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ResetBtn.Size = New System.Drawing.Size(72, 32)
        Me.ResetBtn.TabIndex = 7
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'StopBtn
        '
        Me.StopBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopBtn.BackColor = System.Drawing.Color.White
        Me.StopBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.StopBtn.Enabled = False
        Me.StopBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StopBtn.Location = New System.Drawing.Point(67, 9)
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StopBtn.Size = New System.Drawing.Size(67, 32)
        Me.StopBtn.TabIndex = 2
        Me.StopBtn.Text = "Stop"
        Me.StopBtn.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.Location = New System.Drawing.Point(342, 16)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDown1.TabIndex = 30
        Me.NumericUpDown1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.SpeakBtn)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.StopBtn)
        Me.GroupBox1.Controls.Add(Me.PauseBtn)
        Me.GroupBox1.Controls.Add(Me.ResetBtn)
        Me.GroupBox1.Controls.Add(Me.SkipBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 614)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 47)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'VisemePicture
        '
        Me.VisemePicture.BackColor = System.Drawing.Color.Black
        Me.VisemePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.VisemePicture.Cursor = System.Windows.Forms.Cursors.Default
        Me.VisemePicture.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisemePicture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VisemePicture.Location = New System.Drawing.Point(7, 0)
        Me.VisemePicture.Name = "VisemePicture"
        Me.VisemePicture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VisemePicture.Size = New System.Drawing.Size(391, 250)
        Me.VisemePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VisemePicture.TabIndex = 27
        Me.VisemePicture.TabStop = False
        '
        'MouthImgList
        '
        Me.MouthImgList.Enabled = True
        Me.MouthImgList.Location = New System.Drawing.Point(349, 449)
        Me.MouthImgList.Name = "MouthImgList"
        Me.MouthImgList.OcxState = CType(resources.GetObject("MouthImgList.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MouthImgList.Size = New System.Drawing.Size(38, 38)
        Me.MouthImgList.TabIndex = 28
        '
        'RateSldr
        '
        Me.RateSldr.Location = New System.Drawing.Point(61, 379)
        Me.RateSldr.Name = "RateSldr"
        Me.RateSldr.OcxState = CType(resources.GetObject("RateSldr.OcxState"), System.Windows.Forms.AxHost.State)
        Me.RateSldr.Size = New System.Drawing.Size(177, 17)
        Me.RateSldr.TabIndex = 11
        '
        'VolumeSldr
        '
        Me.VolumeSldr.Location = New System.Drawing.Point(61, 411)
        Me.VolumeSldr.Name = "VolumeSldr"
        Me.VolumeSldr.OcxState = CType(resources.GetObject("VolumeSldr.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VolumeSldr.Size = New System.Drawing.Size(177, 14)
        Me.VolumeSldr.TabIndex = 13
        '
        'AnimateFaceG
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(406, 671)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VisemePicture)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.AudioOutputCB)
        Me.Controls.Add(Me.MainTxtBox)
        Me.Controls.Add(Me.DebugTxtBox)
        Me.Controls.Add(Me.MouthImgList)
        Me.Controls.Add(Me.ComDlg)
        Me.Controls.Add(Me.FormatCB)
        Me.Controls.Add(Me.RateSldr)
        Me.Controls.Add(Me.VoiceCB)
        Me.Controls.Add(Me.VolumeSldr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(223, 243)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "AnimateFaceG"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnimationGM"
        Me.Frame1.ResumeLayout(False)
        CType(Me.ComDlg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.VisemePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MouthImgList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RateSldr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeSldr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private Shared m_vb6FormDefInstance As AnimateFaceG
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As AnimateFaceG
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New AnimateFaceG
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As AnimateFaceG)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
#Region "InterOp Services "

#End Region

    ' First, declare the main SAPI object we are using in this sample. It is
    ' created inside Form_Load and released inside Form_Unload.
    Dim WithEvents Voice As SpeechLib.SpVoice

    ' Speak flags is a combination of bit flags. These individual bits correspond
    ' to check boxes on the UI. So m_speakFlags should always be kept in sync
    ' with the state of those check boxes.
    Dim m_speakFlags As SpeechLib.SpeechVoiceSpeakFlags

    ' This is the default format we will use.
    Const DefaultFmt As String = "SAFT22kHz16BitMono"

    ' We will disable the output combo box and show this if there's no audio output.
    Const NoAudioOutput As String = "No audio ouput object available"

    ' We will enable/disable menu items and buttons based on current state
    ' m_speaking indicates whether a speak task is in progress
    ' m_paused indicates whether Voice.Pause is called
    Private m_bSpeaking As Boolean
    Private m_bPaused As Boolean

    Private Sub AnimateFaceG_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        On Error GoTo ErrHandler

        ' Creates the voice object first
        Voice = New SpeechLib.SpVoice

        ' Load the voices combo box
        Dim Token As SpeechLib.ISpeechObjectToken

        For Each Token In Voice.GetVoices
            VoiceCB.Items.Add((Token.GetDescription()))
        Next Token
        VoiceCB.SelectedIndex = 0
        VoiceCB.Enabled = False
        If VoiceCB.Items.IsReadOnly = True Then
        End If
        'load the format combo box
        AddItemToFmtCB()

        ' set rate and volume to the same as the Voice
        RateSldr.Value = Voice.Rate
        VolumeSldr.Value = Voice.Volume

        'set the default format
        FormatCB.Text = DefaultFmt

        ' Load the audio output combo box
        If Voice.GetAudioOutputs.Count > 0 Then
            For Each Token In Voice.GetAudioOutputs
                AudioOutputCB.Items.Add((Token.GetDescription))
            Next Token
        Else
            AudioOutputCB.Items.Add(NoAudioOutput)
            AudioOutputCB.Enabled = False
        End If
        AudioOutputCB.SelectedIndex = 0

        'load image list
        LoadMouthImages()

        MouthImgList.MaskColor = System.Drawing.Color.Magenta
        MouthImgList.BackColor = System.Drawing.ColorTranslator.FromOle(GetSysColor(COLOR_3DFACE))
        VisemePicture.Image = MouthImgList.Overlay("MICFULL", "MICFULL")

        ' init speak flags and sync flag check boxes
        m_speakFlags = SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync Or SpeechLib.SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak Or SpeechLib.SpeechVoiceSpeakFlags.SVSFIsXML
        chkSpFlagAync.CheckState = System.Windows.Forms.CheckState.Checked

        SetSpeakingState(False, False)
        Exit Sub

ErrHandler:
        MsgBox("Error in initialization: " & vbCrLf & vbCrLf & Err.Description & vbCrLf & vbCrLf & "Shutting down.", MsgBoxStyle.OkOnly, "AnimateFace")
        Voice = Nothing
        End
    End Sub

    Private Sub AnimateFaceMain_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        Voice = Nothing
    End Sub

    Private Sub AudioOutputCB_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AudioOutputCB.SelectedIndexChanged
        On Error GoTo ErrHandler

        ' change the output to the selected one
        Voice.AudioOutput = Voice.GetAudioOutputs().Item(AudioOutputCB.SelectedIndex)

        ' changing output may have also changed the format, so call function
        ' FormatCB_Click to make sure we are using the format as selected
        FormatCB_SelectedIndexChanged(FormatCB, New System.EventArgs)
        Exit Sub

ErrHandler:
        AddDebugInfo("Set audio output error: ", Err.Description)
    End Sub

    Private Sub FormatCB_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles FormatCB.SelectedIndexChanged
        On Error GoTo ErrHandler

        ' Note: AllowAudioOutputFormatChangesOnNextSet is a hidden property, VB
        ' object browser doesn't show it by default. To see it, you can go to
        ' VB object viewer, right click and turn on the "show hidden members".
        Voice.AllowAudioOutputFormatChangesOnNextSet = False

        ' The format Type is associated with the selected list item as a long.
        Voice.AudioOutputStream.Format.Type = VB6.GetItemData(FormatCB, FormatCB.SelectedIndex)

        ' Currently you have to call this so that SAPI picks up the new format.
        Voice.AudioOutputStream = Voice.AudioOutputStream

        Exit Sub

ErrHandler:
        AddDebugInfo("Set format error: ", Err.Description)
    End Sub

    Public Sub menuAbout_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        menuAbout_Click(eventSender, eventArgs)
    End Sub
    Public Sub menuAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        MsgBox("AnimateFace" & vbCrLf & vbCrLf & "", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "About AnimateFace")
    End Sub

    Public Sub menuFileExit_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles menuFileExit.Popup
        menuFileExit_Click(eventSender, eventArgs)
    End Sub
    Public Sub menuFileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles menuFileExit.Click
        AnimateFaceG.DefInstance.Close()
        End
    End Sub

    Public Sub menuFileOpenText_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        menuFileOpenText_Click(eventSender, eventArgs)
    End Sub


    Public Sub menuFileSaveToWave_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles menuFileSaveToWave.Popup
        menuFileSaveToWave_Click(eventSender, eventArgs)
    End Sub
    Public Sub menuFileSaveToWave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles menuFileSaveToWave.Click
        ' Set CancelError is True
        ComDlg.CancelError = True
        On Error GoTo ErrHandler

        ' Set flags
        ComDlg.Flags = MSComDlg.FileOpenConstants.cdlOFNOverwritePrompt Or MSComDlg.FileOpenConstants.cdlOFNPathMustExist Or MSComDlg.FileOpenConstants.cdlOFNNoReadOnlyReturn
        ' Set Dialog title
        ComDlg.DialogTitle = "Save to a Wave File"
        ' Set filters
        ComDlg.Filter = "All Files (*.*)|*.*|Wave Files " & "(*.wav)|*.wav"
        ' Specify default filter
        ComDlg.FilterIndex = 2
        ' Display the Open dialog box
        ComDlg.ShowSave()

        ' create a wave stream
        Dim cpFileStream As New SpeechLib.SpFileStream

        ' Set output format to selected format
        cpFileStream.Format.Type = VB6.GetItemData(FormatCB, FormatCB.SelectedIndex)

        ' Open the file for write
        cpFileStream.Open(ComDlg.FileName, SpeechLib.SpeechStreamFileMode.SSFMCreateForWrite, False)

        ' Set output stream to the file stream
        Voice.AllowAudioOutputFormatChangesOnNextSet = False
        Voice.AudioOutputStream = cpFileStream

        ' show action
        AddDebugInfo("Save to .wav file")

        ' speak the given text with given flags
        Voice.Speak(MainTxtBox.Text, m_speakFlags)

        ' wait until it's done speaking with a really really long timeout.
        ' the tiemout value is in unit of millisecond. -1 means forever.
        Voice.WaitUntilDone(-1)

        ' Since the output stream was set to the file stream, we need to
        ' set back to the selected audio output by calling AudioOutputCB_Click
        ' as if user just changed it through UI
        AudioOutputCB_SelectedIndexChanged(AudioOutputCB, New System.EventArgs)

        ' close the file stream
        cpFileStream.Close()
        cpFileStream = Nothing

        MsgBox("WAV file successfully written!", MsgBoxStyle.OkOnly, "File Saved")
        Exit Sub

ErrHandler:
        'User pressed the Cancel button, do not show error
        If Not (Err.Number = 32755) Then
            AddDebugInfo("Save to Wave file Error: ", Err.Description)
        End If

        If Not cpFileStream Is Nothing Then
            cpFileStream = Nothing
        End If
    End Sub

    Public Sub menuFileSpeakWave_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles menuFileSpeakWave.Popup
        menuFileSpeakWave_Click(eventSender, eventArgs)
    End Sub
    Public Sub menuFileSpeakWave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles menuFileSpeakWave.Click
        ' Set CancelError is True
        ComDlg.CancelError = True
        On Error GoTo ErrHandler
        ' Set flags
        ComDlg.Flags = MSComDlg.FileOpenConstants.cdlOFNFileMustExist Or MSComDlg.FileOpenConstants.cdlOFNPathMustExist
        ' Set Dialog title
        ComDlg.DialogTitle = "Speak a Wave File"
        ' Set filters
        ComDlg.Filter = "Wave Files " & "(*.wav)|*.wav"
        ' Specify default filter
        ComDlg.FilterIndex = 2
        ' Display the Open dialog box
        ComDlg.ShowOpen()

        AddDebugInfo("Speak .wav file")

        ' Speak the contents of the wavefile. Notice here we are passing in the
        ' file name so the filename flag is set.
        MainTxtBox.Text = ComDlg.FileName
        SpeakBtn_Click(SpeakBtn, New System.EventArgs)

        Exit Sub

ErrHandler:
        'User pressed the Cancel button, do not show error
        If Not (Err.Number = 32755) Then
            AddDebugInfo("Speak Wave Error: ", Err.Description)
        End If

        SetSpeakingState(False, m_bPaused)
        Exit Sub
    End Sub

    Private Sub PauseBtn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PauseBtn.Click
        Select Case PauseBtn.Text
            Case "Pause"
                AddDebugInfo("Pause")
                Voice.Pause()
                SetSpeakingState(m_bSpeaking, True)

            Case "Resume"
                AddDebugInfo("Resume")
                Voice.Resume()
                SetSpeakingState(m_bSpeaking, False)
        End Select
    End Sub

    Private Sub RateSldr_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RateSldr.Scroll
        Voice.Rate = RateSldr.Value
    End Sub

    Private Sub ResetBtn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ResetBtn.Click
        'set output to default
        AudioOutputCB.SelectedIndex = 0
        Voice.AudioOutput = Nothing

        'use default voice
        VoiceCB.SelectedIndex = 0
        'Format to default
        FormatCB.Text = DefaultFmt

        'reset main text field
        MainTxtBox.Text = "Enter the text here"

        'reset volume and rate
        VolumeSldr.Value = 100
        VolumeSldr_Scroll(VolumeSldr, New System.EventArgs)

        RateSldr.Value = 0
        RateSldr_Scroll(RateSldr, New System.EventArgs)

        ' reset speak flags
        m_speakFlags = SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync Or SpeechLib.SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak Or SpeechLib.SpeechVoiceSpeakFlags.SVSFIsXML
        chkSpFlagAync.CheckState = System.Windows.Forms.CheckState.Checked
        chkSpFlagNLPSpeakPunc.CheckState = System.Windows.Forms.CheckState.Unchecked

        'reset DebugTxtbox text
        DebugTxtBox.Text = CStr(Nothing)

        'reset skip text box
        NumericUpDown1.Text = "0"
        VisemePicture.Image = MouthImgList.Overlay("MICFULL", "MICFULL")

        ' if it's paused, call Resume to reset state
        If m_bPaused Then Voice.Resume()

        SetSpeakingState(False, False)
    End Sub

    Private Sub SkipBtn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SkipBtn.Click
        On Error GoTo ErrHandler
        Dim SkipType As String
        Dim SkipNum As Short

        AddDebugInfo("Skip")

        ' skip by the number specified
        SkipNum = CShort(NumericUpDown1.Text)
        SkipType = "Sentence"

        Voice.Skip(SkipType, SkipNum)
        Exit Sub

ErrHandler:
        'MsgBox Err.Description & ":" & Err.Number, vbOKOnly, "Skip Error"
        AddDebugInfo("Skip Error: ", Err.Description)
        Exit Sub
    End Sub

    Private Sub SpeakBtn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SpeakBtn.Click

        Me.Size = New System.Drawing.Size(400, 300)


        On Error GoTo ErrHandler


        AddDebugInfo(("Speak"))

        ' exit if there's nothing to speak
        If MainTxtBox.Text = "" Then
            Exit Sub
        End If

        ' If it's paused and some text still remains to be spoken, Speak button
        ' acts the same as Resume button. However a programmer can choose to
        ' speak from the beginning again or any other behavior.
        ' In other cases, we speak the text with given flags.
        If Not (m_bPaused And m_bSpeaking) Then
            ' just speak the text with the given flags
            Voice.Speak(MainTxtBox.Text, m_speakFlags)
        End If

        ' Resume if Voice is paused
        If m_bPaused Then Voice.Resume()

        ' set the state of menu items and buttons
        SetSpeakingState(True, False)
        Exit Sub

ErrHandler:
        AddDebugInfo("Speak Error: ", Err.Description)
        SetSpeakingState(False, m_bPaused)
    End Sub

    Private Sub StopBtn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles StopBtn.Click
        On Error GoTo ErrHandler
        AddDebugInfo(("Stop"))

        ' when string to speak is NULL and dwFlags is set to SPF_PURGEBEFORESPEAK
        ' it indicates to SAPI that any remaining data to be synthesized should
        ' be discarded.
        Voice.Speak(vbNullString, SpeechLib.SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak)
        If m_bPaused Then Voice.Resume()

        SetSpeakingState(False, False)
        Exit Sub

ErrHandler:
        AddDebugInfo("Speak Error: ", Err.Description)
    End Sub

    Private Sub Voice_AudioLevel(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal AudioLevel As Integer) Handles Voice.AudioLevel
        ShowEvent("AudioLevel", "StreamNumber=" & StreamNumber, "StreamPosition=" & StreamPosition, "AudioLevel=" & AudioLevel)
    End Sub

    Private Sub Voice_Bookmark(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal Bookmark As String, ByVal BookmarkId As Integer) Handles Voice.Bookmark
        ShowEvent("BookMark", "StreamNumber=" & StreamNumber, "StreamPosition=" & StreamPosition, "Bookmark=" & Bookmark, "BookmarkId=" & BookmarkId)
    End Sub

    Private Sub Voice_EndStream(ByVal StreamNum As Integer, ByVal StreamPos As Object) Handles Voice.EndStream
        ShowEvent("EndStream", "StreamNum=" & StreamNum, "StreamPos=" & StreamPos)

        ' select all text to indicate that we are done
        HighLightSpokenWords(0, Len(MainTxtBox.Text))

        ' reset the mouth
        VisemePicture.Image = MouthImgList.Overlay("MICFULL", "MICFULL")

        ' reset the state of buttons, checkboxes and menu items
        SetSpeakingState(False, m_bPaused)
    End Sub

    Private Sub Voice_EnginePrivate(ByVal StreamNumber As Integer, ByVal StreamPosition As Integer, ByVal lParam As Object) Handles Voice.EnginePrivate
        ShowEvent("EnginePrivate", "StreamNumber=" & StreamNumber, "StreamPosition=" & StreamPosition, "lParam=" & lParam)
    End Sub

    Private Sub Voice_Phoneme(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal Duration As Integer, ByVal NextPhoneId As Short, ByVal Feature As SpeechLib.SpeechVisemeFeature, ByVal CurrentPhoneId As Short) Handles Voice.Phoneme
        ShowEvent("Phoneme", "StreamNumber=" & StreamNumber, "StreamPosition=" & StreamPosition, "NextPhoneId=" & NextPhoneId, "Feature=" & Feature, "CurrentPhoneId=" & CurrentPhoneId)
    End Sub

    Private Sub Voice_Sentence(ByVal StreamNum As Integer, ByVal StreamPos As Object, ByVal Pos As Integer, ByVal Length As Integer) Handles Voice.Sentence
        ShowEvent("Sentence", "StreamNum=" & StreamNum, "StreamPos=" & StreamPos, "Pos=" & Pos, "Length=" & Length)
    End Sub

    Private Sub Voice_StartStream(ByVal StreamNum As Integer, ByVal StreamPos As Object) Handles Voice.StartStream
        ShowEvent("StartStream", "StreamNum=" & StreamNum, "StreamPos=" & StreamPos)

        ' reset the state of buttons, checkboxes and menu items
        SetSpeakingState(True, m_bPaused)
    End Sub

    'Private Sub Voice_Viseme(ByVal StreamNum As Integer, ByVal StreamPos As Object, ByVal Duration As Integer, ByVal VisemeType As SpeechLib.SpeechVisemeType, ByVal Feature As SpeechLib.SpeechVisemeFeature, ByVal VisemeId As Integer) Handles Voice.Viseme
    Private Sub Voice_Viseme(ByVal StreamNum As Integer, ByVal StreamPos As Object, ByVal Duration As Integer, ByVal VisemeType As SpeechLib.SpeechVisemeType, ByVal Feature As SpeechLib.SpeechVisemeFeature, ByVal VisemeId As SpeechLib.SpeechVisemeType) Handles Voice.Viseme
        ShowEvent("Viseme", "StreamNum=" & StreamNum, "StreamPos=" & StreamPos, "Duration=" & Duration, "VisemeType=" & VisemeType, "Feature=" & Feature, "VisemeId=" & VisemeId)

        ' Here we are going to show different mouth positions according to the viseme.
        ' The picture we show doesn't necessarily match the real mouth position.
        ' Just trying to make it more interesting.
        If VisemeId = 0 Then
            VisemeId = VisemeId + 1
        End If
        VisemePicture.Image = MouthImgList.Overlay("MICFULL", VisemeId)
        If (VisemeId Mod 6 = 2) Then
            'Set VisemePicture.Picture = MouthImgList.Overlay("MICFULL", "MICFULL")
        Else
            If (VisemeId Mod 6 = 5) Then
                'Set VisemePicture.Picture = MouthImgList.Overlay("MICFULL", "MICFULL")
            End If
        End If
    End Sub

    Private Sub Voice_VoiceChange(ByVal StreamNum As Integer, ByVal StreamPos As Object, ByVal Token As SpeechLib.SpObjectToken) Handles Voice.VoiceChange

        ShowEvent("VoiceChange", "StreamNum=" & StreamNum, "StreamPos=" & StreamPos, "Token=" & Token.GetDescription)

        ' Let's sync up the combo box with the new value
        Dim i As Integer
        For i = 0 To VoiceCB.Items.Count - 1
            If VB6.GetItemString(VoiceCB, i) = Token.GetDescription() Then
                VoiceCB.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub Voice_Word(ByVal StreamNum As Integer, ByVal StreamPos As Object, ByVal Pos As Integer, ByVal Length As Integer) Handles Voice.Word

        ShowEvent("Word", "StreamNum=" & StreamNum, "StreamPos=" & StreamPos, "Pos=" & Pos, "Length=" & Length)

        System.Diagnostics.Debug.WriteLine(VB6.TabLayout(Pos, Length, MainTxtBox.SelectionStart, MainTxtBox.SelectionLength))

        ' Select the word that's currently being spoken.
        HighLightSpokenWords(Pos, Length)
    End Sub

    Private Sub VoiceCB_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VoiceCB.SelectedIndexChanged
        ' change the voice to the selected one
        Voice.Voice = Voice.GetVoices().Item(VoiceCB.SelectedIndex)
    End Sub

    Private Sub VolumeSldr_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VolumeSldr.Scroll
        Voice.Volume = VolumeSldr.Value
    End Sub

    ' The following functions are simply to sync up the speak flags.
    ' When the check box is checked, the corresponding bit is set in the flags.
    Private Sub chkSpFlagAync_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSpFlagAync.CheckStateChanged
        m_speakFlags = SetOrClearFlag(chkSpFlagAync.CheckState, m_speakFlags, SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync)
    End Sub



    Private Sub chkSpFlagIsXML_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        ' Note: special case here. There are two flags,SVSFIsXML and SVSFIsNotXML.
        ' When neither is set, SAPI will guess by peeking at beginning characters.
        ' In this sample, we explicitly set one of them.


    End Sub

    Private Sub chkSpFlagNLPSpeakPunc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSpFlagNLPSpeakPunc.CheckStateChanged
        m_speakFlags = SetOrClearFlag(chkSpFlagNLPSpeakPunc.CheckState, m_speakFlags, SpeechLib.SpeechVoiceSpeakFlags.SVSFNLPSpeakPunc)
    End Sub






    Private Sub AddFmts(ByRef name_Renamed As String, ByVal fmt As SpeechLib.SpeechAudioFormatType)
        Dim index As String

        ' get the count of existing list so that we are adding to the bottom of the list
        index = CStr(FormatCB.Items.Count)

        ' add the name to the list box and associate the format type with the item
        FormatCB.Items.Insert(index, name_Renamed)
        VB6.SetItemData(FormatCB, index, fmt)
    End Sub

    Private Sub AddItemToFmtCB()
        AddFmts("SAFT8kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT8kHz16BitMono)
        AddFmts("SAFT8kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT8kHz8BitStereo)
        AddFmts("SAFT8kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT8kHz16BitMono)
        AddFmts("SAFT8kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT8kHz16BitStereo)

        AddFmts("SAFT11kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT11kHz8BitMono)
        AddFmts("SAFT11kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT11kHz8BitStereo)
        AddFmts("SAFT11kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT11kHz16BitMono)
        AddFmts("SAFT11kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT11kHz16BitStereo)

        AddFmts("SAFT12kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT12kHz8BitMono)
        AddFmts("SAFT12kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT12kHz8BitStereo)
        AddFmts("SAFT12kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT12kHz16BitMono)
        AddFmts("SAFT12kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT12kHz16BitStereo)

        AddFmts("SAFT16kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT16kHz8BitMono)
        AddFmts("SAFT16kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT16kHz8BitStereo)
        AddFmts("SAFT16kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT16kHz16BitMono)
        AddFmts("SAFT16kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT16kHz16BitStereo)

        AddFmts("SAFT22kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT22kHz8BitMono)
        AddFmts("SAFT22kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT22kHz8BitStereo)
        AddFmts("SAFT22kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT22kHz16BitMono)
        AddFmts("SAFT22kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT22kHz16BitStereo)

        AddFmts("SAFT24kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT24kHz8BitMono)
        AddFmts("SAFT24kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT24kHz8BitStereo)
        AddFmts("SAFT24kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT24kHz16BitMono)
        AddFmts("SAFT24kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT24kHz16BitStereo)

        AddFmts("SAFT32kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT32kHz8BitMono)
        AddFmts("SAFT32kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT32kHz8BitStereo)
        AddFmts("SAFT32kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT32kHz16BitMono)
        AddFmts("SAFT32kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT32kHz16BitStereo)

        AddFmts("SAFT44kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT44kHz8BitMono)
        AddFmts("SAFT44kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT44kHz8BitStereo)
        AddFmts("SAFT44kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT44kHz16BitMono)
        AddFmts("SAFT44kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT44kHz16BitStereo)

        AddFmts("SAFT48kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT48kHz8BitMono)
        AddFmts("SAFT48kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT48kHz8BitStereo)
        AddFmts("SAFT48kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT48kHz16BitMono)
        AddFmts("SAFT48kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT48kHz16BitStereo)
    End Sub
    Private Sub LoadMouthImages()
        On Error GoTo ErrHandler

        MouthImgList.ListImages.Add(1, "MICFULL", VB6.ImageToIPictureDisp(VB6.LoadResPicture("MICFULL", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(2, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC11", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(3, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC11", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(4, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC11", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(5, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC10", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(6, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC11", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(7, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC9", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(8, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC2", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(9, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC13", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(10, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC9", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(11, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC12", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(12, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC11", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(13, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC9", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(14, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC3", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(15, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC6", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(16, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC7", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(17, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC8", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(18, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC5", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(19, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC4", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(20, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC7", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(21, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC9", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(22, , VB6.ImageToIPictureDisp(VB6.LoadResPicture("MIC11", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(23, "MICEYECLOSED", VB6.ImageToIPictureDisp(VB6.LoadResPicture("MICEYECLOSED", VB6.LoadResConstants.ResBitmap)))
        MouthImgList.ListImages.Add(24, "MICEYENARROW", VB6.ImageToIPictureDisp(VB6.LoadResPicture("MICEYENARROW", VB6.LoadResConstants.ResBitmap)))

        Exit Sub
ErrHandler:
        MsgBox(Err.Description & ":" & Err.Number, MsgBoxStyle.OkOnly, "Load Images Error")
    End Sub

    Private Sub AddDebugInfo(ByRef DebugStr As String, Optional ByRef Error_Renamed As String = "")
        ' This function adds debug string to the info window.

        ' First of all, let's delete a few charaters if the text box is about to
        ' overflow. In this sample we are using the default limit of charaters.
        If Len(DebugTxtBox.Text) > 64000 Then
            System.Diagnostics.Debug.WriteLine("Too much stuff in the debug window. Remove first 10K chars")
            DebugTxtBox.SelectionStart = 0
            DebugTxtBox.SelectionLength = 10240
            DebugTxtBox.SelectedText = ""
        End If

        ' append the string to the DebugTxtBox text box and add a newline
        DebugTxtBox.SelectionStart = Len(DebugTxtBox.Text)
        DebugTxtBox.SelectedText = DebugStr & Error_Renamed & vbCrLf
    End Sub

    Private Sub ShowEvent(ByVal ParamArray strArray() As Object)
        ' we will only show the events if the ShowEvents box is checked
        Dim strText As String
        If chkShowEvents.CheckState = System.Windows.Forms.CheckState.Checked Then
            strText = Join(strArray, ", ")
            AddDebugInfo("  Event: " & strText)
        End If
    End Sub

    Private Sub HighLightSpokenWords(ByVal Pos As Integer, ByVal Length As Integer)
        On Error GoTo ErrHandler

        ' Only high light when the MainTxtBox is actually showing the spoken text,
        ' instead of file name


        Exit Sub

ErrHandler:
        AddDebugInfo("Failed to high light words. This may be caused by too many charaters in the main text box.")
    End Sub

    ' This following helper function will set or clear a bit (flag) in the given
    ' integer (base) according to the condition (cond). If cond is 0, the bit
    ' is cleared. Otherwise, the bit is set. The resulting integer is returned.
    Private Function SetOrClearFlag(ByVal cond As Integer, ByVal base As Integer, ByVal flag As Integer) As Integer

        If cond = 0 Then
            ' the condition is false, clear the flag
            SetOrClearFlag = base And Not flag
        Else
            ' the condition is false, set the flag
            SetOrClearFlag = base Or flag
        End If
    End Function

    Private Sub SetSpeakingState(ByVal bSpeaking As Boolean, ByVal bPaused As Boolean)
        ' change state of menu items and buttons accordingly

        menuFileSpeakWave.Enabled = Not bSpeaking
        menuFileSaveToWave.Enabled = Not bSpeaking

        SpeakBtn.Enabled = True

        StopBtn.Enabled = bSpeaking
        SkipBtn.Enabled = (bSpeaking And Not bPaused)
        PauseBtn.Enabled = bSpeaking

        If bPaused Then
            PauseBtn.Text = "Resume"
        Else
            PauseBtn.Text = "Pause"
        End If

        m_bSpeaking = bSpeaking
        m_bPaused = bPaused
    End Sub

    Public Function GetDirectory() As String

        Err.Clear()

        On Error GoTo ErrHandler

        Dim DataKey As SpeechLib.ISpeechDataKey
        Dim Category As New SpeechLib.SpObjectTokenCategory

        'Get the sdk installation location from the registry
        'The value is under "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Speech". The string name is SDKPath"
        Category.SetId(SpeechLib.SpeechStringConstants.SpeechRegistryLocalMachineRoot)
        DataKey = Category.GetDataKey
        GetDirectory = DataKey.GetStringValue("SDKPath")
        GetDirectory = GetDirectory & "samples\common"



ErrHandler:
        If Err.Number <> 0 Then
            GetDirectory = ""
        End If
    End Function


    Private Sub menuFileOpenText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuFileOpenText.Click

        Dim sLocation As String

        ' Set CancelError is True
        ComDlg.CancelError = True
        On Error GoTo ErrHandler
        Dim textFile As StreamReader

        ' Set flags
        ComDlg.Flags = MSComDlg.FileOpenConstants.cdlOFNFileMustExist Or MSComDlg.FileOpenConstants.cdlOFNPathMustExist
        ' Set Dialog title
        ComDlg.DialogTitle = "Open a Text File"
        ' Set open directory
        sLocation = GetDirectory()
        If Len(sLocation) <> 0 Then
            ComDlg.InitDir = sLocation
        End If

        ' Set filters
        ComDlg.Filter = "All Files (*.*)|*.*|Text, XML Files " & "(*.txt;*.xml)|*.txt;*.xml"

        ' Specify default filter
        ComDlg.FilterIndex = 2
        ' Display the Open dialog box
        ComDlg.ShowOpen()

        ' Now open the text file and open it in the text box.
        ' We only support text files encoded with the system code page as the
        ' binary to unicode conversion in VB is using system code page.
        ' FileOpen(1, ComDlg.FileName, OpenMode.Binary, OpenAccess.Read)

        textFile = File.OpenText(ComDlg.FileName)
        MainTxtBox.Text = textFile.ReadToEnd()
        textFile.Close()
        'FileClose(1)

        Exit Sub

ErrHandler:
        'User pressed the Cancel button, do not show error
        If Not (Err.Number = 32755) Then
            AddDebugInfo("Open file: ", Err.Description)
        End If
    End Sub

    Private Sub mnuBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBack.Click
        Me.Size = New System.Drawing.Size(412, 720)
    End Sub



End Class