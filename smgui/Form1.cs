using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using smgui.My;

namespace smgui;

[DesignerGenerated]
public class Form1 : Form
{
	private readonly IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("CheckBox3")]
	private CheckBox _CheckBox3;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("CheckBox4")]
	private CheckBox _CheckBox4;

	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[AccessedThroughProperty("CheckBox5")]
	private CheckBox _CheckBox5;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("sm")]
	private Process _sm;

	private string romdir;
    private string r;
    private readonly FolderBrowserDialog setromdir;

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual ListBox ListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ListBox1_SelectedValueChanged;
			EventHandler value3 = ListBox1_DoubleClick;
			if (_ListBox1 != null)
			{
				_ListBox1.SelectedIndexChanged -= value2;
				_ListBox1.DoubleClick -= value3;
			}
			_ListBox1 = value;
			if (_ListBox1 != null)
			{
				_ListBox1.SelectedIndexChanged += value2;
				_ListBox1.DoubleClick += value3;
			}
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button1_Click;
			if (_Button1 != null)
			{
				_Button1.Click -= value2;
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				_Button1.Click += value2;
			}
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual CheckBox CheckBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox2 = value;
		}
	}

	internal virtual CheckBox CheckBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox3 = value;
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button2_Click;
			if (_Button2 != null)
			{
				_Button2.Click -= value2;
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				_Button2.Click += value2;
			}
		}
	}

	internal virtual CheckBox CheckBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CheckBox4_CheckedChanged;
			if (_CheckBox4 != null)
			{
				_CheckBox4.CheckedChanged -= value2;
			}
			_CheckBox4 = value;
			if (_CheckBox4 != null)
			{
				_CheckBox4.CheckedChanged += value2;
			}
		}
	}

	internal virtual BackgroundWorker BackgroundWorker1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BackgroundWorker1 = value;
		}
	}

	internal virtual CheckBox CheckBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CheckBox5_CheckedChanged;
			if (_CheckBox5 != null)
			{
				_CheckBox5.CheckedChanged -= value2;
			}
			_CheckBox5 = value;
			if (_CheckBox5 != null)
			{
				_CheckBox5.CheckedChanged += value2;
			}
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox3 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual TextBox TextBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox4 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual TextBox TextBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox5 = value;
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button3_Click;
			if (_Button3 != null)
			{
				_Button3.Click -= value2;
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				_Button3.Click += value2;
			}
		}
	}

	public virtual Process Sm
	{
		[DebuggerNonUserCode]
		get
		{
			return _sm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_sm = value;
		}
	}

	public Form1()
	{
		base.Load += Form1_Load;
		base.FormClosing += Form1_FormClosing;
		Sm = new Process();
		setromdir = new FolderBrowserDialog();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.ListBox1 = new System.Windows.Forms.ListBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.CheckBox2 = new System.Windows.Forms.CheckBox();
		this.CheckBox3 = new System.Windows.Forms.CheckBox();
		this.Button2 = new System.Windows.Forms.Button();
		this.CheckBox4 = new System.Windows.Forms.CheckBox();
		this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		this.CheckBox5 = new System.Windows.Forms.CheckBox();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.Button3 = new System.Windows.Forms.Button();
		this.SuspendLayout();
		System.Windows.Forms.TextBox textBox = this.TextBox1;
		System.Drawing.Point location = new(13, 409);
		textBox.Location = location;
		this.TextBox1.Multiline = true;
		this.TextBox1.Name = "TextBox1";
		System.Windows.Forms.TextBox textBox2 = this.TextBox1;
		System.Drawing.Size size = new(709, 105);
		textBox2.Size = size;
		this.TextBox1.TabIndex = 0;
		this.ListBox1.FormattingEnabled = true;
		System.Windows.Forms.ListBox listBox = this.ListBox1;
		location = new System.Drawing.Point(3, 3);
		listBox.Location = location;
		this.ListBox1.Name = "ListBox1";
		System.Windows.Forms.ListBox listBox2 = this.ListBox1;
		size = new System.Drawing.Size(737, 342);
		listBox2.Size = size;
		this.ListBox1.TabIndex = 1;
		System.Windows.Forms.Button button = this.Button1;
		location = new System.Drawing.Point(744, 13);
		button.Location = location;
		this.Button1.Name = "Button1";
		System.Windows.Forms.Button button2 = this.Button1;
		size = new System.Drawing.Size(102, 23);
		button2.Size = size;
		this.Button1.TabIndex = 2;
		this.Button1.Text = "set rom directory";
		this.Button1.UseVisualStyleBackColor = true;
		this.CheckBox1.AutoSize = true;
		System.Windows.Forms.CheckBox checkBox = this.CheckBox1;
		location = new System.Drawing.Point(744, 111);
		checkBox.Location = location;
		this.CheckBox1.Name = "CheckBox1";
		System.Windows.Forms.CheckBox checkBox2 = this.CheckBox1;
		size = new System.Drawing.Size(74, 17);
		checkBox2.Size = size;
		this.CheckBox1.TabIndex = 3;
		this.CheckBox1.Text = "Fullscreen";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.CheckBox2.AutoSize = true;
		System.Windows.Forms.CheckBox checkBox3 = this.CheckBox2;
		location = new System.Drawing.Point(744, 148);
		checkBox3.Location = location;
		this.CheckBox2.Name = "CheckBox2";
		System.Windows.Forms.CheckBox checkBox4 = this.CheckBox2;
		size = new System.Drawing.Size(79, 17);
		checkBox4.Size = size;
		this.CheckBox2.TabIndex = 4;
		this.CheckBox2.Text = "No Throttle";
		this.CheckBox2.UseVisualStyleBackColor = true;
		this.CheckBox3.AutoSize = true;
		System.Windows.Forms.CheckBox checkBox5 = this.CheckBox3;
		location = new System.Drawing.Point(744, 184);
		checkBox5.Location = location;
		this.CheckBox3.Name = "CheckBox3";
		System.Windows.Forms.CheckBox checkBox6 = this.CheckBox3;
		size = new System.Drawing.Size(76, 17);
		checkBox6.Size = size;
		this.CheckBox3.TabIndex = 5;
		this.CheckBox3.Text = "Show FPS";
		this.CheckBox3.UseVisualStyleBackColor = true;
		this.Button2.Enabled = false;
		System.Windows.Forms.Button button3 = this.Button2;
		location = new System.Drawing.Point(744, 55);
		button3.Location = location;
		this.Button2.Name = "Button2";
		System.Windows.Forms.Button button4 = this.Button2;
		size = new System.Drawing.Size(102, 23);
		button4.Size = size;
		this.Button2.TabIndex = 6;
		this.Button2.Text = "Configure Keys";
		this.Button2.UseVisualStyleBackColor = true;
		this.CheckBox4.AutoSize = true;
		System.Windows.Forms.CheckBox checkBox7 = this.CheckBox4;
		location = new System.Drawing.Point(744, 223);
		checkBox7.Location = location;
		this.CheckBox4.Name = "CheckBox4";
		System.Windows.Forms.CheckBox checkBox8 = this.CheckBox4;
		size = new System.Drawing.Size(112, 17);
		checkBox8.Size = size;
		this.CheckBox4.TabIndex = 7;
		this.CheckBox4.Text = "Custom Resoliition";
		this.CheckBox4.UseVisualStyleBackColor = true;
		this.CheckBox5.AutoSize = true;
		System.Windows.Forms.CheckBox checkBox9 = this.CheckBox5;
		location = new System.Drawing.Point(744, 309);
		checkBox9.Location = location;
		this.CheckBox5.Name = "CheckBox5";
		System.Windows.Forms.CheckBox checkBox10 = this.CheckBox5;
		size = new System.Drawing.Size(164, 17);
		checkBox10.Size = size;
		this.CheckBox5.TabIndex = 8;
		this.CheckBox5.Text = "Custom Power PC Frequency";
		this.CheckBox5.UseVisualStyleBackColor = true;
		System.Windows.Forms.TextBox textBox3 = this.TextBox2;
		location = new System.Drawing.Point(744, 268);
		textBox3.Location = location;
		this.TextBox2.Name = "TextBox2";
		System.Windows.Forms.TextBox textBox4 = this.TextBox2;
		size = new System.Drawing.Size(41, 20);
		textBox4.Size = size;
		this.TextBox2.TabIndex = 9;
		System.Windows.Forms.TextBox textBox5 = this.TextBox3;
		location = new System.Drawing.Point(818, 268);
		textBox5.Location = location;
		this.TextBox3.Name = "TextBox3";
		System.Windows.Forms.TextBox textBox6 = this.TextBox3;
		size = new System.Drawing.Size(41, 20);
		textBox6.Size = size;
		this.TextBox3.TabIndex = 10;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(792, 274);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(14, 13);
		label2.Size = size;
		this.Label1.TabIndex = 11;
		this.Label1.Text = "X";
		this.TextBox4.Enabled = false;
		System.Windows.Forms.TextBox textBox7 = this.TextBox4;
		location = new System.Drawing.Point(879, 332);
		textBox7.Location = location;
		this.TextBox4.Name = "TextBox4";
		System.Windows.Forms.TextBox textBox8 = this.TextBox4;
		size = new System.Drawing.Size(17, 20);
		textBox8.Size = size;
		this.TextBox4.TabIndex = 12;
		this.TextBox4.Text = "25";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(746, 332);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(107, 13);
		label4.Size = size;
		this.Label2.TabIndex = 13;
		this.Label2.Text = "Power PC Frequency";
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label4;
		location = new System.Drawing.Point(749, 369);
		label5.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label6 = this.Label4;
		size = new System.Drawing.Size(122, 13);
		label6.Size = size;
		this.Label4.TabIndex = 15;
		this.Label4.Text = "Se;ect Fragment Shader";
		System.Windows.Forms.TextBox textBox9 = this.TextBox5;
		location = new System.Drawing.Point(752, 396);
		textBox9.Location = location;
		this.TextBox5.Name = "TextBox5";
		System.Windows.Forms.TextBox textBox10 = this.TextBox5;
		size = new System.Drawing.Size(129, 20);
		textBox10.Size = size;
		this.TextBox5.TabIndex = 16;
		System.Windows.Forms.Button button5 = this.Button3;
		location = new System.Drawing.Point(749, 423);
		button5.Location = location;
		this.Button3.Name = "Button3";
		System.Windows.Forms.Button button6 = this.Button3;
		size = new System.Drawing.Size(75, 23);
		button6.Size = size;
		this.Button3.TabIndex = 17;
		this.Button3.Text = "Browse";
		this.Button3.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(930, 515);
		this.ClientSize = size;
		this.Controls.Add(this.Button3);
		this.Controls.Add(this.TextBox5);
		this.Controls.Add(this.Label4);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.TextBox4);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.TextBox3);
		this.Controls.Add(this.TextBox2);
		this.Controls.Add(this.CheckBox5);
		this.Controls.Add(this.CheckBox4);
		this.Controls.Add(this.Button2);
		this.Controls.Add(this.CheckBox3);
		this.Controls.Add(this.CheckBox2);
		this.Controls.Add(this.CheckBox1);
		this.Controls.Add(this.Button1);
		this.Controls.Add(this.ListBox1);
		this.Controls.Add(this.TextBox1);
		this.Name = "Form1";
		this.Text = "Supermodel GUI v.010 by jadekitten";
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (Operators.CompareString(romdir, "", TextCompare: false) != 0)
		{
			MySettingsProperty.Settings.romdir = romdir;
			MySettingsProperty.Settings.Save();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (Operators.CompareString(MySettingsProperty.Settings.romdir, null, TextCompare: false) != 0)
		{
			romdir = MySettingsProperty.Settings.romdir;
		}
		Sm.StartInfo.UseShellExecute = false;
		Sm.StartInfo.RedirectStandardOutput = true;
		Sm.StartInfo.RedirectStandardInput = true;
		Sm.StartInfo.RedirectStandardError = true;
		Sm.StartInfo.FileName = Application.StartupPath + "\\Supermodel.exe";
		if (!File.Exists(Application.StartupPath + "\\Supermodel.exe"))
		{
			Interaction.MsgBox("Supermodel not foundPlease ensure the GUI resides in your Supermodel directory", MsgBoxStyle.Critical, Text);
			return;
		}
		Sm.StartInfo.Arguments = "-print-games";
		Sm.StartInfo.CreateNoWindow = true;
		Sm.Start();
		while (!Sm.StandardOutput.EndOfStream)
		{
			ListBox1.Items.Add(Sm.StandardOutput.ReadLine());
		}
		r = ListBox1.Items.ToString().Replace("Car", "Call");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		setromdir.Description = "Please select your ROM directory";
        DialogResult dialogResult = setromdir.ShowDialog();
        if (dialogResult == DialogResult.OK)
		{
			romdir = setromdir.SelectedPath;
		}
	}

	private void ListBox1_DoubleClick(object sender, EventArgs e)
	{
		if (ListBox1.SelectedItem.ToString().Contains("vf3"))
		{
			Sm.StartInfo.Arguments = romdir + "\\vf3.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("lemans24"))
		{
			Sm.StartInfo.Arguments = romdir + "\\lemans24.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("scud") && !ListBox1.SelectedItem.ToString().Contains("Plus"))
		{
			Sm.StartInfo.Arguments = romdir + "\\scud.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("Plus"))
		{
			Sm.StartInfo.Arguments = romdir + "\\scudp.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("lostwsga"))
		{
			Sm.StartInfo.Arguments = romdir + "\\lostwsga.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("von2"))
		{
			Sm.StartInfo.Arguments = romdir + "\\von2.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("vs298"))
		{
			Sm.StartInfo.Arguments = romdir + "\\vs298.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("srally2"))
		{
			Sm.StartInfo.Arguments = romdir + "\\srally2.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("daytona2"))
		{
			Sm.StartInfo.Arguments = romdir + "\\daytona2.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("dayto2pe"))
		{
			Sm.StartInfo.Arguments = romdir + "\\dayto2pe.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("fvipers2"))
		{
			Sm.StartInfo.Arguments = romdir + "\\fvipers2.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("eca"))
		{
			Sm.StartInfo.Arguments = romdir + "\\eca.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("oceanhun"))
		{
			Sm.StartInfo.Arguments = romdir + "\\oceanhun.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("harley"))
		{
			Sm.StartInfo.Arguments = romdir + "\\harley.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("lamachin"))
		{
			Sm.StartInfo.Arguments = romdir + "\\lamachin.zip";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("swtrilgy"))
		{
			Sm.StartInfo.Arguments = romdir + "\\swtrilgy.zip";
		}
		if (CheckBox1.Checked)
		{
			Sm.StartInfo.Arguments = Sm.StartInfo.Arguments + " -fullscreen";
		}
		if (CheckBox2.Checked)
		{
			Sm.StartInfo.Arguments = Sm.StartInfo.Arguments + " -no-throttle";
		}
		if (CheckBox3.Checked)
		{
			Sm.StartInfo.Arguments = Sm.StartInfo.Arguments + " -show-fps";
		}
		if (CheckBox4.Checked && Versioned.IsNumeric(TextBox2.Text) && Versioned.IsNumeric(TextBox3.Text))
		{
			Sm.StartInfo.Arguments = Sm.StartInfo.Arguments + "res=" + TextBox2.Text + "," + TextBox3.Text;
		}
		if (CheckBox5.Checked && Operators.CompareString(TextBox4.Text, "", TextCompare: false) != 0)
		{
			Sm.StartInfo.Arguments = Sm.StartInfo.Arguments + " -ppc-frequency=" + TextBox4.Text;
		}
		if (Operators.CompareString(TextBox5.Text, "", TextCompare: false) != 0)
		{
			Sm.StartInfo.Arguments = Sm.StartInfo.Arguments + "-frag-shader=" + TextBox5.Text;
		}
		Sm.EnableRaisingEvents = true;
		Sm.Start();
		if (Sm.StandardError.Peek() != -1)
		{
			TextBox1.Text = Sm.StandardError.ReadToEnd();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Sm.StartInfo.Arguments = "-config-inputs";
		Sm.Start();
		while (Sm.StandardOutput.Peek() != -1)
		{
			TextBox1.Text += Sm.StandardOutput.ReadLine();
		}
	}

	private void CheckBox4_CheckedChanged(object sender, EventArgs e)
	{
		if (!CheckBox4.Checked)
		{
			TextBox2.Enabled = false;
			TextBox3.Enabled = false;
		}
		else
		{
			TextBox2.Enabled = true;
			TextBox3.Enabled = true;
		}
	}

	private void CheckBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckBox5.Checked)
		{
			TextBox4.Enabled = true;
			return;
		}
		TextBox4.Enabled = false;
		TextBox4.Text = Conversions.ToString(25);
	}

	private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
	{
		if (ListBox1.SelectedItem.ToString().Contains("vf3"))
		{
			TextBox1.Text = "Title:          Virtua Fighter 3\r\nROM Set:        vf3\r\nManufacturer: Sega\r\nYear:           1996\r\nStep:           1.0";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("lemans24"))
		{
			TextBox1.Text = "Title:          Le Mans 24\r\nROM Set:        lemans24\r\nManufacturer: Sega\r\nYear:           1998\r\nStep:           1.5";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("scud") && !ListBox1.SelectedItem.ToString().Contains("Plus"))
		{
			TextBox1.Text = "Title:          Scud Race\r\nROM Set:        scud\r\nManufacturer: Sega\r\nYear:           1996\r\nStep:           1.5";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("Scud Race Plus"))
		{
			TextBox1.Text = "Title:          Scud Race Plus\r\nROM Set:        scudp\r\nManufacturer: Sega\r\nYear:           1996\r\nStep:           1.5";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("lostwsga"))
		{
			TextBox1.Text = "Title:          The Lost World\r\nROM Set:        lostwsga\r\nManufacturer: Sega\r\nYear:           1997\r\nStep:           1.5";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("von2"))
		{
			TextBox1.Text = "Title:          Virtual On Oratorio Tangram\r\nROM Set:        von2\r\nManufacturer: Sega\r\nYear:           1998\r\nStep:           2.0";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("vs298"))
		{
			TextBox1.Text = "Title:          Virtua Striker 2 '98\r\nROM Set:        vs298\r\nManufacturer: Sega\r\nYear:           1998\r\nStep:           2.0";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("srally2"))
		{
			TextBox1.Text = "Title:          Sega Rally 2\r\nROM Set:        srally2\r\nManufacturer: Sega\r\nYear:           1998\r\nStep:           2.0";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("daytona2"))
		{
			TextBox1.Text = "Title:          Daytona USA 2\r\nROM Set:        daytona2\r\nManufacturer: Sega\r\nYear:           1998\r\nStep:           2.1";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("dayto2pe"))
		{
			TextBox1.Text = "Title:          Daytona USA 2 Power Edition\r\nROM Set:        dayto2pe\r\nManufacturer: Sega\r\nYear:           1998\r\nStep:           2.1";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("fvipers2"))
		{
			TextBox1.Text = "Title:          Fighting Vipers 2\r\nROM Set:        fvipers2\r\nManufacturer: Sega\r\nYear:           1998\r\nStep:           2.0";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("harley"))
		{
			TextBox1.Text = "  Title:          Harley Davidson & L.A. Riders\r\nROM Set:        harley\r\nManufacturer: Sega\r\nYear:           1998\r\nStep:           2.0";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("lamachin"))
		{
			TextBox1.Text = " Title:          L.A. Machineguns\r\nROM Set:        lamachin\r\nManufacturer: Sega\r\nYear:           1998\r\nStep:           2.1";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("oceanhun"))
		{
			TextBox1.Text = "Title:          The Ocean Hunter\r\nROM Set:        oceanhun\r\nManufacturer: Sega\r\nYear:           1998\r\nStep:           2.1";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("swtrilgy"))
		{
			TextBox1.Text = "Title:          Star Wars Trilogy\r\nROM Set:        swtrilgy\r\nManufacturer: Sega, LucasArts\r\nYear:           1998\r\nStep:           2.1";
		}
		else if (ListBox1.SelectedItem.ToString().Contains("eca"))
		{
			TextBox1.Text = " Title:          Emergency Call Ambulance\r\nROM Set:        eca\r\nManufacturer: Sega\r\nYear:           1998\r\nStep:           2.1";
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
        OpenFileDialog openFileDialog = new()
        {
            Title = "Select a Fragment Shader",
            Filter = "OpenGL Shaders (*.glsl)|*.glsl"
        };
        DialogResult dialogResult = openFileDialog.ShowDialog();
        if (dialogResult == DialogResult.OK)
		{
			TextBox5.Text = openFileDialog.FileName;
		}
	}
}
