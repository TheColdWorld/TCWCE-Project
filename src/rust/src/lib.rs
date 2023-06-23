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
#[warn(non_camel_case_types)]
pub const NAME: &str = "TheColdWorldConfigEditor";
pub const AUTHOR: &str = "TheColdWorld";
pub const VERSION: &str = "2.0.0";
#[allow(non_snake_case)]
pub mod API;
#[allow(non_snake_case)]
pub mod Header;
#[allow(non_snake_case)]
pub mod Headers;
#[allow(non_snake_case)]
pub mod IO;
#[allow(non_snake_case)]
pub mod Key;
#[allow(non_snake_case)]
pub mod SerializedString;
#[allow(non_snake_case)]
pub mod Value;
