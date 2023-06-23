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
#[derive(Clone)]
    pub struct Header{
        _Keys:Vec<crate::Key::Key>,
        _Name:std::string::String
    }
    impl Header {
        pub fn From_str(ref value:&str,ref Trim :bool) -> Result<Self,String>{
            if value.is_empty() {
                return  Err("Empty input".to_string());
            };
            let mut Lines: Vec<&str> = value.lines().collect();
            Lines.retain(|line| !line.is_empty());
            if *Trim{
                Lines = Lines.into_iter().map(str::trim_start).collect();
            };
            if Lines.is_empty() || Lines.len() <3 {
                return  Err(format!("Format Error:\'{:?}\' is not \'Name:\n{{\n...Keys...\n}}\' format",value));
            };
            let name_parts: Vec<&str> = Lines[0].split(':').collect();
            if name_parts.len() < 2{
                return Err(format!("Format Error:\'{:?}\' is not \'Name:\n{{\n...Keys...\n}}\' format",value));
            };
            let mut keys_lines:Vec<&str> = Vec::new();
            let mut keys_end_index: usize = 0;
            let mut keys_start_index: usize =0;
            for (i, line) in Lines.iter().enumerate() {
                if line.trim() == "{" {
                    keys_start_index = i  + 1;
                    break;
                }
            };
            for (i, line) in Lines.iter().enumerate().skip(keys_start_index ) {
                if line.trim() == "}" {
                    keys_end_index = i;
                    break;
                }
                keys_lines.push(*line);
            };
            if keys_lines.is_empty() || keys_end_index == 0 {
                return Ok(Self { _Keys: Vec::new(), _Name: name_parts[0].trim().to_string() });
            };
            let mut Keys :Vec<crate::Key::Key> =Vec::new();
            for i in 0..keys_lines.len()-1 {
                Keys.push(crate::Key::Key::From_str(keys_lines[i]).unwrap())
            };
            return  Ok(Self {
                _Name: name_parts[0].trim().to_string(),
                _Keys: Keys.clone(),
            });
        }
        pub fn From_String(ref value:String,ref Trim :bool) ->Result<Self,String>{
            if value.is_empty() {
                return  Err("Empty input".to_string());
            };
            let mut Lines: Vec<&str> = value.lines().collect();
            Lines.retain(|line| !line.is_empty());
            if *Trim{
                Lines = Lines.into_iter().map(str::trim_start).collect();
            };
            if Lines.is_empty() || Lines.len() <3 {
                return  Err(format!("Format Error:\'{:?}\' is not \'Name:\n{{\n...Keys...\n}}\' format",value));
            };
            let name_parts: Vec<&str> = Lines[0].split(':').collect();
            if name_parts.len() < 2{
                return Err(format!("Format Error:\'{:?}\' is not \'Name:\n{{\n...Keys...\n}}\' format",value));
            };
            let mut keys_lines:Vec<&str> = Vec::new();
            let mut keys_end_index: usize = 0;
            let mut keys_start_index: usize =0;
            for (i, line) in Lines.iter().enumerate() {
                if line.trim() == "{" {
                    keys_start_index = i  + 1;
                    break;
                }
            };
            for (i, line) in Lines.iter().enumerate().skip(keys_start_index ) {
                if line.trim() == "}" {
                    keys_end_index = i;
                    break;
                }
                keys_lines.push(*line);
            };
            if keys_lines.is_empty() || keys_end_index == 0 {
                return Ok(Self { _Keys: Vec::new(), _Name: name_parts[0].trim().to_string() });
            };
            let mut Keys :Vec<crate::Key::Key> =Vec::new();
            for i in 0..keys_lines.len()-1 {
                Keys.push(crate::Key::Key::From_str(keys_lines[i]).unwrap())
            };
            return  Ok(Self {
                _Name: name_parts[0].trim().to_string(),
                _Keys: Keys.clone(),
            });
        }
        pub fn From_Vec_String(ref _value:Vec<String>,ref Trim :bool) -> Result<Self,String> {
            let mut value:Vec<&str>=Vec::new();
            for i in _value {
                value.push(i);
            }
            if value.is_empty() {
                return  Err("Empty input".to_string());
            };
            value.retain(|line| !line.is_empty());
            if *Trim{
                value =  value.into_iter().map(str::trim_start).collect();
            };
            if  value.len() <3  {
                return  Err("Format Error:not \'Name:\n{{\n...Keys...\n}}\' format".to_string());
            };
            let name_parts: Vec<&str> = value[0].split(':').collect();
            if name_parts.len() < 2 {
                return  Err("Format Error:not \'Name:\n{{\n...Keys...\n}}\' format".to_string());
            };
            let mut keys_lines:Vec<&str> = Vec::new();
            let mut keys_end_index: usize = 0;
            let mut keys_start_index: usize =0;
            for (i, line) in value.iter().enumerate() {
                if line.trim() == "{" {
                    keys_start_index = i  + 1;
                    break;
                }
            };
            for (i, line) in value.iter().enumerate().skip(keys_start_index ) {
                if line.trim() == "}" {
                    keys_end_index = i;
                    break;
                }
                keys_lines.push(line);
            };
            if keys_lines.is_empty() || keys_end_index == 0 {
                return Ok(Self { _Keys: Vec::new(), _Name: name_parts[0].trim().to_string() });
            };
            let mut Keys :Vec<crate::Key::Key> =Vec::new();
            for i in 0..keys_lines.len()-1 {
                Keys.push(crate::Key::Key::From_str(keys_lines[i]).unwrap())
            };
            return  Ok(Self {
                _Name: name_parts[0].trim().to_string(),
                _Keys: Keys.clone(),
            });
        }
        pub fn From_Vec_Str(ref _value:Vec<&str>,ref Trim :bool) -> Result<Self,String> {
            let mut value:Vec<&str>=_value.clone();
            if value.is_empty()  {
                return  Err("Empty input".to_string());
            };
            value.retain(|line| !line.is_empty());
            if *Trim{
                value = value.into_iter().map(str::trim_start).collect();
            };
            if  value.len() <3  {
                return  Err("Format Error:not \'Name:\n{{\n...Keys...\n}}\' format".to_string());
            };
            let name_parts: Vec<&str> = value[0].split(':').collect();
            if name_parts.len() < 2 {
                return  Err("Format Error:not \'Name:\n{{\n...Keys...\n}}\' format".to_string());
            };
            let mut keys_lines:Vec<&str> = Vec::new();
            let mut keys_end_index: usize = 0;
            let mut keys_start_index: usize =0;
            for (i, line) in value.iter().enumerate() {
                if line.trim() == "{" {
                    keys_start_index = i  + 1;
                    break;
                }
            };
            for (i, line) in value.iter().enumerate().skip(keys_start_index ) {
                if line.trim() == "}" {
                    keys_end_index = i;
                    break;
                }
                keys_lines.push(*line);
            };
            if keys_lines.is_empty() || keys_end_index == 0 {
                return Ok(Self { _Keys: Vec::new(), _Name: name_parts[0].trim().to_string() });
            };
            let mut Keys :Vec<crate::Key::Key> =Vec::new();
            for i in 0..keys_lines.len()-1 {
                Keys.push(crate::Key::Key::From_str(keys_lines[i]).unwrap())
            };
            return  Ok(Self {
                _Name: name_parts[0].trim().to_string(),
                _Keys: Keys.clone(),
            });
        }
    }

impl From<&str> for Header {
    fn from(ref value: &str) -> Self {
        Self::From_str(value,true) .unwrap()
    }
}
impl From<String> for Header {
    fn from( value: String) -> Self {
         Self::From_String(value,true) .unwrap()
    }
}
impl From<&String> for Header {
    fn from( value: &String) -> Self {
       Self::From_String(value.clone(),true).unwrap()
    }
}

impl From<Vec<String>> for Header{
    fn from(_value: Vec<String>) -> Self {
        Self::From_Vec_String(_value,true).unwrap()
    }
}

impl From<Vec<&str>> for Header{
    fn from(_value: Vec<&str>) -> Self {
        Self::From_Vec_Str(_value,true).unwrap()
    }
}