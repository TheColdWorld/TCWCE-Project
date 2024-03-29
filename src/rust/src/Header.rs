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
pub struct Header {
    _Keys: Vec<crate::Key::Key>,
    _Name: std::string::String,
}
#[allow(non_snake_case)]
impl Header {
    pub fn From_str(ref value: &str, ref Trim: bool) -> Result<Self, String> {
        if value.is_empty() {
            return Err("Empty input".to_string());
        };
        let mut Lines: Vec<&str> = value.lines().collect();
        Lines.retain(|line| !line.is_empty());
        if *Trim {
            Lines = Lines.into_iter().map(str::trim_start).collect();
        };
        if Lines.is_empty() || Lines.len() < 3 {
            return Err(format!(
                "Format Error:\'{:?}\' is not \'Name:\n{{\n...Keys...\n}}\' format",
                value
            ));
        };
        let name_parts: Vec<&str> = Lines[0].split(':').collect();
        if name_parts.len() < 2 {
            return Err(format!(
                "Format Error:\'{:?}\' is not \'Name:\n{{\n...Keys...\n}}\' format",
                value
            ));
        };
        let mut keys_lines: Vec<&str> = Vec::new();
        let mut keys_end_index: usize = 0;
        let mut keys_start_index: usize = 0;
        for (i, line) in Lines.iter().enumerate() {
            if line.trim() == "{" {
                keys_start_index = i + 1;
                break;
            }
        }
        for (i, line) in Lines.iter().enumerate().skip(keys_start_index) {
            if line.trim() == "}" {
                keys_end_index = i;
                break;
            }
            keys_lines.push(*line);
        }
        if keys_lines.is_empty() || keys_end_index == 0 {
            return Ok(Self {
                _Keys: Vec::new(),
                _Name: name_parts[0].trim().to_string(),
            });
        };
        let mut Keys: Vec<crate::Key::Key> = Vec::new();
        for i in 0..keys_lines.len() - 1 {
            Keys.push(crate::Key::Key::From_str(keys_lines[i]).unwrap())
        }
        return Ok(Self {
            _Name: name_parts[0].trim().to_string(),
            _Keys: Keys.clone(),
        });
    }
    pub fn From_String(ref value: String, ref Trim: bool) -> Result<Self, String> {
        if value.is_empty() {
            return Err("Empty input".to_string());
        };
        let mut Lines: Vec<&str> = value.lines().collect();
        Lines.retain(|line| !line.is_empty());
        if *Trim {
            Lines = Lines.into_iter().map(str::trim_start).collect();
        };
        if Lines.is_empty() || Lines.len() < 3 {
            return Err(format!(
                "Format Error:\'{:?}\' is not \'Name:\n{{\n...Keys...\n}}\' format",
                value
            ));
        };
        let name_parts: Vec<&str> = Lines[0].split(':').collect();
        if name_parts.len() < 2 {
            return Err(format!(
                "Format Error:\'{:?}\' is not \'Name:\n{{\n...Keys...\n}}\' format",
                value
            ));
        };
        let mut keys_lines: Vec<&str> = Vec::new();
        let mut keys_end_index: usize = 0;
        let mut keys_start_index: usize = 0;
        for (i, line) in Lines.iter().enumerate() {
            if line.trim() == "{" {
                keys_start_index = i + 1;
                break;
            }
        }
        for (i, line) in Lines.iter().enumerate().skip(keys_start_index) {
            if line.trim() == "}" {
                keys_end_index = i;
                break;
            }
            keys_lines.push(*line);
        }
        if keys_lines.is_empty() || keys_end_index == 0 {
            return Ok(Self {
                _Keys: Vec::new(),
                _Name: name_parts[0].trim().to_string(),
            });
        };
        let mut Keys: Vec<crate::Key::Key> = Vec::new();
        for i in 0..keys_lines.len() - 1 {
            Keys.push(crate::Key::Key::From_str(keys_lines[i]).unwrap())
        }
        return Ok(Self {
            _Name: name_parts[0].trim().to_string(),
            _Keys: Keys.clone(),
        });
    }
    pub fn From_Vec_String(ref _value: Vec<String>, ref Trim: bool) -> Result<Self, String> {
        let mut value: Vec<&str> = Vec::new();
        for i in _value {
            value.push(i);
        }
        if value.is_empty() {
            return Err("Empty input".to_string());
        };
        value.retain(|line| !line.is_empty());
        if *Trim {
            value = value.into_iter().map(str::trim_start).collect();
        };
        if value.len() < 3 {
            return Err("Format Error:not \'Name:\n{{\n...Keys...\n}}\' format".to_string());
        };
        let name_parts: Vec<&str> = value[0].split(':').collect();
        if name_parts.len() < 2 {
            return Err("Format Error:not \'Name:\n{{\n...Keys...\n}}\' format".to_string());
        };
        let mut keys_lines: Vec<&str> = Vec::new();
        let mut keys_end_index: usize = 0;
        let mut keys_start_index: usize = 0;
        for (i, line) in value.iter().enumerate() {
            if line.trim() == "{" {
                keys_start_index = i + 1;
                break;
            }
        }
        for (i, line) in value.iter().enumerate().skip(keys_start_index) {
            if line.trim() == "}" {
                keys_end_index = i;
                break;
            }
            keys_lines.push(line);
        }
        if keys_lines.is_empty() || keys_end_index == 0 {
            return Ok(Self {
                _Keys: Vec::new(),
                _Name: name_parts[0].trim().to_string(),
            });
        };
        let mut Keys: Vec<crate::Key::Key> = Vec::new();
        for i in 0..keys_lines.len() - 1 {
            Keys.push(crate::Key::Key::From_str(keys_lines[i]).unwrap())
        }
        return Ok(Self {
            _Name: name_parts[0].trim().to_string(),
            _Keys: Keys.clone(),
        });
    }
    pub fn From_Vec_Str(ref _value: Vec<&str>, ref Trim: bool) -> Result<Self, String> {
        let mut value: Vec<&str> = _value.clone();
        if value.is_empty() {
            return Err("Empty input".to_string());
        };
        value.retain(|line| !line.is_empty());
        if *Trim {
            value = value.into_iter().map(str::trim_start).collect();
        };
        if value.len() < 3 {
            return Err("Format Error:not \'Name:\n{{\n...Keys...\n}}\' format".to_string());
        };
        let name_parts: Vec<&str> = value[0].split(':').collect();
        if name_parts.len() < 2 {
            return Err("Format Error:not \'Name:\n{{\n...Keys...\n}}\' format".to_string());
        };
        let mut keys_lines: Vec<&str> = Vec::new();
        let mut keys_end_index: usize = 0;
        let mut keys_start_index: usize = 0;
        for (i, line) in value.iter().enumerate() {
            if line.trim() == "{" {
                keys_start_index = i + 1;
                break;
            }
        }
        for (i, line) in value.iter().enumerate().skip(keys_start_index) {
            if line.trim() == "}" {
                keys_end_index = i;
                break;
            }
            keys_lines.push(*line);
        }
        if keys_lines.is_empty() || keys_end_index == 0 {
            return Ok(Self {
                _Keys: Vec::new(),
                _Name: name_parts[0].trim().to_string(),
            });
        };
        let mut Keys: Vec<crate::Key::Key> = Vec::new();
        for i in 0..keys_lines.len() - 1 {
            Keys.push(crate::Key::Key::From_str(keys_lines[i]).unwrap())
        }
        return Ok(Self {
            _Name: name_parts[0].trim().to_string(),
            _Keys: Keys.clone(),
        });
    }
    pub fn Name(&self) ->String{ self._Name.clone()}
    pub fn ChangeName(&mut self,NewName:String) {self._Name=NewName.clone()}
    pub fn Length(&self)->usize{self._Keys.len()}
}

impl From<&str> for Header {
    fn from(ref value: &str) -> Self {
        Self::From_str(value, true).unwrap()
    }
}
impl From<String> for Header {
    fn from(value: String) -> Self {
        Self::From_String(value, true).unwrap()
    }
}

impl From<Vec<String>> for Header {
    fn from(_value: Vec<String>) -> Self {
        Self::From_Vec_String(_value, true).unwrap()
    }
}

impl From<Vec<&str>> for Header {
    fn from(_value: Vec<&str>) -> Self {
        Self::From_Vec_Str(_value, true).unwrap()
    }
}

impl crate::API::Index<String,crate::Key::Key> for Header{
    fn GetIndex(&mut self, INDEX: String) -> Result<crate::Key::Key,String> {
        for index in &self._Keys {
            if index.Name() .eq( &INDEX) {return Ok(index.clone())}
        };
        return Err("Item Not Found!".to_string());
    }
    fn index(&mut self, INDEX: String) -> crate::Key::Key {
        for index in &self._Keys {
            if index.Name().eq(&INDEX) {return index.clone()}
        };
        panic!("Item Not Found!");
    }
    fn GetIndexRef(&mut self,INDEX:String) -> &crate::Key::Key{
        for index in &self._Keys {
            if index.Name().eq(&INDEX) {return &index;};
        };
        panic!("Item Not Found!");
    }
    unsafe fn GetIndexPointer(&mut self,INDEX:String) ->  *mut crate::Key::Key{
        for index in &self._Keys {
            if index.Name().eq(&INDEX) {return &mut index.clone() as *mut crate::Key::Key;};
        };
        panic!("Item Not Found!");
    }
}

impl crate::API::Index<&str,crate::Key::Key> for Header{
    fn GetIndex(&mut self, INDEX: &str) -> Result<crate::Key::Key,String> {
        for index in &self._Keys {
            if index.Name() .eq( INDEX) {return Ok(index.clone())}
        };
        return Err("Item Not Found!".to_string());
    }
    fn index(&mut self, INDEX: &str) -> crate::Key::Key {
        for index in &self._Keys {
            if index.Name().eq(INDEX) {return index.clone()}
        };
        panic!("Item Not Found!");
    }
    fn GetIndexRef(&mut self,INDEX:&str) -> &crate::Key::Key{
        for index in &self._Keys {
            if index.Name().eq(INDEX) {return &index;};
        };
        panic!("Item Not Found!");
    }
    unsafe fn GetIndexPointer(&mut self,INDEX:&str) ->  *mut crate::Key::Key {
        for index in &self._Keys {
            if index.Name().eq(INDEX) { return &mut index.clone() as *mut crate::Key::Key; };
        };
        panic!("Item Not Found!");
    }
}

impl Clone for Header {
    fn clone(&self) -> Self {
        Self{
            _Keys:self._Keys.clone(),
            _Name:self._Name.clone()
        }
    }
}

impl crate::API::Index<usize,crate::Key::Key> for Header{
    fn GetIndex(&mut self, INDEX: usize) -> Result<crate::Key::Key, String> {
        if INDEX >= self.Length() || INDEX < 0{
            return Err("Out of Index".to_string())
        };
        return Ok(self._Keys[INDEX].clone());
    }
    fn GetIndexRef(&mut self, INDEX: usize) -> &crate::Key::Key {
        if INDEX >= self.Length() {
            panic!("Out of Index");
        };
        return &self._Keys[INDEX];
    }
    fn index(&mut self, INDEX: usize) -> crate::Key::Key {
        if INDEX >= self.Length() {
            panic!("Out of Index");
        };
        return self._Keys[INDEX].clone();
    }
    unsafe fn GetIndexPointer(&mut self, INDEX: usize) -> *mut crate::Key::Key {
        if INDEX <= self.Length() {
            panic!("Out of Index");
        };
        return &mut self._Keys[INDEX] as *mut crate::Key::Key;
    }
}