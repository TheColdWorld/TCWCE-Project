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
#[derive(Clone)]
pub struct Key {
    _Value: crate::Value::Value,
    _Name: std::string::String,
}
#[allow(non_snake_case)]
impl Key {
    pub fn From_str(ref value: &str) -> Result<Self, String> {
        let tmp: Vec<&str> = value.split('=').collect();
        if tmp.len() == 0 {
            return Err(format!(
                r"Format Error: '{:?}' is not 'Name=Value' format",
                value
            ));
        } else {
            return Ok(Self {
                _Value: crate::Value::Value::From_String(tmp[1..].concat()),
                _Name: String::from(tmp[0]),
            });
        }
    }
    pub fn From_String(ref value: &String) -> Result<Self, String> {
        let tmp: Vec<&str> = value.split('=').collect();
        if tmp.len() == 0 {
            return Err(format!(
                r"Format Error: '{:?}' is not 'Name=Value' format",
                value
            ));
        } else {
            return Ok(Self {
                _Value: crate::Value::Value::From_String(tmp[1..].concat()),
                _Name: String::from(tmp[0]),
            });
        }
    }
    pub fn Equal(&self, others: Self) -> bool {
        return self._Value.eq(others._Value) && self._Name.eq(&others._Name);
    }
    pub fn eq(&self, others: Self) -> bool {
        return self._Value.eq(others._Value) && self._Name.eq(&others._Name);
    }
    pub fn Name(&self) -> String {
        return self._Name.clone();
    }
    pub fn Value(&self) -> crate::Value::Value {
        return self._Value.clone();
    }
    pub fn GetValueRef(&self) -> &crate::Value::Value {
        return &self._Value;
    }
    pub unsafe fn GetValuePointer(&mut self) -> *mut crate::Value::Value {
        return &mut self._Value as *mut crate::Value::Value;
    }
    pub fn ChangeName(&mut self, ref NewName: String) {
        self._Name = NewName.clone();
    }
    pub fn ChangeValue(&mut self, ref NewValue: crate::Value::Value) {
        self._Value = NewValue.clone();
    }
    pub fn SerializedString(&self) -> crate::SerializedString::SerializedString {
        crate::SerializedString::SerializedString::from(self.Name() + "+" + self.Value().To_Str())
    }
    pub fn clone(&self) -> Self {
        Self {
            _Name: self._Name.clone(),
            _Value: self.Value().clone(),
        }
    }
}
impl From<&str> for Key {
    fn from(ref value: &str) -> Self {
        Self::From_str(value).unwrap()
    }
}
impl From<String> for Key {
    fn from(ref value: String) -> Self {
        Self::From_String(&value).unwrap()
    }
}
