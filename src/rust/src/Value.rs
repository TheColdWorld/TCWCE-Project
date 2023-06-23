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
    pub struct Value{
        _Value : String
    }
#[allow(non_snake_case)]
     impl Value {

        pub fn From_str(value : &str) -> Self {
              Self {
                _Value :  String::from(value)
            }
        }
        pub fn From_String(ref value : String) -> Self{
           return   Self{
                _Value:value.clone()
            };
        }
        pub  fn To_String(&self)->String{
            return String::from(&self._Value);
        }
        pub  fn To_Str(&self)->&str{
            return str::as_ref(&self._Value);
        }
        pub fn To_I32(&self)->Result<i32,std::num::ParseIntError>{
            return self._Value.parse::<i32>();
        }
        pub fn To_I64(&self)->Result<i64,std::num::ParseIntError>{
            return self._Value.parse::<i64>();
        }
        pub  fn To_I128(&self)->Result<i128,std::num::ParseIntError>{
            return self._Value.parse::<i128>();
        }
        pub fn To_I16(&self)->Result<i16,std::num::ParseIntError>{
            return self._Value.parse::<i16>();
        }
        pub  fn To_F32(&self)->Result<f32, std::num::ParseFloatError>{
            return self._Value.parse::<f32>();
        }
        pub  fn To_F64(&self)->Result<f64, std::num::ParseFloatError>{
            return self._Value.parse::<f64>();
        }
        pub  fn To_bool(&self) -> Result<bool,&'static str>{
            match self._Value.to_lowercase().as_str() {
                "true" => return  Ok(true),
                "false" => return  Ok(false),
                _ => return  Err(r"Value is not 'true' or 'false'")
            };
           
        }
        pub  fn To_Bytes(&self) ->&[u8]{
            return self._Value.as_bytes();
        }
        pub  fn Equal(&self,others:Self)->bool{
            return  self._Value.eq(&others._Value);
        }
        pub  fn eq(&self,others:Self)->bool{
            return  self._Value.eq(&others._Value);
        }
        pub fn clone(&self) ->Self{
            Self{
                _Value:self._Value.clone()
            }
        }
    }
impl From<&str> for Value {
    #[inline]
    fn from(value: &str) -> Self {
        return Self::From_str(value)
    }
}
impl From<&String> for Value {
    #[inline]
    fn from(value: &String) -> Self {
        return Self::From_String(value.clone());
    }
}
impl From<String> for Value {
    #[inline]
    fn from(value: String) -> Self {
        return Self::From_String(value);
    }
}
