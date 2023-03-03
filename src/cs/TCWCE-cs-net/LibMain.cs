﻿/*
    A solution that stores settings in a file
    Copyright (©) 2022-2023  TheColdWorld

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
        public const string LincenseStr = "                  GNU LESSER GENERAL PUBLIC LICENSE\n                       Version 2.1, February 1999\n\n Copyright (C) 1991, 1999 Free Software Foundation, Inc.\n 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA\n Everyone is permitted to copy and distribute verbatim copies\n of this license document, but changing it is not allowed.\n\n[This is the first released version of the Lesser GPL.  It also counts\n as the successor of the GNU Library Public License, version 2, hence\n the version number 2.1.]\n\n                            Preamble\n\n  The licenses for most software are designed to take away your\nfreedom to share and change it.  By contrast, the GNU General Public\nLicenses are intended to guarantee your freedom to share and change\nfree software--to make sure the software is free for all its users.\n\n  This license, the Lesser General Public License, applies to some\nspecially designated software packages--typically libraries--of the\nFree Software Foundation and other authors who decide to use it.  You\ncan use it too, but we suggest you first think carefully about whether\nthis license or the ordinary General Public License is the better\nstrategy to use in any particular case, based on the explanations below.\n\n  When we speak of free software, we are referring to freedom of use,\nnot price.  Our General Public Licenses are designed to make sure that\nyou have the freedom to distribute copies of free software (and charge\nfor this service if you wish); that you receive source code or can get\nit if you want it; that you can change the software and use pieces of\nit in new free programs; and that you are informed that you can do\nthese things.\n\n  To protect your rights, we need to make restrictions that forbid\ndistributors to deny you these rights or to ask you to surrender these\nrights.  These restrictions translate to certain responsibilities for\nyou if you distribute copies of the library or if you modify it.\n\n  For example, if you distribute copies of the library, whether gratis\nor for a fee, you must give the recipients all the rights that we gave\nyou.  You must make sure that they, too, receive or can get the source\ncode.  If you link other code with the library, you must provide\ncomplete object files to the recipients, so that they can relink them\nwith the library after making changes to the library and recompiling\nit.  And you must show them these terms so they know their rights.\n\n  We protect your rights with a two-step method: (1) we copyright the\nlibrary, and (2) we offer you this license, which gives you legal\npermission to copy, distribute and/or modify the library.\n\n  To protect each distributor, we want to make it very clear that\nthere is no warranty for the free library.  Also, if the library is\nmodified by someone else and passed on, the recipients should know\nthat what they have is not the original version, so that the original\nauthor's reputation will not be affected by problems that might be\nintroduced by others.\n\n  Finally, software patents pose a constant threat to the existence of\nany free program.  We wish to make sure that a company cannot\neffectively restrict the users of a free program by obtaining a\nrestrictive license from a patent holder.  Therefore, we insist that\nany patent license obtained for a version of the library must be\nconsistent with the full freedom of use specified in this license.\n\n  Most GNU software, including some libraries, is covered by the\nordinary GNU General Public License.  This license, the GNU Lesser\nGeneral Public License, applies to certain designated libraries, and\nis quite different from the ordinary General Public License.  We use\nthis license for certain libraries in order to permit linking those\nlibraries into non-free programs.\n\n  When a program is linked with a library, whether statically or using\na shared library, the combination of the two is legally speaking a\ncombined work, a derivative of the original library.  The ordinary\nGeneral Public License therefore permits such linking only if the\nentire combination fits its criteria of freedom.  The Lesser General\nPublic License permits more lax criteria for linking other code with\nthe library.\n\n  We call this license the \"Lesser\" General Public License because it\ndoes Less to protect the user's freedom than the ordinary General\nPublic License.  It also provides other free software developers Less\nof an advantage over competing non-free programs.  These disadvantages\nare the reason we use the ordinary General Public License for many\nlibraries.  However, the Lesser license provides advantages in certain\nspecial circumstances.\n\n  For example, on rare occasions, there may be a special need to\nencourage the widest possible use of a certain library, so that it becomes\na de-facto standard.  To achieve this, non-free programs must be\nallowed to use the library.  A more frequent case is that a free\nlibrary does the same job as widely used non-free libraries.  In this\ncase, there is little to gain by limiting the free library to free\nsoftware only, so we use the Lesser General Public License.\n\n  In other cases, permission to use a particular library in non-free\nprograms enables a greater number of people to use a large body of\nfree software.  For example, permission to use the GNU C Library in\nnon-free programs enables many more people to use the whole GNU\noperating system, as well as its variant, the GNU/Linux operating\nsystem.\n\n  Although the Lesser General Public License is Less protective of the\nusers' freedom, it does ensure that the user of a program that is\nlinked with the Library has the freedom and the wherewithal to run\nthat program using a modified version of the Library.\n\n  The precise terms and conditions for copying, distribution and\nmodification follow.  Pay close attention to the difference between a\n\"work based on the library\" and a \"work that uses the library\".  The\nformer contains code derived from the library, whereas the latter must\nbe combined with the library in order to run.\n\n                  GNU LESSER GENERAL PUBLIC LICENSE\n   TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION\n\n  0. This License Agreement applies to any software library or other\nprogram which contains a notice placed by the copyright holder or\nother authorized party saying it may be distributed under the terms of\nthis Lesser General Public License (also called \"this License\").\nEach licensee is addressed as \"you\".\n\n  A \"library\" means a collection of software functions and/or data\nprepared so as to be conveniently linked with application programs\n(which use some of those functions and data) to form executables.\n\n  The \"Library\", below, refers to any such software library or work\nwhich has been distributed under these terms.  A \"work based on the\nLibrary\" means either the Library or any derivative work under\ncopyright law: that is to say, a work containing the Library or a\nportion of it, either verbatim or with modifications and/or translated\nstraightforwardly into another language.  (Hereinafter, translation is\nincluded without limitation in the term \"modification\".)\n\n  \"Source code\" for a work means the preferred form of the work for\nmaking modifications to it.  For a library, complete source code means\nall the source code for all modules it contains, plus any associated\ninterface definition files, plus the scripts used to control compilation\nand installation of the library.\n\n  Activities other than copying, distribution and modification are not\ncovered by this License; they are outside its scope.  The act of\nrunning a program using the Library is not restricted, and output from\nsuch a program is covered only if its contents constitute a work based\non the Library (independent of the use of the Library in a tool for\nwriting it).  Whether that is true depends on what the Library does\nand what the program that uses the Library does.\n\n  1. You may copy and distribute verbatim copies of the Library's\ncomplete source code as you receive it, in any medium, provided that\nyou conspicuously and appropriately publish on each copy an\nappropriate copyright notice and disclaimer of warranty; keep intact\nall the notices that refer to this License and to the absence of any\nwarranty; and distribute a copy of this License along with the\nLibrary.\n\n  You may charge a fee for the physical act of transferring a copy,\nand you may at your option offer warranty protection in exchange for a\nfee.\n\n  2. You may modify your copy or copies of the Library or any portion\nof it, thus forming a work based on the Library, and copy and\ndistribute such modifications or work under the terms of Section 1\nabove, provided that you also meet all of these conditions:\n\n    a) The modified work must itself be a software library.\n\n    b) You must cause the files modified to carry prominent notices\n    stating that you changed the files and the date of any change.\n\n    c) You must cause the whole of the work to be licensed at no\n    charge to all third parties under the terms of this License.\n\n    d) If a facility in the modified Library refers to a function or a\n    table of data to be supplied by an application program that uses\n    the facility, other than as an argument passed when the facility\n    is invoked, then you must make a good faith effort to ensure that,\n    in the event an application does not supply such function or\n    table, the facility still operates, and performs whatever part of\n    its purpose remains meaningful.\n\n    (For example, a function in a library to compute square roots has\n    a purpose that is entirely well-defined independent of the\n    application.  Therefore, Subsection 2d requires that any\n    application-supplied function or table used by this function must\n    be optional: if the application does not supply it, the square\n    root function must still compute square roots.)\n\nThese requirements apply to the modified work as a whole.  If\nidentifiable sections of that work are not derived from the Library,\nand can be reasonably considered independent and separate works in\nthemselves, then this License, and its terms, do not apply to those\nsections when you distribute them as separate works.  But when you\ndistribute the same sections as part of a whole which is a work based\non the Library, the distribution of the whole must be on the terms of\nthis License, whose permissions for other licensees extend to the\nentire whole, and thus to each and every part regardless of who wrote\nit.\n\nThus, it is not the intent of this section to claim rights or contest\nyour rights to work written entirely by you; rather, the intent is to\nexercise the right to control the distribution of derivative or\ncollective works based on the Library.\n\nIn addition, mere aggregation of another work not based on the Library\nwith the Library (or with a work based on the Library) on a volume of\na storage or distribution medium does not bring the other work under\nthe scope of this License.\n\n  3. You may opt to apply the terms of the ordinary GNU General Public\nLicense instead of this License to a given copy of the Library.  To do\nthis, you must alter all the notices that refer to this License, so\nthat they refer to the ordinary GNU General Public License, version 2,\ninstead of to this License.  (If a newer version than version 2 of the\nordinary GNU General Public License has appeared, then you can specify\nthat version instead if you wish.)  Do not make any other change in\nthese notices.\n\n  Once this change is made in a given copy, it is irreversible for\nthat copy, so the ordinary GNU General Public License applies to all\nsubsequent copies and derivative works made from that copy.\n\n  This option is useful when you wish to copy part of the code of\nthe Library into a program that is not a library.\n\n  4. You may copy and distribute the Library (or a portion or\nderivative of it, under Section 2) in object code or executable form\nunder the terms of Sections 1 and 2 above provided that you accompany\nit with the complete corresponding machine-readable source code, which\nmust be distributed under the terms of Sections 1 and 2 above on a\nmedium customarily used for software interchange.\n\n  If distribution of object code is made by offering access to copy\nfrom a designated place, then offering equivalent access to copy the\nsource code from the same place satisfies the requirement to\ndistribute the source code, even though third parties are not\ncompelled to copy the source along with the object code.\n\n  5. A program that contains no derivative of any portion of the\nLibrary, but is designed to work with the Library by being compiled or\nlinked with it, is called a \"work that uses the Library\".  Such a\nwork, in isolation, is not a derivative work of the Library, and\ntherefore falls outside the scope of this License.\n\n  However, linking a \"work that uses the Library\" with the Library\ncreates an executable that is a derivative of the Library (because it\ncontains portions of the Library), rather than a \"work that uses the\nlibrary\".  The executable is therefore covered by this License.\nSection 6 states terms for distribution of such executables.\n\n  When a \"work that uses the Library\" uses material from a header file\nthat is part of the Library, the object code for the work may be a\nderivative work of the Library even though the source code is not.\nWhether this is true is especially significant if the work can be\nlinked without the Library, or if the work is itself a library.  The\nthreshold for this to be true is not precisely defined by law.\n\n  If such an object file uses only numerical parameters, data\nstructure layouts and accessors, and small macros and small inline\nfunctions (ten lines or less in length), then the use of the object\nfile is unrestricted, regardless of whether it is legally a derivative\nwork.  (Executables containing this object code plus portions of the\nLibrary will still fall under Section 6.)\n\n  Otherwise, if the work is a derivative of the Library, you may\ndistribute the object code for the work under the terms of Section 6.\nAny executables containing that work also fall under Section 6,\nwhether or not they are linked directly with the Library itself.\n\n  6. As an exception to the Sections above, you may also combine or\nlink a \"work that uses the Library\" with the Library to produce a\nwork containing portions of the Library, and distribute that work\nunder terms of your choice, provided that the terms permit\nmodification of the work for the customer's own use and reverse\nengineering for debugging such modifications.\n\n  You must give prominent notice with each copy of the work that the\nLibrary is used in it and that the Library and its use are covered by\nthis License.  You must supply a copy of this License.  If the work\nduring execution displays copyright notices, you must include the\ncopyright notice for the Library among them, as well as a reference\ndirecting the user to the copy of this License.  Also, you must do one\nof these things:\n\n    a) Accompany the work with the complete corresponding\n    machine-readable source code for the Library including whatever\n    changes were used in the work (which must be distributed under\n    Sections 1 and 2 above); and, if the work is an executable linked\n    with the Library, with the complete machine-readable \"work that\n    uses the Library\", as object code and/or source code, so that the\n    user can modify the Library and then relink to produce a modified\n    executable containing the modified Library.  (It is understood\n    that the user who changes the contents of definitions files in the\n    Library will not necessarily be able to recompile the application\n    to use the modified definitions.)\n\n    b) Use a suitable shared library mechanism for linking with the\n    Library.  A suitable mechanism is one that (1) uses at run time a\n    copy of the library already present on the user's computer system,\n    rather than copying library functions into the executable, and (2)\n    will operate properly with a modified version of the library, if\n    the user installs one, as long as the modified version is\n    interface-compatible with the version that the work was made with.\n\n    c) Accompany the work with a written offer, valid for at\n    least three years, to give the same user the materials\n    specified in Subsection 6a, above, for a charge no more\n    than the cost of performing this distribution.\n\n    d) If distribution of the work is made by offering access to copy\n    from a designated place, offer equivalent access to copy the above\n    specified materials from the same place.\n\n    e) Verify that the user has already received a copy of these\n    materials or that you have already sent this user a copy.\n\n  For an executable, the required form of the \"work that uses the\nLibrary\" must include any data and utility programs needed for\nreproducing the executable from it.  However, as a special exception,\nthe materials to be distributed need not include anything that is\nnormally distributed (in either source or binary form) with the major\ncomponents (compiler, kernel, and so on) of the operating system on\nwhich the executable runs, unless that component itself accompanies\nthe executable.\n\n  It may happen that this requirement contradicts the license\nrestrictions of other proprietary libraries that do not normally\naccompany the operating system.  Such a contradiction means you cannot\nuse both them and the Library together in an executable that you\ndistribute.\n\n  7. You may place library facilities that are a work based on the\nLibrary side-by-side in a single library together with other library\nfacilities not covered by this License, and distribute such a combined\nlibrary, provided that the separate distribution of the work based on\nthe Library and of the other library facilities is otherwise\npermitted, and provided that you do these two things:\n\n    a) Accompany the combined library with a copy of the same work\n    based on the Library, uncombined with any other library\n    facilities.  This must be distributed under the terms of the\n    Sections above.\n\n    b) Give prominent notice with the combined library of the fact\n    that part of it is a work based on the Library, and explaining\n    where to find the accompanying uncombined form of the same work.\n\n  8. You may not copy, modify, sublicense, link with, or distribute\nthe Library except as expressly provided under this License.  Any\nattempt otherwise to copy, modify, sublicense, link with, or\ndistribute the Library is void, and will automatically terminate your\nrights under this License.  However, parties who have received copies,\nor rights, from you under this License will not have their licenses\nterminated so long as such parties remain in full compliance.\n\n  9. You are not required to accept this License, since you have not\nsigned it.  However, nothing else grants you permission to modify or\ndistribute the Library or its derivative works.  These actions are\nprohibited by law if you do not accept this License.  Therefore, by\nmodifying or distributing the Library (or any work based on the\nLibrary), you indicate your acceptance of this License to do so, and\nall its terms and conditions for copying, distributing or modifying\nthe Library or works based on it.\n\n  10. Each time you redistribute the Library (or any work based on the\nLibrary), the recipient automatically receives a license from the\noriginal licensor to copy, distribute, link with or modify the Library\nsubject to these terms and conditions.  You may not impose any further\nrestrictions on the recipients' exercise of the rights granted herein.\nYou are not responsible for enforcing compliance by third parties with\nthis License.\n\n  11. If, as a consequence of a court judgment or allegation of patent\ninfringement or for any other reason (not limited to patent issues),\nconditions are imposed on you (whether by court order, agreement or\notherwise) that contradict the conditions of this License, they do not\nexcuse you from the conditions of this License.  If you cannot\ndistribute so as to satisfy simultaneously your obligations under this\nLicense and any other pertinent obligations, then as a consequence you\nmay not distribute the Library at all.  For example, if a patent\nlicense would not permit royalty-free redistribution of the Library by\nall those who receive copies directly or indirectly through you, then\nthe only way you could satisfy both it and this License would be to\nrefrain entirely from distribution of the Library.\n\nIf any portion of this section is held invalid or unenforceable under any\nparticular circumstance, the balance of the section is intended to apply,\nand the section as a whole is intended to apply in other circumstances.\n\nIt is not the purpose of this section to induce you to infringe any\npatents or other property right claims or to contest validity of any\nsuch claims; this section has the sole purpose of protecting the\nintegrity of the free software distribution system which is\nimplemented by public license practices.  Many people have made\ngenerous contributions to the wide range of software distributed\nthrough that system in reliance on consistent application of that\nsystem; it is up to the author/donor to decide if he or she is willing\nto distribute software through any other system and a licensee cannot\nimpose that choice.\n\nThis section is intended to make thoroughly clear what is believed to\nbe a consequence of the rest of this License.\n\n  12. If the distribution and/or use of the Library is restricted in\ncertain countries either by patents or by copyrighted interfaces, the\noriginal copyright holder who places the Library under this License may add\nan explicit geographical distribution limitation excluding those countries,\nso that distribution is permitted only in or among countries not thus\nexcluded.  In such case, this License incorporates the limitation as if\nwritten in the body of this License.\n\n  13. The Free Software Foundation may publish revised and/or new\nversions of the Lesser General Public License from time to time.\nSuch new versions will be similar in spirit to the present version,\nbut may differ in detail to address new problems or concerns.\n\nEach version is given a distinguishing version number.  If the Library\nspecifies a version number of this License which applies to it and\n\"any later version\", you have the option of following the terms and\nconditions either of that version or of any later version published by\nthe Free Software Foundation.  If the Library does not specify a\nlicense version number, you may choose any version ever published by\nthe Free Software Foundation.\n\n  14. If you wish to incorporate parts of the Library into other free\nprograms whose distribution conditions are incompatible with these,\nwrite to the author to ask for permission.  For software which is\ncopyrighted by the Free Software Foundation, write to the Free\nSoftware Foundation; we sometimes make exceptions for this.  Our\ndecision will be guided by the two goals of preserving the free status\nof all derivatives of our free software and of promoting the sharing\nand reuse of software generally.\n\n                            NO WARRANTY\n\n  15. BECAUSE THE LIBRARY IS LICENSED FREE OF CHARGE, THERE IS NO\nWARRANTY FOR THE LIBRARY, TO THE EXTENT PERMITTED BY APPLICABLE LAW.\nEXCEPT WHEN OTHERWISE STATED IN WRITING THE COPYRIGHT HOLDERS AND/OR\nOTHER PARTIES PROVIDE THE LIBRARY \"AS IS\" WITHOUT WARRANTY OF ANY\nKIND, EITHER EXPRESSED OR IMPLIED, INCLUDING, BUT NOT LIMITED TO, THE\nIMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR\nPURPOSE.  THE ENTIRE RISK AS TO THE QUALITY AND PERFORMANCE OF THE\nLIBRARY IS WITH YOU.  SHOULD THE LIBRARY PROVE DEFECTIVE, YOU ASSUME\nTHE COST OF ALL NECESSARY SERVICING, REPAIR OR CORRECTION.\n\n  16. IN NO EVENT UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN\nWRITING WILL ANY COPYRIGHT HOLDER, OR ANY OTHER PARTY WHO MAY MODIFY\nAND/OR REDISTRIBUTE THE LIBRARY AS PERMITTED ABOVE, BE LIABLE TO YOU\nFOR DAMAGES, INCLUDING ANY GENERAL, SPECIAL, INCIDENTAL OR\nCONSEQUENTIAL DAMAGES ARISING OUT OF THE USE OR INABILITY TO USE THE\nLIBRARY (INCLUDING BUT NOT LIMITED TO LOSS OF DATA OR DATA BEING\nRENDERED INACCURATE OR LOSSES SUSTAINED BY YOU OR THIRD PARTIES OR A\nFAILURE OF THE LIBRARY TO OPERATE WITH ANY OTHER SOFTWARE), EVEN IF\nSUCH HOLDER OR OTHER PARTY HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH\nDAMAGES.\n\n                     END OF TERMS AND CONDITIONS\n\n           How to Apply These Terms to Your New Libraries\n\n  If you develop a new library, and you want it to be of the greatest\npossible use to the public, we recommend making it free software that\neveryone can redistribute and change.  You can do so by permitting\nredistribution under these terms (or, alternatively, under the terms of the\nordinary General Public License).\n\n  To apply these terms, attach the following notices to the library.  It is\nsafest to attach them to the start of each source file to most effectively\nconvey the exclusion of warranty; and each file should have at least the\n\"copyright\" line and a pointer to where the full notice is found.\n\n    <one line to give the library's name and a brief idea of what it does.>\n    Copyright (C) <year>  <name of author>\n\n    This library is free software; you can redistribute it and/or\n    modify it under the terms of the GNU Lesser General Public\n    License as published by the Free Software Foundation; either\n    version 2.1 of the License, or (at your option) any later version.\n\n    This library is distributed in the hope that it will be useful,\n    but WITHOUT ANY WARRANTY; without even the implied warranty of\n    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU\n    Lesser General Public License for more details.\n\n    You should have received a copy of the GNU Lesser General Public\n    License along with this library; if not, write to the Free Software\n    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301\n    USA\n\nAlso add information on how to contact you by electronic and paper mail.\n\nYou should also get your employer (if you work as a programmer) or your\nschool, if any, to sign a \"copyright disclaimer\" for the library, if\nnecessary.  Here is a sample; alter the names:\n\n  Yoyodyne, Inc., hereby disclaims all copyright interest in the\n  library `Frob' (a library for tweaking knobs) written by James Random\n  Hacker.\n\n  <signature of Ty Coon>, 1 April 1990\n  Ty Coon, President of Vice\n\nThat's all there is to it!";
        public static readonly string[] LincenseStrArray = LincenseStr.Split('\n');
        public const string Version = "2.0.0.0";
        public const string NameStr ="   _____  _     _____ ____  ____  _     ____  _      ____  ____  _     ____  ____  ____  _      _____ _  _____ _____ ____  _  _____  _____ ____ \n" + "  /__ __\\/ \\ /|/  __//   _\\/  _ \\/ \\   /  _ \\/ \\  /|/  _ \\/  __\\/ \\   /  _ \\/   _\\/  _ \\/ \\  /|/    // \\/  __//  __//  _ \\/ \\/__ __\\/  __//  __\\\n" + "    / \\  | |_|||  \\  |  /  | / \\|| |   | | \\|| |  ||| / \\||  \\/|| |   | | \\||  /  | / \\|| |\\ |||  __\\| || |  _|  \\  | | \\|| |  / \\  |  \\  |  \\/|\n" + "    | |  | | |||  /_ |  \\__| \\_/|| |_/\\| |_/|| |/\\||| \\_/||    /| |_/\\| |_/||  \\__| \\_/|| | \\||| |   | || |_//|  /_ | |_/|| |  | |  |  /_ |    /\n" + "    \\_/  \\_/ \\|\\____\\\\____/\\____/\\____/\\____/\\_/  \\|\\____/\\_/\\_\\\\____/\\____/\\____/\\____/\\_/  \\|\\_/   \\_/\\____\\\\____\\\\____/\\_/  \\_/  \\____\\\\_/\\_\\" + "";
    }
    public class For_String
    {
        public class Headers
        {
            //成员函数
            public void Replace(Headers Others)
            {
                this._Headers = new Header[Others._Headers.Length];
                for (int i = 0; i < Others.Length; i++)
                {
                    this._Headers[i] = new(Others[i]);
                }
            }
            //构造函数
            private protected Headers() { }
            public Headers(Headers Others)
            {
                this._Headers = new Header[Others._Headers.Length];
                for (int i = 0; i < Others.Length; i++)
                {
                    this._Headers[i] = new(Others[i]);
                }
            }
            public Headers(Header[] Headers)
            {
                this._Headers = new Header[Headers.Length];
                for (int i = 0; i < Headers.Length; i++)
                {
                    this._Headers[i] = new(Headers[i]);
                }
            }
            public Headers(System.Collections.Generic.IEnumerable<Header> Headers)
            {
                this._Headers = Headers.ToArray();
            }
            public Headers(string SerializedString, string Separator = "\n", System.StringSplitOptions SplitOptions = System.StringSplitOptions.None)
            {
                this.Init_SerializedStringArray(SerializedString.Split(new string[] { Separator }, SplitOptions));
            }
            public Headers(string[] SerializedStringArray)
            {
                this.Init_SerializedStringArray(SerializedStringArray);
            }
            public Headers(System.Collections.Generic.IEnumerable<string> SerializedStringArray)
            {
                this.Init_SerializedStringArray(SerializedStringArray.ToArray());
            }
            private void Init_SerializedStringArray(string[] SerializedStringArray)
            {
                //创建一个二维列表来储存首尾数据
                System.Collections.Generic.List<System.Collections.Generic.List<int>> Lines = new();
                for (int index = 0; index < SerializedStringArray.Length; index++)
                {
                    //捕获头标志
                    if (SerializedStringArray[index][SerializedStringArray[index].Length - 1] == ':')
                    {
                        for (int i = index; i < SerializedStringArray.Length; i++)
                        {
                            if (SerializedStringArray[i] == "}")
                            {
                                //储存数据
                                Lines.Add(new int[] { index, i }.ToList());
                                //将索引跳转
                                index = i;
                                break;
                            }
                        }

                    }
                }
                _Headers = new Header[Lines.Count];//创建对象数组
                for (int LinesIndex = 0; LinesIndex < Lines.Count; LinesIndex++)
                {
                    System.Collections.Generic.List<string> strings = new();
                    //复制序列化数据
                    for (int i = Lines[LinesIndex][0]; i <= Lines[LinesIndex][1]; i++)
                    {
                        strings.Add(SerializedStringArray[i]);
                    }

                    _Headers[LinesIndex] = new(strings);
                }
            }
            //变量
            private Header[] _Headers;
            //运算符
            public override bool Equals(object obj)
            {
                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (ReferenceEquals(obj, null))
                {
                    return false;
                }

                throw new System.NotImplementedException();
            }
            public static Headers operator +(Headers Left, Headers Right)
            {
                //创建列表合并_Headers
                System.Collections.Generic.List<Header> Headerss = new();
                for (int i = 0; i < Left._Headers.Length; i++)
                {
                    Headerss.Add(Left._Headers[i]);
                }
                for (int i = 0; i < Right._Headers.Length; i++)
                {
                    Headerss.Add(Right._Headers[i]);
                }
                return new(Headerss);
            }
            public static bool operator ==(Headers Left, Headers Right)
            {
                return Left._Headers == Right._Headers;
            }
            public static bool operator !=(Headers Left, Headers Right)
            {
                return Left._Headers != Right._Headers;
            }
            //属性
            public string SerializedString
            {
                get
                {
                    string returns = string.Empty;
                    for (int i = 0; i < _Headers.Length - 1; i++)
                    {
                        returns += _Headers[i].SerializedString + "\n";
                    }
                    returns += _Headers[_Headers.Length - 1].SerializedString;
                    return new(returns);
                }
            }
            public string[] SerializedStringArray
            {
                get
                {
                    System.Collections.Generic.List<string> returns = new();
                    for (int i = 0; i < _Headers.Length; i++)
                    {
                        for (int ii = 0; ii < _Headers[i].SerializedStringArray.Length; ii++)
                        {
                            returns.Add(_Headers[i].SerializedStringArray[ii]);
                        }
                    }
                    return returns.ToArray();
                }
            }
            public string EscapsedSerializedString
            {
                get
                {
                    string returns = string.Empty;
                    for (int i = 0; i < _Headers.Length - 1; i++)
                    {
                        returns += _Headers[i].EscapedSerializedString + "\n";
                    }
                    returns += _Headers[_Headers.Length - 1].EscapedSerializedString;
                    return new(returns);
                }
            }
            public string[] EscapedSerializedStringArray
            {
                get
                {
                    System.Collections.Generic.List<string> returns = new();
                    for (int i = 0; i < _Headers.Length; i++)
                    {
                        for (int ii = 0; ii < _Headers[i].EscapedSerializedStringArray.Length; ii++)
                        {
                            returns.Add(_Headers[i].EscapedSerializedStringArray[ii]);
                        }
                    }
                    return returns.ToArray();
                }
            }
            public long LongLength
            {
                get
                {
                    return _Headers.LongLength;
                }
            }
            public int Length
            {
                get
                {
                    return _Headers.Length;
                }
            }
            public ref Header this[string Index]
            {
                get
                {
                    int index = -114514;
                    for (int i = 0; i < _Headers.Length; i++)
                    {
                        if (Index == _Headers[i].Name)
                        {
                            index = i; break;
                        }
                    }
                    if (index <= 0)
                    {
                        return ref _Headers[index];
                    }
                    else
                    {
                        throw new Exceptions.ItemNotFoundException(Index);
                    }
                }
            }
            public Header this[int Index]
            {
                get
                {
                    return _Headers[Index];
                }
            }

        }
        public class Header
        {
            //成员函数
            public void Replace(Header Others)
            {
                this._Keys = new Key[Others._Keys.Length];
                for (int i = 0; i < Others._Keys.Length; i++)
                {
                    this._Keys[i] = new(Others[i]);
                }
            }
            //构造函数
            private protected Header() { }
            public Header(Header Others)
            {
                _Keys=new Key[Others._Keys.Length];
                System.Array.Copy(this._Keys, Others._Keys, Others._Keys.Length);
            }
            public Header(string name, Key[] Keys)
            {
                _Name=new(name);
                _Keys =new Key[Keys.Length];
                for (int i = 0; i < Keys.Length; i++)
                {
                    _Keys[i] = new(Keys[i]);
                }
            }
            public Header(string name, System.Collections.Generic.IEnumerable<Key> Keys)
            {
                _Name = name;
                _Keys = Keys.ToArray();
            }
            public Header(string SerializedString, string Separator = "\n", System.StringSplitOptions SplitOptions = System.StringSplitOptions.None)
            {
                this.Init_SerializedStringArray(SerializedString.Split(new string[] { Separator }, SplitOptions));
            }
            public Header(string[] SerializedStringArray)
            {
                this.Init_SerializedStringArray(SerializedStringArray);
            }
            public Header(System.Collections.Generic.IEnumerable<string> SerializedStringArray)
            {
                this.Init_SerializedStringArray(SerializedStringArray.ToArray());
            }
            private void Init_SerializedStringArray(string[] SerializedStringArray)
            {
                //检测序列化格式
                if (SerializedStringArray[0][SerializedStringArray[0].Length-1] != ':') { throw new Exceptions.FormatException(); }
                if (SerializedStringArray[1] != "{") { throw new Exceptions.FormatException(); }
                if (SerializedStringArray[SerializedStringArray.Length - 1] != "}") { throw new Exceptions.FormatException(); }
                _Name = new(SerializedStringArray[0].Replace(":", string.Empty));//复制名字
                _Keys = new Key[SerializedStringArray.Length - 3];
                for (int i = 2, k = 0; i < SerializedStringArray.Length - 1; i++, k++)
                {
                    _Keys[k] = new(SerializedStringArray[i]);//复制Key
                }
            }
            //变量
            private string _Name;
            private Key[] _Keys;
            //运算符
            public override bool Equals(object obj)
            {
                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (ReferenceEquals(obj, null))
                {
                    return false;
                }

                throw new System.NotImplementedException();
            }
            public static bool operator ==(Header Left, Header Right)
            {
                return Left._Name == Right._Name && Left._Keys == Right._Keys;
            }
            public static bool operator !=(Header Left, Header Right)
            {
                return Left._Name != Right._Name && Left._Keys != Right._Keys;
            }
            //属性
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }  
            }
            public string SerializedString
            {
                get
                {
                        string returns = _Name+":\n{\n";//添加头
                        for (int i = 0; i < _Keys.Length-1; i++)
                        {
                            returns += _Keys[i].SerializedString + "\n";//添加Key
                        }
                        returns += _Keys[_Keys.Length - 1].SerializedString+"\n}";//添加尾
                        return new(returns);
                }
            }
            public string[] SerializedStringArray
            {
                get
                {
                    System.Collections.Generic.List<string> returns = new()
                    {
                        _Name + ":",
                        "{"
                    };//创建List并添加头
                    for (int i = 0; i < _Keys.Length; i++)
                    {
                        returns.Add(_Keys[i].SerializedString);//添加Key
                    }
                    returns.Add("}");//添加尾
                    return returns.ToArray();//返回数组
                }
            }
            public string EscapedSerializedString
            {
                get
                {
                    string returns = _Name + ":\n{\n";//添加头
                    for (int i = 0; i < _Keys.Length - 1; i++)
                    {
                        returns += _Keys[i].EscapedSerializedString + "\n";//添加Key
                    }
                    returns += _Keys[_Keys.Length - 1].EscapedSerializedString + "\n}";//添加尾
                    return new(returns);
                }
            }
            public string[] EscapedSerializedStringArray
            {
                get
                {
                    System.Collections.Generic.List<string> returns = new()
                    {
                        _Name + ":",
                        "{"
                    };//创建List并添加头
                    for (int i = 0; i < _Keys.Length; i++)
                    {
                        returns.Add(_Keys[i].EscapedSerializedString);//添加Key
                    }
                    returns.Add("}");//添加尾
                    return returns.ToArray();//返回数组
                }
            }
            public long LongLength
                {
                    get
                    {
                        return _Keys.LongLength;
                    }
                }
            public int Length
            {
                get
                {
                    return _Keys.Length;
                }
            }
            public ref Key this[string Index]
                {
                    get
                    {
                        int index = -114514;
                        for (int i = 0; i < _Keys.Length; i++)
                        {
                            if (Index == _Keys[i].Name)
                            {
                                index = i; break;
                            }
                        }
                        if (index >= 0)
                        {
                            return ref _Keys[index];
                        }
                        else
                        {
                            throw new Exceptions.ItemNotFoundException(Index);
                        }
                    }
                }
                public Key this[int Index]
                {
                    get
                    {
                        return _Keys[Index];
                    }
                }
            }
        public class Key
        {
            //成员函数
            public void Replace(Key other)
            {
                _Name= new(other._Name); 
                _Value= new(other._Value);
            }
            //构造函数
            public Key(string SerializedString)
            {
                string[] tmp = SerializedString.Split(new string[] { "=" }, System.StringSplitOptions.None);//分割字符串
                switch (tmp.Length) 
                {
                    case 1:
                        {
                            _Name = new(tmp[0]);
                            _Value = new();
                        }
                        break;
                    case 2: 
                        {
                            _Name = new(tmp[0]);
                            _Value = new(tmp[1]);  
                        }
                        break;
                    case 0:
                        throw new Exceptions.FormatException();
                    default:
                        {
                            _Name = new(tmp[0]);
                            string tmp1 = string.Empty;
                            for (int i = 1; i < tmp.Length-1; i++)
                            {
                                tmp1 += tmp[i] + "=";
                            }
                            tmp1 += tmp[tmp.Length - 1];
                            _Value = new(tmp1);
                        }
                        break;
                }
            }
            public Key(Key Others)
            {
                _Name = new(Others._Name);
                _Value = new(Others._Value);
            }
            public Key(string Name, Value Value)
            {
                _Name = new(Name);
                _Value = new(Value);
            }
            //变量
            private string _Name;
            private Value _Value;
            //运算符
            public override bool Equals(object obj)
            {
                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (ReferenceEquals(obj, null))
                {
                    return false;
                }

                throw new System.NotImplementedException();
            }
            public static bool operator ==(Key Left, Key Right)
            {
                return Left._Name == Right._Name && Left._Value == Right._Value;
            }
            public static bool operator !=(Key Left, Key Right)
            {
                return Left._Name != Right._Name && Left._Value != Right._Value;
            }
            //属性
            public string SerializedString
            {
                get
                {
                    return _Name + "=" + _Value.BackEscapedString;
                }
            }
            public string EscapedSerializedString
            {
                get
                {
                    return _Name + "=" + _Value.EscapedString;
                }
            }
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
        }
        public class Value
        {
            //构造函数
            public Value()
            {
                _Value = string.Empty;
            }
            public Value(string Value)
            {
                _Value = Value;
            }
            public Value(Value Value)
            {
                _Value = new(Value._Value);
            }
            //成员函数
            public string BackEscapedString { get { return BackEscapeCharacterConversion(_Value); } }
            public string EscapedString { get { return EscapeCharacterConversion(_Value); } }
            public override string ToString() { return _Value; }
            public int ToInt() { return System.Convert.ToInt32(_Value); }
            public long ToLong() { return System.Convert.ToInt64(_Value); }
            public short ToShort() { return System.Convert.ToInt16(_Value); }
            public uint ToUint() { return System.Convert.ToUInt32(_Value); }
            public ulong ToUlong() { return System.Convert.ToUInt64(_Value); }
            public ushort ToUshort() { return System.Convert.ToUInt16(_Value); }
            public double ToDouble() { return System.Convert.ToDouble(_Value); }
            public bool ToBool() { return System.Convert.ToBoolean(_Value); }
            public byte[] ToBytes() { return System.Text.Encoding.UTF8.GetBytes(_Value); }
            //变量
            private string _Value;
            //运算符
            public override bool Equals(object obj)
            {
                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (ReferenceEquals(obj, null))
                {
                    return false;
                }

                throw new System.NotImplementedException();
            }
            public static bool operator ==(Value Left, Value Right)
            {
                return Left._Value == Right._Value;
            }
            public static bool operator !=(Value Left, Value Right)
            {
                return Left._Value != Right._Value;
            }
        }
        public static string EscapeCharacterConversion(string String)
        {
            return new string(String)
                .Replace("[\\n]", "\n")
                .Replace("[\\b]", "\b")
                .Replace("[\\a]", "\a")
                .Replace("[\\t]", "\t")
                .Replace("[Trademark]", "™")
                .Replace("[TM]", "™")
                .Replace("[\\u2122]", "™")
                .Replace("[Copyright]", "©")
                .Replace("[\\u00A9]", "©")
                .Replace("[Registered]", "®")
                .Replace("[\\u00ae]", "®")
                .Replace("[ServiceMark]", "℠")
                .Replace("[\\u2120]", "℠")
                .Replace("[114514]", "哼哼哼，啊啊啊啊啊啊啊啊啊啊")
                .Replace("[:]", ":")
                ;
        }
        public static string BackEscapeCharacterConversion(string String)
        {
            return new string(String)
                .Replace("\n", "[\\n]")
                .Replace( "\b", "[\\b]")
                .Replace("\a", "[\\a]")
                .Replace("\t", "[\\t]")
                .Replace("™", "[Trademark]")
                .Replace("™", "[TM]")
                .Replace("™", "[\\u2122]")
                .Replace("©", "[Copyright]")
                .Replace("©", "[\\u00A9]")
                .Replace("®", "[Registered]")
                .Replace("®", "[\\u00ae]")
                .Replace("℠", "[ServiceMark]")
                .Replace("℠", "[\\u2120]")
                ;
        }
    }
    public class IO
    {
        public static For_String.Headers ReadToHeaders(string FilePath)
        {
            return new(System.IO.File.ReadAllLines(FilePath));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileEncding">输出文件的编码，如果为null为UTF-8</param>
        public static void ReWriteToFile(string FilePath,For_String.Header Header,System.Text.Encoding FileEncding)
        {
            if (FileEncding == null) FileEncding = System.Text.Encoding.UTF8;
            System.IO.File.Delete(FilePath);
            using (System.IO.FileStream fs = new(FilePath, System.IO.FileMode.CreateNew, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite))
            {
                byte[] tmp = FileEncding.GetBytes(Header.SerializedString);
                fs.Write(tmp, 0, tmp.Length);   
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileEncding">输出文件的编码，如果为null为UTF-8</param>
        public async static System.Threading.Tasks.Task ReWriteToFileAsync(string FilePath, For_String.Header Header, System.Text.Encoding FileEncding,System.Action CallBack)
        {
            if (FileEncding == null) FileEncding = System.Text.Encoding.UTF8;
            System.IO.File.Delete(FilePath);
            using (System.IO.FileStream fs = new(FilePath, System.IO.FileMode.CreateNew, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite))
            {
                byte[] tmp = FileEncding.GetBytes(Header.SerializedString);
                fs.Write(tmp, 0, tmp.Length);
            }
            CallBack();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileEncding">输出文件的编码，如果为null为UTF-8</param>
        public static void ReWriteToFile(string FilePath, For_String.Headers Header, System.Text.Encoding FileEncding)
        {
            if (FileEncding == null) FileEncding = System.Text.Encoding.UTF8;
            System.IO.File.Delete(FilePath);
            using (System.IO.FileStream fs = new(FilePath, System.IO.FileMode.CreateNew, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite))
            {
                byte[] tmp = FileEncding.GetBytes(Header.SerializedString);
                fs.Write(tmp, 0, tmp.Length);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileEncding">输出文件的编码，如果为null为UTF-8</param>
        public async static System.Threading.Tasks.Task ReWriteToFileAsync(string FilePath, For_String.Headers Header, System.Text.Encoding FileEncding, System.Action CallBack)
        {
            if (FileEncding == null) FileEncding = System.Text.Encoding.UTF8;
            System.IO.File.Delete(FilePath);
            using (System.IO.FileStream fs = new(FilePath, System.IO.FileMode.CreateNew, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite))
            {
                byte[] tmp = FileEncding.GetBytes(Header.SerializedString);
                fs.Write(tmp, 0, tmp.Length);
            }
            CallBack();
        }
    }
    namespace Exceptions
    {
        public class InternalException : System.Exception
        {
            public InternalException(string Message):base(Message) { }  
        }

        public class FormatException : InternalException
        {
            public FormatException() : base("Format error: Check that the string you entered is correct") { }
        }

        public class ItemNotFoundException:InternalException
        {
            public ItemNotFoundException(string ItemName) :base("Item \'"+ItemName+"\' not found") { }
        }
    }
}