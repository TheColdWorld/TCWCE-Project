/*
   A solution that stores settings in a file
   Copyright (©) 2022-2023  TheColdWorld(梦晴)

   This library is free software; you can redistribute it and/or
   modify it under the terms of the GNU Lesser General Public
   License as published by the Free Software Foundation; either
   version 2.1 of the License, or (at your option) any later version.

   This library is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
   Lesser General Public License for more details.

   You should have received a copy of the GNU Lesser General Public
   License along with this library; if not, write to the Free Software
   Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
   USA
*/
//   _____  _     _____ ____  ____  _     ____  _      ____  ____  _     ____  ____  ____  _      _____ _  _____ _____ ____  _  _____  _____ ____ 
//  /__ __\/ \ /|/  __//   _\/  _ \/ \   /  _ \/ \  /|/  _ \/  __\/ \   /  _ \/   _\/  _ \/ \  /|/    // \/  __//  __//  _ \/ \/__ __\/  __//  __\
//    / \  | |_|||  \  |  /  | / \|| |   | | \|| |  ||| / \||  \/|| |   | | \||  /  | / \|| |\ |||  __\| || |  _|  \  | | \|| |  / \  |  \  |  \/|
//    | |  | | |||  /_ |  \__| \_/|| |_/\| |_/|| |/\||| \_/||    /| |_/\| |_/||  \__| \_/|| | \||| |   | || |_//|  /_ | |_/|| |  | |  |  /_ |    /
//    \_/  \_/ \|\____\\____/\____/\____/\____/\_/  \|\____/\_/\_\\____/\____/\____/\____/\_/  \|\_/   \_/\____\\____\\____/\_/  \_/  \____\\_/\_\
//
    using System.Linq;
    namespace TCWCE
    {
    public static class LibraryInfo
    {
        public const string Name = "TheColdConfigEditer";
        public const string Auther = "TheColdWorld";
        public const string Version = "2.1.0.1";
    }
    namespace For_String
    {
        public class Headers : System.Collections.IEnumerable, IIO_allowed
        {
            #region interface : System.Collections.IEnumerable
            System.Collections.Generic.IEnumerator<Header> GetEnumerator()
            {
                foreach (var header in _Array)
                {
                    yield return header;
                }
            }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>GetEnumerator();
            #endregion
            //var
            private System.Collections.Generic.List<Header> _Array;
            //accessor
            public int Count => _Array.Count;
            public Header this[int index]
            {
                get => this is null ? throw new System.NullReferenceException() : _Array[index];
                set { if (this is null) throw new System.NullReferenceException(); _Array[index] = value; }
            }
            public Header this[System.Index index]
            {
                get => this is null ? throw new System.NullReferenceException() : _Array[index];
                set { if (this is null) throw new System.NullReferenceException(); _Array[index] = value; }
            }
            public System.Collections.Generic.List<Header> this[System.Range range]
            {
                get => this is null ? throw new System.NullReferenceException() : _Array.GetRange(range.Start.Value, range.End.Value); 
                set { if (this is null) throw new System.NullReferenceException(); int start = range.Start.GetOffset(_Array.Count);int count = range.End.GetOffset(_Array.Count) - start; _Array.RemoveRange(start, count);_Array.InsertRange(start, value);}
            }
            public string SerializedString
            {
                get
                {
                    string tmp=string.Empty;
                    foreach(Header header in _Array) tmp +=header.SerializedString+"\n";
                    return tmp;
                }
            }
            public string[] SerializedStringArray
            {
                get
                {
                    System.Collections.Generic.LinkedList<string> tmp = new();
                    foreach(Header item in _Array) tmp.AddLast(item.SerializedString);
                    return tmp.ToArray();
                }
            }
            //functions
            public Headers() => _Array = new();
            public Headers(Headers others) => _Array = others._Array;
            public Headers(System.Collections.Generic.IEnumerable<Header> others) => _Array = others.ToList();//using System.Linq;
            public Headers(string serializedstring,string Separator ="\n",System.StringSplitOptions splitOptions = System.StringSplitOptions.TrimEntries):this(serializedstring.Split(new string[] { Separator }, splitOptions)){}
            public Headers(System.Collections.Generic.IEnumerable<string> _serializedstringArray)
            {
                string[] SerializedStringArray =_serializedstringArray.ToArray();//Convert System.Collections.Generic.IEnumerable<string> to string[]
                System.Collections.Generic.List<System.Collections.Generic.List<int>> Lines = new(); //Create a two-dimensional list to store the first and last data
                for (int index = 0; index < SerializedStringArray.Length; index++)
                {
                    if (SerializedStringArray[index][^1] == ':')//Capture header flags
                    {
                        for (int i = index; i < SerializedStringArray.Length; i++)
                        {
                            if (SerializedStringArray[i] == "}")
                            {
                                Lines.Add(new() { i, index });//Store data
                                index = i;//Jump index
                                break;
                            }
                        }
                    }
                }
                _Array = new(Lines.Count);//Create object
                foreach (var index in Lines)
                {
                    _Array.Add(new Header(SerializedStringArray[index[0]..index[1]]));//Copy the serialized data
                }
            }
            public void Add(Header header) => _Array.Add(header);
            public override bool Equals(object? obj) => base.Equals(obj);
            public override int GetHashCode() => base.GetHashCode();
            //operator
            public static bool operator==(Headers left, Headers right) => left._Array == right._Array;
            public static bool operator!=(Headers left, Headers right) => left._Array != right._Array;
            public static Headers operator +(Headers left, Headers right)
            {
                System.Collections.Generic.List<Header> i = left._Array;
                i.InsertRange(left.Count,right._Array);
                return new(i);
            }
            public static Headers operator -(Headers left, Headers right) 
            {
                System.Collections.Generic.List<Header> i = left._Array;
                foreach (var item in right._Array) i.Remove(item);
                return new(i);
            }
        }
        public class Header :System.Collections.IEnumerable,IIO_allowed
        {
            #region interface : System.Collections.IEnumerable
            System.Collections.Generic.IEnumerator<Key> GetEnumerator()
            {
                foreach (var header in _Array)
                {
                    yield return header;
                }
            }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
            #endregion
            //var
            private System.Collections.Generic.List<Key> _Array;
            private string _Name;
            //accessor
            public string Name => _Name;
            public int Count => _Array.Count;
            public Key this[int index]
            {
                get => this is null ? throw new System.NullReferenceException() : _Array[index];
                set { if (this is null) throw new System.NullReferenceException(); _Array[index] = value; }
            }
            public Key this[System.Index index]
            {
                get => this is null ? throw new System.NullReferenceException() : _Array[index];
                set { if (this is null) throw new System.NullReferenceException(); _Array[index] = value; }
            }
            public System.Collections.Generic.List<Key> this[System.Range range]
            {
                get => this is null ? throw new System.NullReferenceException() : _Array.GetRange(range.Start.Value, range.End.Value);
                set { if (this is null) throw new System.NullReferenceException(); int start = range.Start.GetOffset(_Array.Count); int count = range.End.GetOffset(_Array.Count) - start; _Array.RemoveRange(start, count); _Array.InsertRange(start, value); }
            }
            public string SerializedString
            {
                get
                {
                    string tmp = _Name + ":\n{\n";
                    foreach (var item in _Array) tmp += item.SerializedString + "\n";
                    tmp +="}";
                    return tmp;
                }
            }
            public string[] SerializedStringArray
            {
                get
                {
                    string[] tmp = new string[_Array.Count+3];
                    tmp[0]= _Name+":"; tmp[1] = "{";
                    for (int i = 0; i < _Array.Count; i++)
                    {
                        tmp[i+2]= _Array[i].SerializedString;
                    }
                    tmp[^1]= "}"; 
                    return tmp;
                }
            }
            //functions
            public Header(Header others) { _Array = others._Array;_Name=others._Name; }
            public Header(string name, System.Collections.Generic.IEnumerable<Key> keys) { _Array = keys.ToList();_Name = name; }
            public Header(string serializedstring, string Separator = "\n", System.StringSplitOptions splitOptions = System.StringSplitOptions.TrimEntries) : this(serializedstring.Split(new string[] { Separator }, splitOptions)) { }
            public Header(System.Collections.Generic.IEnumerable<string> serializedstringArray)
            {
                string[] SerializedStringArray = serializedstringArray.ToArray();
                for (int i = 0; i < SerializedStringArray.Length; i++) SerializedStringArray[i].Trim();
                if (SerializedStringArray[0][^1] != ':') { throw new System.FormatException(); }
                if (SerializedStringArray[1] != "{") { throw new System.FormatException(); }
                if (SerializedStringArray[^1] != "}") { throw new System.FormatException(); }
                _Name = new(SerializedStringArray[0].Replace(":", string.Empty));//复制名字
                _Array = new System.Collections.Generic.List<Key>(SerializedStringArray.Length - 3);
                for (int i = 2; i < SerializedStringArray.Length-1; i++) _Array.Add(new(SerializedStringArray[i]));
            }
            public void Add(Key key) => _Array.Add(key);
            public override bool Equals(object? obj) => base.Equals(obj);
            public override int GetHashCode() => base.GetHashCode();
            //operator
            public static bool operator ==(Header a, Header b) => a.Name == b.Name && a._Array == b._Array;
            public static bool operator !=(Header a, Header b) => a.Name != b.Name && a._Array != b._Array;
            public static bool operator ==(Header a,string b) => a.Name == b;
            public static bool operator !=(Header a,string b) => a.Name!=b;
        }
        public class Key
        {
            //var   
            private string _Name;
            private Value _Value;
            //functions
            public Key(string name, Value value) { _Name = name; _Value = value; }
            public Key(Key others) { _Name = others._Name; _Value=others._Value; }
            public Key(string serializedstring)
            {
                string[] tmp = serializedstring.Split('=',System.StringSplitOptions.RemoveEmptyEntries);
                if (tmp.Length == 0) throw new System.FormatException();
                _Name = tmp[0];
                _Value = tmp.Length switch
                {
                    1 => new Value(),
                    2 => new Value(tmp[1]),
                    _ => new Value(string.Join("=", tmp[1..]))
                };
            }
            //accessor
            public string SerializedString => _Name+_Value.ToString();
        }
        public class Value
        {
            //var   
            private string _value;
            //functions
            public Value()=>_value=string.Empty;
            public Value(string value)=> _value = value;
            public Value(Value value) => _value = value._value;
            public override bool Equals(object? obj) => base.Equals(obj);
            public override int GetHashCode() => base.GetHashCode();
            public override string ToString() => _value;
            public int ToInt() => System.Convert.ToInt32(_value);
            public long ToLong() => System.Convert.ToInt64(_value);
            public short ToShort() => System.Convert.ToInt16(_value);
            public uint ToUint() => System.Convert.ToUInt32(_value);
            public ulong ToUlong() => System.Convert.ToUInt64(_value);
            public ushort ToUshort() => System.Convert.ToUInt16(_value);
            public System.Numerics.BigInteger ToBigInt() => System.Numerics.BigInteger.Parse(_value);
            public double ToDouble() => System.Convert.ToDouble(_value);
            public bool ToBool() => System.Convert.ToBoolean(_value);
            public byte[] ToBytes(System.Text.Encoding encoding) => encoding.GetBytes(_value);
            public byte[] ToUTF8Bytes() => System.Text.Encoding.UTF8.GetBytes(_value);
            //operator
            public static bool operator ==(Value Left, Value Right) => Left._value == Right._value;
            public static bool operator !=(Value Left, Value Right) => Left._value != Right._value;
        }
        public interface IIO_allowed
        {
            public string[] SerializedStringArray { get; }
            public string SerializedString { get; }
        }
    }
    public static class IO
    {
        public static void OverriteToFile(For_String.IIO_allowed item,System.IO.FileInfo Fileinfo,System.Text.Encoding encoding)
        {
            if(item is null ) throw new System.ArgumentNullException(nameof(item));
            if (Fileinfo is null) throw new System.ArgumentNullException(nameof(Fileinfo));
            if (encoding is null) throw new System.ArgumentNullException(nameof(encoding));
            if(Fileinfo.Exists) Fileinfo.Delete();
            using System.IO.FileStream fs=Fileinfo.Create();
            fs.Position=0;
            fs.Write(encoding.GetBytes(item.SerializedString));
        }
        public static async System.Threading.Tasks.Task OverriteToFileAsync(For_String.IIO_allowed item, System.IO.FileInfo Fileinfo, System.Text.Encoding encoding, System.Action? Callback=default)
        {
            if (item is null) throw new System.ArgumentNullException(nameof(item));
            if (Fileinfo is null) throw new System.ArgumentNullException(nameof(Fileinfo));
            if (encoding is null) throw new System.ArgumentNullException(nameof(encoding));
            if (Fileinfo.Exists) Fileinfo.Delete();
            using System.IO.FileStream fs = Fileinfo.Create();
            fs.Position = 0;
            await fs.WriteAsync(encoding.GetBytes(item.SerializedString));
            Callback?.Invoke();
        }
        public static void OverriteToFile(For_String.IIO_allowed item, string Filepath, System.Text.Encoding encoding)
        {
            if (item is null) throw new System.ArgumentNullException(nameof(item));
            if (Filepath is null) throw new System.ArgumentNullException(nameof(Filepath));
            if (encoding is null) throw new System.ArgumentNullException(nameof(encoding));
            if (System.IO.File.Exists(Filepath)) System.IO.File.Delete(Filepath);
            using System.IO.FileStream fs = System.IO.File.Create(Filepath);
            fs.Position = 0;
            fs.Write(encoding.GetBytes(item.SerializedString));
        }
        public static async System.Threading.Tasks.Task OverriteToFileAsync(For_String.IIO_allowed item, string Filepath, System.Text.Encoding encoding,System.Action? Callback=default)
        {
            if (item is null) throw new System.ArgumentNullException(nameof(item));
            if (Filepath is null) throw new System.ArgumentNullException(nameof(Filepath));
            if (encoding is null) throw new System.ArgumentNullException(nameof(encoding));
            if (System.IO.File.Exists(Filepath)) System.IO.File.Delete(Filepath);
            using System.IO.FileStream fs = System.IO.File.Create(Filepath);
            fs.Position = 0;
            await fs.WriteAsync(encoding.GetBytes(item.SerializedString));
            Callback?.Invoke();
        }
        public static For_String.Headers GetHeadersFromFile(string FilePath,System.Text.Encoding encoding)
        {
            return string.IsNullOrWhiteSpace(FilePath)
                ? throw new System.ArgumentException("string is null or whitespace",nameof(FilePath))
                : encoding is null
                ? throw new System.ArgumentNullException(nameof(encoding))
                : new(System.IO.File.ReadAllLines(FilePath,encoding));
        }
        public async static System.Threading.Tasks.Task<For_String.Headers> GetHeadersFromFileAsybc(string FilePath,System.Text.Encoding encoding ,System.Action? Callback =default)
        {
            if (string.IsNullOrWhiteSpace(FilePath)) throw new System.ArgumentException("string is null or whitespace", nameof(FilePath));
            if (encoding is null) throw new System.ArgumentNullException(nameof(encoding));
            string[] tmp = await System.IO.File.ReadAllLinesAsync(FilePath, encoding, default);
            For_String.Headers returns= new(tmp);
            Callback?.Invoke();
            return returns;
        }
    }
}
