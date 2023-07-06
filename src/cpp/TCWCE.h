/*
    A solution that stores settings in a file
    Copyright (©) 2022-2023  Dream_Sunny

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
#include <string>
#include "./lib/Linked-List-Cpp.h"
#pragma region Advance//Advance : Enable function [Use Define]
//#define TCWCE_Use_C_exception
#pragma endregion Advance
namespace std
{
    // From https://zhuanlan.zhihu.com/p/426939341
    std::vector<std::string> Split(const std::string& str,const char& delim) 
    {
    unsigned long long int previous = 0;
    unsigned long long int current = str.find(delim);
    std::vector<std::string> elems;
    while (current != std::string::npos) {
        if (current > previous) {
            elems.push_back(str.substr(previous, current - previous));
        }
        previous = current + 1;
        current = str.find(delim, previous);
    }
    if (previous != str.size()) {
        elems.push_back(str.substr(previous));
    }
    return elems;
    }
    //From https://blog.csdn.net/weixin_43793960/article/details/106193050
    std::string trim(const string& str) {
		std::string::size_type pos = str.find_first_not_of(' ');
		if (pos == std::string::npos) {  //若找不到空格
			return str;
		}
		std::string::size_type pos2 = str.find_last_not_of(' ');
		if (pos2 != std::string::npos)
			return str.substr(pos, pos2 - pos + 1); //子串：第一个非空格作为起始位置
			                                        // 字符个数：pos2-pos+1
		return str.substr(pos);
	}
}
namespace TCWCE
{
    const std::string Name = "TheColdWorldConfigEditor";
    const std::string Version = "2.0.1.0";
    const std::string Author = "DreamSunny";
    namespace Exception
    {
        void ThrowError(const char* ErrorMessage)
        {
            #ifdef TCWCE_Use_C_exception
            throw ErrorMessage;
            #endif
            #ifndef TCWCE_Use_C_exception
            throw std::runtime_error(ErrorMessage);
            #endif
        }
    } // namespace Exception
    namespace For_String
    {
        class Value
        {
            public:
            Value(Value* Others) :_Value(Others->_Value) {Others->_Value=nullptr;}
            Value(const Value& Others) : _Value(new std::string(*Others._Value)){}
            Value():_Value(new std::string){}
            Value(const std::string& value) : _Value(new std::string(value)){}
            std::string to_string() const {return *_Value;}
            private:
            std::string* _Value;
        };
         class Key
        {
            public:
            Key(Key* Others):_Name(Others->_Name),_Value(Others->_Value) {Others->_Name=nullptr;Others->_Value=nullptr;}
            Key(const Key& Others) : _Name(new std::string(*Others._Name)) ,_Value(new Value(*Others._Value)) {}
            Key(const std::string& Serializedstring)
            {
                std::vector<std::string> patrion=std::Split(Serializedstring,'=');
                switch (patrion.size())
                {
                case 0:
                    Exception::ThrowError("Format Error:The current format is \'Keyname=Keyvalue\'");
                    break;
                case 1:
                    _Name=new std::string(patrion[0]);
                    _Value=new Value();
                    break;
                case 2:
                    _Name=new std::string(patrion[0]);
                    _Value=new Value(patrion[1]);
                    break;
                default:
                    std::string tmp;
                    for (unsigned long long  i = 1; i < patrion.size(); i++)
                    {
                        tmp += patrion[i];
                    }
                    _Name=new std::string(patrion[0]);
                    _Value=new Value(tmp);
                    break;
                }
            }
            ~Key() 
            {
                if(_Value != nullptr)
                {
                    delete _Value;
                    _Value =nullptr;
                }
                if(_Name!= nullptr)
                {
                    delete _Name;
                    _Name=nullptr;
                }
            }
            std::string Serializedstring() const  {return *_Name + "=" + _Value->to_string();}
            private:
            Value* _Value;
            std::string* _Name;
        };
        class Header
        {
            public:
            Header(Header* Others) : _Name(Others->_Name),_KeyList(Others->_KeyList) {Others->_Name=nullptr;Others->_KeyList=nullptr;}
            Header(const Header& Others):_Name(new std::string(*Others._Name)),_KeyList(new LinkList<Key,unsigned long long int>(*Others._KeyList,true)) {}
            Header(const std::string& serializedstring,const char& PerLineSplitChar = '\n',const bool& Trim=true): Header(std::Split(serializedstring,PerLineSplitChar),Trim) {}
            Header(const std::vector<std::string>& serializedstringVector,const bool& Trim=true)
            {
                std::vector<std::string> Tmp = serializedstringVector;
                if(Tmp[0][Tmp[0].length()-1] != ':') Exception::ThrowError("Format Error:The current format is \'Headername:\n{\nkey1=value1\nkey2=value2\nkey3=value3\n}\'");
                if(*--Tmp.end() != "}") Exception::ThrowError("Format Error:The current format is \'Headername:\n{\nkey1=value1\nkey2=value2\nkey3=value3\n}\'");
                _Name=new std::string(Tmp[0]);
                _Name->pop_back();
                try
                {
                    _KeyList = new  LinkList<Key,unsigned long long int>();
                    for (auto iter = ++Tmp.begin();iter != ----Tmp.end();iter++)
                    {
                        _KeyList->Push_Back(Key(*iter));
                    }
                }
                #ifdef Linked_List_Use_C_exception
                catch(const char* e)
                {
                    Exception::ThrowError("Internal error");
                }
                #endif
                #ifndef Linked_List_Use_C_exception
                catch(const std::runtime_error& e)
                {
                    Exception::ThrowError("Internal error");
                }
                catch(const std::exception& e2)
                {
                    throw e2;
                }
                #endif
                
            }
            std::string Serializedstring() const 
            { 
                std::string tmp(*_Name);
                tmp += ":\n{\n";
                for (auto& i : *_KeyList)
                {
                    tmp += i.Serializedstring() + "\n" ;
                }
                tmp +="}";
                return tmp;
            }
            ~Header()
            {
                if(_Name!=nullptr)  
                {
                    delete _Name;
                    _Name=nullptr;
                }
                if(_KeyList != nullptr)
                {
                    delete _KeyList;
                    _KeyList=nullptr;
                }
            }
            private:
            LinkList<Key,unsigned long long int>* _KeyList;
            std::string* _Name;
        };
        class Headers
        {
            public:
            Headers() : _HeaderLinkList(new LinkList<Header,unsigned long long int>()) {}
            Headers(const Headers& Others) : _HeaderLinkList(new LinkList<Header,unsigned long long int>(*Others._HeaderLinkList,true)) {}
            Headers(Headers* Others) : _HeaderLinkList(Others->_HeaderLinkList) {Others->_HeaderLinkList=nullptr;}
            Headers(const std::string& serializedstring,const char& PerLineSplitChar = '\n',const bool& trim=true) : Headers(std::Split(serializedstring,PerLineSplitChar),trim){ }
            Headers(const std::vector<std::string>& serializedstringVector,const bool& trim=true)
            {
                std::vector<std::string> Tmp(serializedstringVector.size());
                for (unsigned long long int i = 0;trim && i < serializedstringVector.size(); i++)
                {
                    Tmp.push_back(serializedstringVector[i]);
                }
                std::vector<std::vector<unsigned long long int>> Tmp2;
                for (unsigned long long int  i = 0; i < Tmp.size(); i++)
                {
                    if(Tmp[i][Tmp[i].length()-1] == ':')
                    {
                        if(Tmp[i+1] != "{") continue;
                        for (unsigned long long int i2 = i+1; i2 < Tmp.size(); i2++) 
                        {
                            if(Tmp[i2]=="}") 
                            {
                                Tmp2.push_back({i,i2});
                            }
                        }
                    }
                }
                if(Tmp2.empty()) 
                {
                    Exception::ThrowError("Can not find any Headers!");
                }
                std::vector<std::string> Tmp3;
                _HeaderLinkList = new LinkList<Header,unsigned long long int>();
                for (unsigned long long int i = 0; i < Tmp2.size(); i++)
                {
                    Tmp3.clear();
                    for (unsigned long long int i2 = Tmp2[i][0]; i2 < Tmp2[i][1]; i2++)
                    {
                       Tmp3.push_back(Tmp[i2]);
                    }
                    try
                    {
                         _HeaderLinkList->Push_Back(Header(Tmp3));
                    }
                    catch(const std::runtime_error& e)
                    {
                        Exception::ThrowError("Internal error");
                    }
                }
            }
            ~Headers()
            {
                if(_HeaderLinkList = nullptr)
                {
                    delete _HeaderLinkList;
                    _HeaderLinkList=nullptr;
                }
            }
            std::string Serializedstring() const 
            {
                std::string tmp;
                try
                {
                    for (auto& i : *_HeaderLinkList)
                    {
                        tmp += i.Serializedstring() + "\n" ;
                    }
                }
                #ifdef Linked_List_Use_C_exception
                catch(const char* e)
                {
                    Exception::ThrowError("Internal error");
                }
                #endif
                #ifndef Linked_List_Use_C_exception
                catch(const std::runtime_error& e)
                {
                    Exception::ThrowError("Internal error");
                }
                catch(const std::exception& e2)
                {
                    throw e2;
                }
                #endif
                return tmp;
            }
            private:
            LinkList<Header,unsigned long long int>* _HeaderLinkList; 
        };
    } // namespace For_String
    
} // namespace TCWCE
