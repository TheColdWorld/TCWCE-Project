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
pub struct Headers {
    #[allow(non_snake_case)]
    _Headers: Vec<crate::Header::Header>,
}
#[allow(non_snake_case)]
impl Headers {
    pub fn From_str(ref value: &str, ref Trim: bool) -> Result<Self, String> {
        if value.is_empty() {
            return Err("Value is Empty!".to_string());
        };
        let mut Lines: Vec<&str> = value.lines().collect();
        Lines.retain(|line| !line.is_empty());
        if *Trim {
            Lines = Lines.into_iter().map(str::trim_start).collect();
        };
        let mut Found: bool = false;
        let mut HeaderLines: Vec<Vec<usize>> = Vec::new();
        for mut is in 0..Lines.len() {
            for ch in Lines[is].chars() {
                if ch == ':' {
                    Found = true;
                    for Linees in is..Lines.len() {
                        if Lines[Linees] == "}" {
                            let mut tmp2: Vec<usize> = Vec::new();
                            tmp2.push(is);
                            tmp2.push(Linees);
                            HeaderLines.push(tmp2);
                            is = Linees;
                        };
                    }
                };
            }
        }
        if !Found {
            return Err("Cannot Find Any Header!".to_string());
        }
        let mut _Headerss: Vec<crate::Header::Header> = Vec::new();
        for iis in 0..HeaderLines.len() {
            let Tmp: Vec<&str> = Lines[HeaderLines[iis][1]..HeaderLines[iis][1]].to_vec();
            _Headerss.push(crate::Header::Header::from(Tmp));
        }
        return Ok(Self {
            _Headers: _Headerss.clone(),
        });
    }
    pub fn From_String(ref value: String, ref Trim: bool) -> Result<Self, String> {
        if value.is_empty() {
            return Err("Value is Empty!".to_string());
        };
        let mut Lines: Vec<&str> = value.lines().collect();
        Lines.retain(|line| !line.is_empty());
        if *Trim {
            Lines = Lines.into_iter().map(str::trim_start).collect();
        };
        let mut Found: bool = false;
        let mut HeaderLines: Vec<Vec<usize>> = Vec::new();
        for mut is in 0..Lines.len() {
            for ch in Lines[is].chars() {
                if ch == ':' {
                    Found = true;
                    for Linees in is..Lines.len() {
                        if Lines[Linees] == "}" {
                            let mut tmp2: Vec<usize> = Vec::new();
                            tmp2.push(is);
                            tmp2.push(Linees);
                            HeaderLines.push(tmp2);
                            is = Linees;
                        };
                    }
                };
            }
        }
        if !Found {
            return Err("Cannot Find Any Header!".to_string());
        }
        let mut _Headerss: Vec<crate::Header::Header> = Vec::new();
        for iis in 0..HeaderLines.len() {
            let Tmp: Vec<&str> = Lines[HeaderLines[iis][1]..HeaderLines[iis][1]].to_vec();
            _Headerss.push(crate::Header::Header::from(Tmp));
        }
        return Ok(Self {
            _Headers: _Headerss.clone(),
        });
    }
    pub fn From_String_Vec(ref value: Vec<String>, ref Trim: bool) -> Result<Self, String> {
        if value.is_empty() {
            return Err("Value is Empty!".to_string());
        };
        let mut Lines: Vec<&str> = Vec::new();
        for va in value {
            Lines.push(va);
        }
        Lines.retain(|line| !line.is_empty());
        if *Trim {
            Lines = Lines.into_iter().map(str::trim_start).collect();
        };
        let mut Found: bool = false;
        let mut HeaderLines: Vec<Vec<usize>> = Vec::new();
        for mut is in 0..Lines.len() {
            for ch in Lines[is].chars() {
                if ch == ':' {
                    Found = true;
                    for Linees in is..Lines.len() {
                        if Lines[Linees] == "}" {
                            let mut tmp2: Vec<usize> = Vec::new();
                            tmp2.push(is);
                            tmp2.push(Linees);
                            HeaderLines.push(tmp2);
                            is = Linees;
                        };
                    }
                };
            }
        }
        if !Found {
            return Err("Cannot Find Any Header!".to_string());
        }
        let mut _Headerss: Vec<crate::Header::Header> = Vec::new();
        for iis in 0..HeaderLines.len() {
            let Tmp: Vec<&str> = Lines[HeaderLines[iis][1]..HeaderLines[iis][1]].to_vec();
            _Headerss.push(crate::Header::Header::from(Tmp));
        }
        return Ok(Self {
            _Headers: _Headerss.clone(),
        });
    }
    pub fn From_Str_Vec(ref value: Vec<&str>, ref Trim: bool) -> Result<Self, String> {
        if value.is_empty() {
            return Err("Value is Empty!".to_string());
        };
        let mut Lines: Vec<&str> = value.clone();
        Lines.retain(|line| !line.is_empty());
        if *Trim {
            Lines = Lines.into_iter().map(str::trim_start).collect();
        };
        let mut Found: bool = false;
        let mut HeaderLines: Vec<Vec<usize>> = Vec::new();
        for mut is in 0..Lines.len() {
            for ch in Lines[is].chars() {
                if ch == ':' {
                    Found = true;
                    for Linees in is..Lines.len() {
                        if Lines[Linees] == "}" {
                            let mut tmp2: Vec<usize> = Vec::new();
                            tmp2.push(is);
                            tmp2.push(Linees);
                            HeaderLines.push(tmp2);
                            is = Linees;
                        };
                    }
                };
            }
        }
        if !Found {
            return Err("Cannot Find Any Header!".to_string());
        }
        let mut _Headerss: Vec<crate::Header::Header> = Vec::new();
        for iis in 0..HeaderLines.len() {
            let Tmp: Vec<&str> = Lines[HeaderLines[iis][1]..HeaderLines[iis][1]].to_vec();
            _Headerss.push(crate::Header::Header::from(Tmp));
        }
        return Ok(Self {
            _Headers: _Headerss.clone(),
        });
    }
    pub fn  Length(&self) -> usize{self._Headers.len()}
}
#[allow(non_snake_case)]
impl Clone for Headers{
    fn clone(&self) -> Self {
        Self{
            _Headers:self._Headers.clone()
        }
    }
}
#[allow(non_snake_case)]
impl crate::API::Index<&str,crate::Header::Header> for Headers{
    fn index(&mut self, INDEX: &str) -> crate::Header::Header {
        for index in &self._Headers {
            if index.Name() .eq( INDEX) {return index.clone()}
        };
        panic!("Item Not Found!");
    }
    fn GetIndex(&mut self, INDEX: &str) -> Result<crate::Header::Header, String> {
        for index in &self._Headers {
            if index.Name() .eq(INDEX) {return Ok(index.clone())}
        };
        return  Err("Item Not Found!".to_string());
    }
    unsafe fn GetIndexPointer(&mut self, INDEX: &str) -> *mut crate::Header::Header {
        for index in &mut self._Headers {
            if index.Name() .eq( INDEX) {return index as *mut crate::Header::Header}
        };
        panic!("Item Not Found!");
    }
    fn GetIndexRef(&mut self, INDEX: &str) -> &crate::Header::Header {
        for index in &self._Headers {
            if index.Name() .eq( INDEX) {return index}
        };
        panic!("Item Not Found!");
    }
}
#[allow(non_snake_case)]
impl crate::API::Index<String,crate::Header::Header> for  Headers{
    fn index(&mut self, INDEX: String) -> crate::Header::Header {
        for index in &self._Headers {
            if index.Name() .eq( &INDEX) {return index.clone()}
        };
        panic!("Item Not Found!");
    }
    fn GetIndex(&mut self, INDEX: String) -> Result<crate::Header::Header, String> {
        for index in &self._Headers {
            if index.Name() .eq(&INDEX) {return Ok(index.clone())}
        };
       return  Err("Item Not Found!".to_string());
    }
    unsafe fn GetIndexPointer(&mut self, INDEX: String) -> *mut crate::Header::Header {
        for index in &mut self._Headers {
            if index.Name() .eq( &INDEX) {return  index as *mut crate::Header::Header}
        };
        panic!("Item Not Found!");
    }
    fn GetIndexRef(&mut self, INDEX: String) -> &crate::Header::Header {
        for index in &self._Headers {
            if index.Name() .eq( &INDEX) {return index}
        };
        panic!("Item Not Found!");
    }
}
impl crate::API::Index<usize,crate::Header::Header> for  Headers{
    fn index(&mut self, INDEX: usize) -> crate::Header::Header {
        if INDEX >= self.Length() {
            panic!("Out of Index");
        };
        return  self._Headers[INDEX].clone();
    }

    fn GetIndex(&mut self, INDEX: usize) -> Result<crate::Header::Header, String> {
        if INDEX >= self.Length() {
            return Err("Out of Index".to_string())
        };
        return Ok({self._Headers[INDEX].clone()});
    }

    unsafe fn GetIndexPointer(&mut self, INDEX: usize) -> *mut crate::Header::Header {
        if INDEX >= self.Length() {
            panic!("Out of Index");
        };
        return &mut self._Headers[INDEX] as *mut crate::Header::Header;
    }

    fn GetIndexRef(&mut self, INDEX: usize) -> &crate::Header::Header {
        if INDEX >= self.Length() {
            panic!("Out of Index");
        };
        return &self._Headers[INDEX];
    }
}