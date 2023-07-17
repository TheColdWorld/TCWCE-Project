using Debug= System.Diagnostics.Debug;
string str = "Header1:\n{\nKey1=Value1\nKey2=Value2\nKey3=Value3\nKey4=Value4\n}";
string str2 = "Header2:\n{\nKey1=Value1\nKey2=Value2\nKey3=Value3\nKey4=Value4\n}";
string filepath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "debug.txt");
if (System.IO.File.Exists(filepath)) System.IO.File.Delete(filepath);
Debug.WriteLine("Starting To Write file\nThe context is:" + str);
System.IO.FileStream? fs = new(filepath, System.IO.FileMode.CreateNew){Position =0};
fs.Write(System.Text.Encoding.UTF8.GetBytes(str));
fs.Dispose();
fs=null;
Debug.WriteLine("File write done!");
TCWCE.For_String.Header header1; TCWCE.For_String.Headers headers1; TCWCE.For_String.Headers File_Headers; TCWCE.For_String.Header header2;
Debug.WriteLine("Starting Create");
Debug.WriteLine(string.Format("Create instance:{0}\nInput:{1}",nameof(header1),str));
header1 = new(str);
Debug.WriteLine(string.Format("Create instance:{0}\nInput:{1}", nameof(headers1), str));
headers1 = new(str);
Debug.WriteLine(string.Format("Create instance:{0}\nInputFile:{1}", nameof(File_Headers), filepath));
File_Headers =TCWCE.IO.GetHeadersFromFile(filepath,System.Text.Encoding.UTF8);
Debug.WriteLine(string.Format("Create instance:{0}\nInput:{1}", nameof(header2), str2));
header2 = new(str2);
Debug.WriteLine(nameof(headers1) + "[0] == " + nameof(header1) + ":");
Debug.WriteLine(headers1[0]==header1?"true":"false");
Debug.WriteLine(nameof(headers1) + "[0].Name == " + nameof(header1) + ".Name:");
Debug.WriteLine(headers1[0].Name == header1.Name ? "true" : "false");
Debug.WriteLine(nameof(headers1) + "[0].SerializedString == " + nameof(header1) + ".SerializedString:");
Debug.WriteLine(headers1[0].SerializedString == header1.SerializedString ? "true" : "false");
Debug.WriteLine(nameof(headers1) + " += " + nameof(header2));
headers1 += header2;
Debug.WriteLine(nameof(headers1) + ".SerializedString:");
Debug.WriteLine(headers1.SerializedString);
Debug.WriteLine("Foreach "+nameof(headers1));
foreach (TCWCE.For_String.Header header in headers1)
{
    Debug.WriteLine(header.SerializedString);
}
Debug.WriteLine("Foreach " + nameof(headers1) +"._Array:");
foreach (TCWCE.For_String.Header header in headers1)
{
    foreach(TCWCE.For_String.Key key in header) Debug.WriteLine(key.SerializedString);
}
Debug.WriteLine("Write " + nameof (headers1) + " in "+filepath);
TCWCE.IO.OverriteToFile(headers1,filepath,System.Text.Encoding.UTF8);
Debug.WriteLine(filepath + ":");
foreach(var i in System.IO.File.ReadAllLines(filepath)) Debug.WriteLine(i);
System.IO.File.Delete(filepath);
Debug.WriteLine("Debug Done!");
System.Console.ReadKey();