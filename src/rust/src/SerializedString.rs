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
#[allow(non_snake_case)]
pub struct SerializedString{
    _value:String,
    _From:String
}
#[allow(non_snake_case)]
impl SerializedString{
    #[inline]
    fn From_Str(value:&str,from:&str) -> Self{
        Self{
            _value:String::from(value),
            _From:String::from(from)
        }
    }
    #[inline]
    fn From_String(ref value:String,from:&str) ->Self{
        Self{
            _value:value.clone(),
            _From:String::from(from)
        }
    }
    #[inline]
    fn From_RefString(value:&String,from:&str) ->Self{
        Self{
            _value:String::from(value),
            _From:String::from(from)
        }
    }
}
impl From<&str> for SerializedString{
    #[inline]
    fn from(value: &str) -> Self {
        Self{
            _value: String::from(value),
            _From:String::from("From")
        }
    }
}
impl From<String> for  SerializedString{
    #[inline]
    fn from(ref value: String) -> Self {
        Self{
            _value: value.clone(),
            _From:String::from("From")
        }
    }
}
impl From<&String> for SerializedString{
    #[inline]
    fn from(value: &String) -> Self {
        Self{
            _value: String::from(value),
            _From:String::from("From")
        }
    }
}

impl Into<String> for SerializedString{
    #[inline]
    fn into(self) -> String {
        return  self._value.clone()
    }
}

impl Clone for SerializedString{
    #[inline]
    fn clone(&self) -> Self {
        Self{
            _value:self._value.clone(),
            _From:self._From.clone()
        }
    }
}