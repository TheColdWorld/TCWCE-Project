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
//This is Application Public Interface
#[allow(non_snake_case)]
pub trait Index<#[allow(non_snake_case)]iterator,Return>{
    #[must_use]
    fn index(&mut self,INDEX:iterator) -> Return;
    #[must_use]
    fn GetIndex(&mut self,INDEX:iterator) -> Result<Return,String>;
    unsafe fn GetIndexPointer(&mut self,INDEX:iterator) ->  *mut Return;
    fn GetIndexRef(&mut self,INDEX:iterator) -> &Return;
}